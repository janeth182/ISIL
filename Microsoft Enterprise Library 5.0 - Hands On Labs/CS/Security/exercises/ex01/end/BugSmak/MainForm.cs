using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security;
using System.Text;
using System.Windows.Forms;
using BugSmak.TaskForms;

namespace BugSmak
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Uninteresting Stuff
        private void MainForm_Load(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = new LoginForm().ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void mnuFileSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            DialogResult dr;
            dr = new LoginForm().ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private delegate BaseForm FormBuilder();

        private void mnuTaskNew_Click(object sender, EventArgs e)
        {
            OpenSecureForm(new FormBuilder(RaiseBug.Create));
        }

        private void mnuTaskAssign_Click(object sender, EventArgs e)
        {
            OpenSecureForm(new FormBuilder(AssignBug.Create));
        }

        private void mnuTaskResolve_Click(object sender, EventArgs e)
        {
            OpenSecureForm(new FormBuilder(ResolveBug.Create));
        }

        private void OpenSecureForm(FormBuilder builder)
        {
            try
            {
                BaseForm secureForm = builder.Invoke();

                secureForm.MdiParent = this;
                secureForm.WindowState = FormWindowState.Maximized;
                secureForm.Show();
            }
            catch (SecurityException)
            {
                MessageBox.Show("Sorry, you aren't allowed to access that form.");
            }
        }
    }
}