namespace Assignment4
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.CamTextBox = new System.Windows.Forms.TextBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumLabel = new System.Windows.Forms.Label();
            this.HardDriveTextBox = new System.Windows.Forms.TextBox();
            this.HardDriveLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.WebCameLabel = new System.Windows.Forms.Label();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.LCDTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.GPUTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.PrintToolStripMenuItem.Text = "&Print";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this._printToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this._exit_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.BackToolStripMenuItem.Text = "&Back";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this._back_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this._aboutToolStripMenuItem_Click);
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotalTextBox);
            this.PriceGroupBox.Controls.Add(this.CostLabel);
            this.PriceGroupBox.Controls.Add(this.TaxLabel);
            this.PriceGroupBox.Controls.Add(this.TaxTextBox);
            this.PriceGroupBox.Controls.Add(this.PriceTextBox);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Location = new System.Drawing.Point(390, 246);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(215, 143);
            this.PriceGroupBox.TabIndex = 1;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Product Cost";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(109, 99);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(99, 20);
            this.TotalTextBox.TabIndex = 5;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(20, 103);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(55, 13);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Total Cost";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(19, 61);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(83, 13);
            this.TaxLabel.TabIndex = 3;
            this.TaxLabel.Text = "Sales Tax (%13)";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(108, 58);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaxTextBox.TabIndex = 2;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(108, 28);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 1;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(19, 31);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // ComputerPictureBox
            // 
            this.ComputerPictureBox.Location = new System.Drawing.Point(390, 33);
            this.ComputerPictureBox.Name = "ComputerPictureBox";
            this.ComputerPictureBox.Size = new System.Drawing.Size(215, 206);
            this.ComputerPictureBox.TabIndex = 2;
            this.ComputerPictureBox.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 395);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this._back_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(390, 395);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(78, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this._exit_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(528, 395);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(77, 22);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this._finishButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 362);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Components";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ModelTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.ModelLabel);
            this.splitContainer1.Panel1.Controls.Add(this.PlatformTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.PlatformLabel);
            this.splitContainer1.Panel1.Controls.Add(this.ManufacturerTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.ManufacturerLabel);
            this.splitContainer1.Panel1.Controls.Add(this.ConditionTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.ConditionLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OSTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.OSLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CamTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.WebCamLabel);
            this.splitContainer1.Panel2.Controls.Add(this.SpeedTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.SpeedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CPUNumTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CPUNumLabel);
            this.splitContainer1.Panel2.Controls.Add(this.HardDriveTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.HardDriveLabel);
            this.splitContainer1.Panel2.Controls.Add(this.MemoryTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.MemoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.WebCamTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.WebCameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CPUSpeedTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CPUSpeedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CPUNumberTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CPUNumberLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CPUBrandLabel);
            this.splitContainer1.Panel2.Controls.Add(this.LCDTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CPUBrandTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.LCDSizeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CPUTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CPUTypeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.GPUTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.GPUTypeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.HDDTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.HDDLabel);
            this.splitContainer1.Size = new System.Drawing.Size(340, 343);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(237, 7);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModelTextBox.TabIndex = 14;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(195, 10);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 13;
            this.ModelLabel.Text = "Model";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(237, 36);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlatformTextBox.TabIndex = 10;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(186, 39);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(45, 13);
            this.PlatformLabel.TabIndex = 9;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(79, 7);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ManufacturerTextBox.TabIndex = 12;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(3, 10);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.ManufacturerLabel.TabIndex = 11;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(79, 36);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConditionTextBox.TabIndex = 7;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(3, 36);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(51, 13);
            this.ConditionLabel.TabIndex = 3;
            this.ConditionLabel.Text = "Condition";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(71, 241);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(145, 20);
            this.OSTextBox.TabIndex = 60;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(2, 244);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(22, 13);
            this.OSLabel.TabIndex = 59;
            this.OSLabel.Text = "OS";
            // 
            // CamTextBox
            // 
            this.CamTextBox.Location = new System.Drawing.Point(71, 215);
            this.CamTextBox.Name = "CamTextBox";
            this.CamTextBox.ReadOnly = true;
            this.CamTextBox.Size = new System.Drawing.Size(145, 20);
            this.CamTextBox.TabIndex = 56;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(3, 218);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(51, 13);
            this.WebCamLabel.TabIndex = 55;
            this.WebCamLabel.Text = "WebCam";
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(71, 163);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.ReadOnly = true;
            this.SpeedTextBox.Size = new System.Drawing.Size(145, 20);
            this.SpeedTextBox.TabIndex = 58;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(3, 166);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.SpeedLabel.TabIndex = 57;
            this.SpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumTextBox
            // 
            this.CPUNumTextBox.Location = new System.Drawing.Point(71, 137);
            this.CPUNumTextBox.Name = "CPUNumTextBox";
            this.CPUNumTextBox.ReadOnly = true;
            this.CPUNumTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPUNumTextBox.TabIndex = 54;
            // 
            // CPUNumLabel
            // 
            this.CPUNumLabel.AutoSize = true;
            this.CPUNumLabel.Location = new System.Drawing.Point(2, 142);
            this.CPUNumLabel.Name = "CPUNumLabel";
            this.CPUNumLabel.Size = new System.Drawing.Size(69, 13);
            this.CPUNumLabel.TabIndex = 53;
            this.CPUNumLabel.Text = "CPU Number";
            // 
            // HardDriveTextBox
            // 
            this.HardDriveTextBox.Location = new System.Drawing.Point(71, 189);
            this.HardDriveTextBox.Name = "HardDriveTextBox";
            this.HardDriveTextBox.ReadOnly = true;
            this.HardDriveTextBox.Size = new System.Drawing.Size(145, 20);
            this.HardDriveTextBox.TabIndex = 52;
            // 
            // HardDriveLabel
            // 
            this.HardDriveLabel.AutoSize = true;
            this.HardDriveLabel.Location = new System.Drawing.Point(3, 192);
            this.HardDriveLabel.Name = "HardDriveLabel";
            this.HardDriveLabel.Size = new System.Drawing.Size(31, 13);
            this.HardDriveLabel.TabIndex = 51;
            this.HardDriveLabel.Text = "HDD";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(71, 7);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(145, 20);
            this.MemoryTextBox.TabIndex = 34;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(2, 10);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(44, 13);
            this.MemoryLabel.TabIndex = 33;
            this.MemoryLabel.Text = "Memory";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Location = new System.Drawing.Point(416, 124);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.Size = new System.Drawing.Size(145, 20);
            this.WebCamTextBox.TabIndex = 48;
            // 
            // WebCameLabel
            // 
            this.WebCameLabel.AutoSize = true;
            this.WebCameLabel.Location = new System.Drawing.Point(356, 127);
            this.WebCameLabel.Name = "WebCameLabel";
            this.WebCameLabel.Size = new System.Drawing.Size(51, 13);
            this.WebCameLabel.TabIndex = 47;
            this.WebCameLabel.Text = "WebCam";
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(416, 58);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPUSpeedTextBox.TabIndex = 50;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(344, 61);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.CPUSpeedLabel.TabIndex = 49;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Location = new System.Drawing.Point(416, 25);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPUNumberTextBox.TabIndex = 46;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(338, 28);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.CPUNumberLabel.TabIndex = 45;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(2, 36);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(60, 13);
            this.CPUBrandLabel.TabIndex = 35;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // LCDTextBox
            // 
            this.LCDTextBox.Location = new System.Drawing.Point(71, 85);
            this.LCDTextBox.Name = "LCDTextBox";
            this.LCDTextBox.ReadOnly = true;
            this.LCDTextBox.Size = new System.Drawing.Size(145, 20);
            this.LCDTextBox.TabIndex = 44;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Location = new System.Drawing.Point(71, 33);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPUBrandTextBox.TabIndex = 36;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(3, 88);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(51, 13);
            this.LCDSizeLabel.TabIndex = 43;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // CPUTextBox
            // 
            this.CPUTextBox.Location = new System.Drawing.Point(71, 59);
            this.CPUTextBox.Name = "CPUTextBox";
            this.CPUTextBox.ReadOnly = true;
            this.CPUTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPUTextBox.TabIndex = 38;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(2, 59);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.CPUTypeLabel.TabIndex = 37;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // GPUTextBox
            // 
            this.GPUTextBox.Location = new System.Drawing.Point(71, 111);
            this.GPUTextBox.Name = "GPUTextBox";
            this.GPUTextBox.ReadOnly = true;
            this.GPUTextBox.Size = new System.Drawing.Size(145, 20);
            this.GPUTextBox.TabIndex = 42;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(3, 114);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.GPUTypeLabel.TabIndex = 41;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Location = new System.Drawing.Point(416, 91);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(145, 20);
            this.HDDTextBox.TabIndex = 40;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(376, 94);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(31, 13);
            this.HDDLabel.TabIndex = 39;
            this.HDDLabel.Text = "HDD";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 422);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ComputerPictureBox);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.PictureBox ComputerPictureBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.Label WebCameLabel;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.TextBox LCDTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.TextBox CPUTextBox;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.TextBox GPUTextBox;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CamTextBox;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TextBox CPUNumTextBox;
        private System.Windows.Forms.Label CPUNumLabel;
        private System.Windows.Forms.TextBox HardDriveTextBox;
        private System.Windows.Forms.Label HardDriveLabel;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
    }
}