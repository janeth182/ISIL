using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UserStore;
using UserUI.Dialogs;

namespace UserUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            string currentValue = (string) this.listBox1.SelectedItem;

            string[] names = UserManager.GetNames();

            this.listBox1.DataSource = names;
            this.listBox1.ValueMember = "";

            if (currentValue != null)
                this.listBox1.SelectedItem = currentValue;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UserDialogBase f = new NewUser();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                UserManager.CreateUser(f.Username, f.Password);
                RefreshList();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string name = (string)this.listBox1.SelectedItem;
            
            if (name != null)
            {
                ChangePwd f = new ChangePwd(name);
                f.ShowDialog();

                if (f.DialogResult == DialogResult.OK)
                {
                    bool changed = UserManager.ChangePassword(f.Username, f.OldPassword, f.Password);
                    if (!changed)
                        MessageBox.Show("Failed to change password for " + f.Username);

                    RefreshList();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string name = (string)this.listBox1.SelectedItem;

            if (name != null)
            {
                UserDialogBase f = new ResetPwd(name);
                f.ShowDialog();

                if (f.DialogResult == DialogResult.OK)
                {
                    UserManager.ResetPassword(f.Username, f.Password);
                    RefreshList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = (string)this.listBox1.SelectedItem;

            if (name != null)
            {
                UserManager.DeleteUser(name);
                RefreshList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserManager.Save();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UserManager.Refresh();
            RefreshList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}