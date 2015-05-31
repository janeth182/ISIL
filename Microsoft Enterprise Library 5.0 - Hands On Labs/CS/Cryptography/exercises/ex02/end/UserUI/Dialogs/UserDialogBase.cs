using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserUI.Dialogs
{
    public partial class UserDialogBase : Form
    {
        private const string errMsgUsername = "Must enter a name";
        private const string errMsgPassword = "Must enter non-zero length password";
        private const string errMsgPConfirm = "Passwords must match";

        public UserDialogBase()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return this.txtName.Text; }
        }

        public string Password
        {
            get { return this.txtPassword.Text; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateAll())
                this.DialogResult = DialogResult.OK;
        }

        #region Validation
        protected virtual bool ValidateAll()
        {
            bool valid = true;

            valid = valid && ValidateTextBox(this.txtName, errMsgUsername);
            valid = valid && ValidateTextBox(this.txtPassword, errMsgPassword);
            valid = valid && ValidateTextBox(this.txtConfirm, errMsgPassword);
            valid = valid && ValidatePassword(this.txtConfirm, errMsgPConfirm);

            return valid;
        }

        private bool ValidateTextBox(TextBox tb, string message)
        {
            if (tb.Text.Length == 0)
            {
                errorProvider1.SetError(tb, message);
                return false;
            }

            errorProvider1.SetError(tb, null);
            return true;
        }

        private bool ValidatePassword(TextBox tb, string message)
        {
            if (tb.Text != this.txtPassword.Text)
            {
                errorProvider1.SetError(tb, message);
                return false;
            }

            errorProvider1.SetError(tb, null);
            return true;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(this.txtName, errMsgUsername);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateTextBox(this.txtPassword, errMsgPassword))
                ValidatePassword(this.txtConfirm, errMsgPConfirm);
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateTextBox(this.txtConfirm, errMsgPassword))
                ValidatePassword(this.txtConfirm, errMsgPConfirm);
        }
        
        #endregion
    }
}