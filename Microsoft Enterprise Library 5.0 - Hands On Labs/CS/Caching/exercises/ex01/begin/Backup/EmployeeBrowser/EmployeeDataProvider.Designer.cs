namespace EmployeeBrowser
{
    partial class EmployeeDataProvider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.cmdGetEmployeePhoto = new System.Data.SqlClient.SqlCommand();
            this.employeesTableAdapter1 = new EmployeeBrowser.EmployeesDataSetTableAdapters.EmployeesTableAdapter();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConnection1.ConnectionString", typeof(string))));
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // cmdGetEmployeePhoto
            // 
            this.cmdGetEmployeePhoto.CommandText = "SELECT Photo FROM Employees WHERE (EmployeeID = @EmployeeId)";
            this.cmdGetEmployeePhoto.Connection = this.sqlConnection1;
            this.cmdGetEmployeePhoto.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@EmployeeId", System.Data.SqlDbType.UniqueIdentifier, 16, "EmployeeID")});
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand cmdGetEmployeePhoto;
        private EmployeeBrowser.EmployeesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter1;

    }
}
