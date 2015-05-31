using System;
using System.Drawing;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations;

namespace EmployeeBrowser
{
    /// <summary>
    /// This class is responsible for retrieving
    /// employee data from either a local cache or
    /// the database.
    /// </summary>
    public class EmployeeService
    {
        private const string CACHE_KEY = "EmployeesDataSet";

        private EmployeeService()
        {
        }

        public static EmployeesDataSet GetContactDetails()
        {
            EmployeesDataSet dsEmployees = null;

            // Attempt to retrieve from cache
						ICacheManager cache = EnterpriseLibraryContainer.Current.GetInstance<ICacheManager>();
            dsEmployees = (EmployeesDataSet)cache[CACHE_KEY];

            // Retrieve from dataProvider if not in Cache and Online
            if (dsEmployees == null && ConnectionManager.IsOnline)
            {
                EmployeeDataProvider dataProvider = new EmployeeDataProvider();
                dsEmployees = dataProvider.GetEmployees();

                // Expire in 2 days
                AbsoluteTime expiry = new AbsoluteTime(new TimeSpan(2, 0, 0, 0));
                cache.Add(
                    CACHE_KEY,
                    dsEmployees,
                    CacheItemPriority.High,
                    null,
                    new ICacheItemExpiration[] { expiry });
            }

            return dsEmployees;
        }

        public static Bitmap GetEmployeePhoto(Guid employeeId)
        {
            byte[] photoData = null;

            // Attempt to retrieve from cache
						ICacheManager cache = EnterpriseLibraryContainer.Current.GetInstance<ICacheManager>();
            photoData = (byte[])cache[employeeId.ToString()];

            // Retrieve from dataProvider if not in Cache and Online
            if (photoData == null && ConnectionManager.IsOnline)
            {
                EmployeeDataProvider dataProvider = new EmployeeDataProvider();
                photoData = dataProvider.GetEmployeePhotoData(employeeId);

                cache.Add(employeeId.ToString(), photoData);
            }

            // No data found.
            if (photoData == null)
                return null;

            // Convert bytes to Bitmap
            using (MemoryStream ms = new MemoryStream(photoData))
            {
                return new Bitmap(ms);
            }
        }

        public static void ClearCache()
        {
					ICacheManager cache = EnterpriseLibraryContainer.Current.GetInstance<ICacheManager>();
            cache.Flush();
        }

        // TODO: PopulateCache & BeginBackgroundLoad

        private static void PopulateCache()
        {
            byte[] photoData = null;

            EmployeesDataSet dsEmployees = GetContactDetails();

            if (dsEmployees == null)
                return;

						ICacheManager cache = EnterpriseLibraryContainer.Current.GetInstance<ICacheManager>();

            foreach (EmployeesDataSet.EmployeesRow employee in dsEmployees.Employees)
            {
                if (!cache.Contains(employee.EmployeeID.ToString()))
                {
                    EmployeeDataProvider dataProvider = new EmployeeDataProvider();
                    photoData = dataProvider.GetEmployeePhotoData(employee.EmployeeID);
                    cache.Add(employee.EmployeeID.ToString(), photoData);
                }
            }
        }

        private delegate void PopulateCacheDelegate();

        public static void BeginBackgroundLoad()
        {
            if (!ConnectionManager.IsOnline)
                return;

            PopulateCacheDelegate mi = new PopulateCacheDelegate(PopulateCache);
            mi.BeginInvoke(null, null);
        }
    }
}
