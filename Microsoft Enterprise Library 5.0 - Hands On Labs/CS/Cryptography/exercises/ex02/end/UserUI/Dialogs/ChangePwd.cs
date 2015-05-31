using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserUI.Dialogs
{
    public partial class ChangePwd : UserUI.Dialogs.UserDialogBase
    {
        public ChangePwd(string name)
        {
            InitializeComponent();

            // TODO: Initialise name field
            this.txtName.Text = name;
            this.txtName.Enabled = false;
        }

        public string OldPassword
        {
            get { return this.txtOldPassword.Text; }
        }
    }
}

