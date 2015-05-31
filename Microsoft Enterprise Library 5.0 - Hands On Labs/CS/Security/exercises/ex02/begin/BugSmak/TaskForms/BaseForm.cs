using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugSmak.Security;

namespace BugSmak.TaskForms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        #region Properties
        [Category("BugSmak"),Description("Form Task")]
        public string FormTask
        {
            get { return this.label1.Text; }
            set 
            { 
                this.label1.Text = value;
                this.Text = value;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}