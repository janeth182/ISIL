using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeBrowser
{
    public partial class MainForm : Form
    {
        #region Uninteresting Stuff

        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeService.ClearCache();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblEmployeeID.Text))
                return;

            // Clear the current image
            Image img = PictureBox1.Image;
            PictureBox1.Image = null;

            if (img != null)
                img.Dispose();

            // Get the Photo
            this.Cursor = Cursors.WaitCursor;

            try
            {
                PictureBox1.Image = EmployeeService.GetEmployeePhoto(new Guid(lblEmployeeID.Text));
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ToolStripLabel1.Text = ConnectionManager.StatusText;

            // Load data into the 'EmployeesDataSet'.
            EmployeesDataSet tempDataset = EmployeeService.GetContactDetails();

            if (tempDataset != null)
                this.EmployeesDataSet.Merge(tempDataset);
        }
    }
}