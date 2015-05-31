namespace EmployeeBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label homePhoneLabel;
            System.Windows.Forms.Label extensionLabel;
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeesDataSet = new EmployeeBrowser.EmployeesDataSet();
            this.BindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.TitleOfCourtesyComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.BindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.TitleOfCourtesyLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.homePhoneTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            homePhoneLabel = new System.Windows.Forms.Label();
            extensionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).BeginInit();
            this.BindingNavigator1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "EmployeeID", true));
            this.lblEmployeeID.Location = new System.Drawing.Point(109, 407);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(281, 23);
            this.lblEmployeeID.TabIndex = 11;
            this.lblEmployeeID.TextChanged += new System.EventHandler(this.lblEmployeeID_TextChanged);
            // 
            // EmployeesBindingSource
            // 
            this.EmployeesBindingSource.DataMember = "Employees";
            this.EmployeesBindingSource.DataSource = this.EmployeesDataSet;
            // 
            // EmployeesDataSet
            // 
            this.EmployeesDataSet.DataSetName = "EmployeesDataSet";
            this.EmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BindingNavigatorMoveFirstItem1
            // 
            this.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem1.Image")));
            this.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1";
            this.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // BindingNavigatorCountItem1
            // 
            this.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1";
            this.BindingNavigatorCountItem1.Size = new System.Drawing.Size(36, 22);
            this.BindingNavigatorCountItem1.Text = "of {0}";
            this.BindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(294, 42);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(96, 112);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // BindingNavigatorMovePreviousItem1
            // 
            this.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem1.Image")));
            this.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1";
            this.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(0, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(402, 28);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Employee Details";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleOfCourtesyComboBox
            // 
            this.TitleOfCourtesyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "TitleOfCourtesy", true));
            this.TitleOfCourtesyComboBox.FormattingEnabled = true;
            this.TitleOfCourtesyComboBox.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Dr."});
            this.TitleOfCourtesyComboBox.Location = new System.Drawing.Point(105, 39);
            this.TitleOfCourtesyComboBox.Name = "TitleOfCourtesyComboBox";
            this.TitleOfCourtesyComboBox.Size = new System.Drawing.Size(60, 24);
            this.TitleOfCourtesyComboBox.TabIndex = 7;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "FirstName", true));
            this.FirstNameTextBox.Location = new System.Drawing.Point(105, 69);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "LastName", true));
            this.LastNameTextBox.Location = new System.Drawing.Point(105, 97);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // BindingNavigator1
            // 
            this.BindingNavigator1.AddNewItem = null;
            this.BindingNavigator1.BindingSource = this.EmployeesBindingSource;
            this.BindingNavigator1.CountItem = this.BindingNavigatorCountItem1;
            this.BindingNavigator1.DeleteItem = null;
            this.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem1,
            this.BindingNavigatorMovePreviousItem1,
            this.BindingNavigatorSeparator2,
            this.BindingNavigatorPositionItem1,
            this.BindingNavigatorCountItem1,
            this.BindingNavigatorSeparator3,
            this.BindingNavigatorMoveNextItem1,
            this.BindingNavigatorMoveLastItem1,
            this.ToolStripLabel1});
            this.BindingNavigator1.Location = new System.Drawing.Point(0, 457);
            this.BindingNavigator1.MoveFirstItem = this.BindingNavigatorMoveFirstItem1;
            this.BindingNavigator1.MoveLastItem = this.BindingNavigatorMoveLastItem1;
            this.BindingNavigator1.MoveNextItem = this.BindingNavigatorMoveNextItem1;
            this.BindingNavigator1.MovePreviousItem = this.BindingNavigatorMovePreviousItem1;
            this.BindingNavigator1.Name = "BindingNavigator1";
            this.BindingNavigator1.PositionItem = this.BindingNavigatorPositionItem1;
            this.BindingNavigator1.Size = new System.Drawing.Size(586, 25);
            this.BindingNavigator1.TabIndex = 6;
            this.BindingNavigator1.Text = "BindingNavigator2";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorPositionItem1
            // 
            this.BindingNavigatorPositionItem1.AccessibleName = "Position";
            this.BindingNavigatorPositionItem1.AutoSize = false;
            this.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1";
            this.BindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
            this.BindingNavigatorPositionItem1.Text = "0";
            this.BindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator3
            // 
            this.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3";
            this.BindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorMoveNextItem1
            // 
            this.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem1.Image")));
            this.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1";
            this.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // BindingNavigatorMoveLastItem1
            // 
            this.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem1.Image")));
            this.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1";
            this.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.ToolStripLabel1.Text = "ToolStripLabel1";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(14, 407);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(89, 16);
            this.EmployeeIDLabel.TabIndex = 10;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // TitleOfCourtesyLabel
            // 
            this.TitleOfCourtesyLabel.Location = new System.Drawing.Point(14, 42);
            this.TitleOfCourtesyLabel.Name = "TitleOfCourtesyLabel";
            this.TitleOfCourtesyLabel.Size = new System.Drawing.Size(85, 16);
            this.TitleOfCourtesyLabel.TabIndex = 6;
            this.TitleOfCourtesyLabel.Text = "Title:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Location = new System.Drawing.Point(14, 72);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(85, 16);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(14, 100);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(85, 16);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(586, 24);
            this.MenuStrip1.TabIndex = 4;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearCacheToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // ClearCacheToolStripMenuItem
            // 
            this.ClearCacheToolStripMenuItem.Name = "ClearCacheToolStripMenuItem";
            this.ClearCacheToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ClearCacheToolStripMenuItem.Text = "&Clear Cache";
            this.ClearCacheToolStripMenuItem.Click += new System.EventHandler(this.ClearCacheToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Location = new System.Drawing.Point(14, 128);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(85, 16);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Job Title:";
            // 
            // ListBox1
            // 
            this.ListBox1.DataSource = this.EmployeesBindingSource;
            this.ListBox1.DisplayMember = "LastName";
            this.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(0, 28);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(180, 404);
            this.ListBox1.TabIndex = 1;
            this.ListBox1.ValueMember = "EmployeeID";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "Title", true));
            this.TitleTextBox.Location = new System.Drawing.Point(105, 125);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(171, 22);
            this.TitleTextBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(180, 28);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Employee List";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 24);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.ListBox1);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1MinSize = 100;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.AutoScroll = true;
            this.SplitContainer1.Panel2.Controls.Add(extensionLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.extensionTextBox);
            this.SplitContainer1.Panel2.Controls.Add(homePhoneLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.homePhoneTextBox);
            this.SplitContainer1.Panel2.Controls.Add(countryLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.countryTextBox);
            this.SplitContainer1.Panel2.Controls.Add(postalCodeLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.postalCodeTextBox);
            this.SplitContainer1.Panel2.Controls.Add(regionLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.regionTextBox);
            this.SplitContainer1.Panel2.Controls.Add(cityLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.cityTextBox);
            this.SplitContainer1.Panel2.Controls.Add(addressLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.addressTextBox);
            this.SplitContainer1.Panel2.Controls.Add(this.EmployeeIDLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.lblEmployeeID);
            this.SplitContainer1.Panel2.Controls.Add(this.PictureBox1);
            this.SplitContainer1.Panel2.Controls.Add(this.Label2);
            this.SplitContainer1.Panel2.Controls.Add(this.TitleOfCourtesyLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.TitleOfCourtesyComboBox);
            this.SplitContainer1.Panel2.Controls.Add(this.FirstNameLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.FirstNameTextBox);
            this.SplitContainer1.Panel2.Controls.Add(this.LastNameLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.LastNameTextBox);
            this.SplitContainer1.Panel2.Controls.Add(this.TitleLabel);
            this.SplitContainer1.Panel2.Controls.Add(this.TitleTextBox);
            this.SplitContainer1.Size = new System.Drawing.Size(586, 433);
            this.SplitContainer1.SplitterDistance = 180;
            this.SplitContainer1.TabIndex = 5;
            // 
            // addressLabel
            // 
            addressLabel.Location = new System.Drawing.Point(14, 156);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(85, 16);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(105, 153);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(171, 47);
            this.addressTextBox.TabIndex = 13;
            // 
            // cityLabel
            // 
            cityLabel.Location = new System.Drawing.Point(14, 209);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(85, 16);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(105, 203);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 15;
            // 
            // regionLabel
            // 
            regionLabel.Location = new System.Drawing.Point(14, 237);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(85, 16);
            regionLabel.TabIndex = 16;
            regionLabel.Text = "Region:";
            // 
            // regionTextBox
            // 
            this.regionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(105, 234);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(100, 22);
            this.regionTextBox.TabIndex = 17;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.Location = new System.Drawing.Point(14, 265);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(85, 16);
            postalCodeLabel.TabIndex = 18;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(105, 262);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.postalCodeTextBox.TabIndex = 19;
            // 
            // countryLabel
            // 
            countryLabel.Location = new System.Drawing.Point(14, 293);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(85, 16);
            countryLabel.TabIndex = 20;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(105, 290);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 22);
            this.countryTextBox.TabIndex = 21;
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.Location = new System.Drawing.Point(14, 321);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new System.Drawing.Size(90, 16);
            homePhoneLabel.TabIndex = 22;
            homePhoneLabel.Text = "Home Phone:";
            // 
            // homePhoneTextBox
            // 
            this.homePhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.homePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "HomePhone", true));
            this.homePhoneTextBox.Location = new System.Drawing.Point(105, 318);
            this.homePhoneTextBox.Name = "homePhoneTextBox";
            this.homePhoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.homePhoneTextBox.TabIndex = 23;
            // 
            // extensionLabel
            // 
            extensionLabel.Location = new System.Drawing.Point(14, 349);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new System.Drawing.Size(85, 16);
            extensionLabel.TabIndex = 24;
            extensionLabel.Text = "Extension:";
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EmployeesBindingSource, "Extension", true));
            this.extensionTextBox.Location = new System.Drawing.Point(105, 346);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(100, 22);
            this.extensionTextBox.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 482);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.BindingNavigator1);
            this.Controls.Add(this.MenuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Employee Browser";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).EndInit();
            this.BindingNavigator1.ResumeLayout(false);
            this.BindingNavigator1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblEmployeeID;
        internal System.Windows.Forms.BindingSource EmployeesBindingSource;
        internal EmployeesDataSet EmployeesDataSet;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem1;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox TitleOfCourtesyComboBox;
        internal System.Windows.Forms.TextBox FirstNameTextBox;
        internal System.Windows.Forms.TextBox LastNameTextBox;
        internal System.Windows.Forms.BindingNavigator BindingNavigator1;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem1;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator3;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.Label EmployeeIDLabel;
        internal System.Windows.Forms.Label TitleOfCourtesyLabel;
        internal System.Windows.Forms.Label FirstNameLabel;
        internal System.Windows.Forms.Label LastNameLabel;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ClearCacheToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.TextBox TitleTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox homePhoneTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
    }
}

