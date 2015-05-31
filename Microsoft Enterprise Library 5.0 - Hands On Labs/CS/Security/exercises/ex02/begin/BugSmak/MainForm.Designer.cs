namespace BugSmak
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaskNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaskAssign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaskResolve = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTasks});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSignOut,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileSignOut
            // 
            this.mnuFileSignOut.Name = "mnuFileSignOut";
            this.mnuFileSignOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.mnuFileSignOut.Size = new System.Drawing.Size(160, 22);
            this.mnuFileSignOut.Text = "&Sign Out";
            this.mnuFileSignOut.Click += new System.EventHandler(this.mnuFileSignOut_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuFileExit.Size = new System.Drawing.Size(160, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuTasks
            // 
            this.mnuTasks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaskNew,
            this.mnuTaskAssign,
            this.mnuTaskResolve});
            this.mnuTasks.Name = "mnuTasks";
            this.mnuTasks.Size = new System.Drawing.Size(46, 20);
            this.mnuTasks.Text = "&Tasks";
            // 
            // mnuTaskNew
            // 
            this.mnuTaskNew.Name = "mnuTaskNew";
            this.mnuTaskNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.mnuTaskNew.Size = new System.Drawing.Size(191, 22);
            this.mnuTaskNew.Tag = "Raise";
            this.mnuTaskNew.Text = "Raise &New Bug";
            this.mnuTaskNew.Click += new System.EventHandler(this.mnuTaskNew_Click);
            // 
            // mnuTaskAssign
            // 
            this.mnuTaskAssign.Name = "mnuTaskAssign";
            this.mnuTaskAssign.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mnuTaskAssign.Size = new System.Drawing.Size(191, 22);
            this.mnuTaskAssign.Tag = "Assign";
            this.mnuTaskAssign.Text = "&Assign Bug";
            this.mnuTaskAssign.Click += new System.EventHandler(this.mnuTaskAssign_Click);
            // 
            // mnuTaskResolve
            // 
            this.mnuTaskResolve.Name = "mnuTaskResolve";
            this.mnuTaskResolve.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.mnuTaskResolve.Size = new System.Drawing.Size(191, 22);
            this.mnuTaskResolve.Tag = "Resolve";
            this.mnuTaskResolve.Text = "&Resolve Bug";
            this.mnuTaskResolve.Click += new System.EventHandler(this.mnuTaskResolve_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 397);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "BugSmak - Bug Tracking System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuTasks;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSignOut;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTaskNew;
        private System.Windows.Forms.ToolStripMenuItem mnuTaskAssign;
        private System.Windows.Forms.ToolStripMenuItem mnuTaskResolve;
    }
}