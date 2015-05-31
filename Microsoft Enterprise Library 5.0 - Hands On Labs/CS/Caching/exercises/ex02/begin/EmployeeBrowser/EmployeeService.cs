using System;
using System.Drawing;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
// TODO: Use Caching Expirations

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

            // TODO: Add persistent caching with time-out

            EmployeeDataProvider dataProvider = new EmployeeDataProvider();
            dsEmployees = dataProvider.GetEmployees();

            return dsEmployees;
        }

        public static Bitmap GetEmployeePhoto(Guid employeeId)
        {
            byte[] photoData = null;

            // Attempt to retrieve from cache
						ICacheManager cache = EnterpriseLibraryContainer.Current.GetInstance<ICacheManager>();
						photoData = (byte[])cache[employeeId.ToString()];

            // TODO: Retrieve from dataProvider if not in Cache and Online
            if (photoData == null)
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
            // Clear Cache
					ICacheManager cache = EnterpriseLibraryContainer.Current.GetInstance<ICacheManager>();
					cache.Flush();
        }
    }
}
