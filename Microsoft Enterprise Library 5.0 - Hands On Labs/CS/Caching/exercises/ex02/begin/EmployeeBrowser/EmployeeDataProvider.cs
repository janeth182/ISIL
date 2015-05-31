using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace EmployeeBrowser
{
    /// <summary>
    /// This class is responsible for the data access
    /// to the database. We would normally have used the Data Access
    /// Block here, but didn't want to clutter the configuration
    /// file for this hands on lab.
    /// </summary>
    public partial class EmployeeDataProvider : Component
    {

        #region Uninteresting Stuff

        public EmployeeDataProvider()
        {
            InitializeComponent();
        }

        public EmployeeDataProvider(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// Get contact details for all employees from the database
        /// </summary>
        /// <returns>An EmployeesDataSet filled with the contact details</returns>
        public EmployeesDataSet GetEmployees()
        {
            EmployeesDataSet dsEmployees = new EmployeesDataSet();

            employeesTableAdapter1.Fill(dsEmployees.Employees);

            return dsEmployees;
        }

        /// <summary>
        /// Get a photo for a particular employee from the database
        /// </summary>
        /// <param name="employeeId">The database id of the employee</param>
        /// <returns>null if the photo cannot be found, otherwise a bitmap with the photo.</returns>
        public byte[] GetEmployeePhotoData(Guid employeeId)
        {
            object photoData;

            sqlConnection1.Open();
            try
            {
                cmdGetEmployeePhoto.Parameters["@EmployeeId"].Value = employeeId;

                photoData = cmdGetEmployeePhoto.ExecuteScalar();

                // HACK: Emulate a slow connection to the database.
                Thread.Sleep(1000); 
            }
            finally
            {
                sqlConnection1.Close();
            }

            if (photoData == null
                || photoData.GetType() == typeof(System.DBNull))
            {
                return null;
            }

            return (byte[])photoData;
        }

    }

}
