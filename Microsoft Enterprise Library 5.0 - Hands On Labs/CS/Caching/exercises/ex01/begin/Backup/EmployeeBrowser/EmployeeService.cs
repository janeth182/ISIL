using System;
using System.Drawing;
using System.IO;
// TODO: Use Caching

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

            EmployeeDataProvider dataProvider = new EmployeeDataProvider();
            dsEmployees = dataProvider.GetEmployees();

            return dsEmployees;
        }

        public static Bitmap GetEmployeePhoto(Guid employeeId)
        {
            byte[] photoData = null;

            // TODO: Add Caching of Photo
            EmployeeDataProvider dataProvider = new EmployeeDataProvider();
            photoData = dataProvider.GetEmployeePhotoData(employeeId);

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
          
            // TODO: Clear Cache

        }
    }
}
