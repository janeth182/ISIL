using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserUI.Dialogs
{
    public partial class ResetPwd : UserUI.Dialogs.UserDialogBase
    {
        public ResetPwd(string name)
        {
            InitializeComponent();

            // Init
            this.txtName.Text = name;
            this.txtName.Enabled = false;
        }
    }
}

