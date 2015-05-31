namespace UserUI.Dialogs
{
    partial class ChangePwd
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(13, 94);
            this.lblPassword.Size = new System.Drawing.Size(72, 40);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "New Password";
            // 
            // lblConfirm
            // 
            this.lblConfirm.Location = new System.Drawing.Point(13, 134);
            this.lblConfirm.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 94);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(97, 134);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(54, 182);
            this.btnOk.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(135, 182);
            this.btnCancel.TabIndex = 5;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(96, 55);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(114, 22);
            this.txtOldPassword.TabIndex = 1;
            this.txtOldPassword.Text = "P@ssw0rd";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Old Password";
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(222, 224);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.label1);
            this.Name = "ChangePwd";
            this.Text = "Change Password";
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.lblConfirm, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.txtConfirm, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtOldPassword, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtOldPassword;
        protected System.Windows.Forms.Label label1;
    }
}
