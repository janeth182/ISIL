using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugSmak.Security;

namespace BugSmak
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            bool authenticated;
            authenticated = SecurityHelper.Authenticate(username, password);

            if (authenticated == true)
                this.DialogResult = DialogResult.OK;
            else
                this.errorLabel.Visible = true;
        }
    }
}