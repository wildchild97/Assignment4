namespace Assignment4
{
    partial class ProductInfoForm
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
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAnotherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.WebCameLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.LCDTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.OpenComputerFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveComputerFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this._openToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this._saveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this._cancel_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAnotherToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // SelectAnotherToolStripMenuItem
            // 
            this.SelectAnotherToolStripMenuItem.Name = "SelectAnotherToolStripMenuItem";
            this.SelectAnotherToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.SelectAnotherToolStripMenuItem.Text = "Se&lect Another Product";
            this.SelectAnotherToolStripMenuItem.Click += new System.EventHandler(this._productButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(14, 40);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(55, 13);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "ProductID";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(84, 37);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductIDTextBox.TabIndex = 2;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(427, 37);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 4;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(384, 40);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(80, 53);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ManufacturerTextBox.TabIndex = 8;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(4, 56);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.ManufacturerLabel.TabIndex = 7;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(80, 19);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlatformTextBox.TabIndex = 6;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(4, 23);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(45, 13);
            this.PlatformLabel.TabIndex = 5;
            this.PlatformLabel.Text = "Platform";
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Location = new System.Drawing.Point(83, 54);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPUBrandTextBox.TabIndex = 16;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(14, 57);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(60, 13);
            this.CPUBrandLabel.TabIndex = 15;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(83, 23);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(145, 20);
            this.MemoryTextBox.TabIndex = 14;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(27, 26);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(44, 13);
            this.MemoryLabel.TabIndex = 13;
            this.MemoryLabel.Text = "Memory";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(282, 52);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(220, 20);
            this.ModelTextBox.TabIndex = 12;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(228, 56);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 11;
            this.ModelLabel.Text = "Model";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(282, 22);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(220, 20);
            this.OSTextBox.TabIndex = 10;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(242, 25);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(22, 13);
            this.OSLabel.TabIndex = 9;
            this.OSLabel.Text = "OS";
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(357, 54);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPUSpeedTextBox.TabIndex = 32;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(285, 57);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.CPUSpeedLabel.TabIndex = 31;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Location = new System.Drawing.Point(357, 120);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.Size = new System.Drawing.Size(145, 20);
            this.WebCamTextBox.TabIndex = 30;
            // 
            // WebCameLabel
            // 
            this.WebCameLabel.AutoSize = true;
            this.WebCameLabel.Location = new System.Drawing.Point(297, 123);
            this.WebCameLabel.Name = "WebCameLabel";
            this.WebCameLabel.Size = new System.Drawing.Size(51, 13);
            this.WebCameLabel.TabIndex = 29;
            this.WebCameLabel.Text = "WebCam";
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Location = new System.Drawing.Point(357, 21);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPUNumberTextBox.TabIndex = 28;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(279, 24);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.CPUNumberLabel.TabIndex = 27;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // LCDTextBox
            // 
            this.LCDTextBox.Location = new System.Drawing.Point(83, 120);
            this.LCDTextBox.Name = "LCDTextBox";
            this.LCDTextBox.Size = new System.Drawing.Size(145, 20);
            this.LCDTextBox.TabIndex = 26;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(23, 123);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(51, 13);
            this.LCDSizeLabel.TabIndex = 25;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Location = new System.Drawing.Point(83, 151);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.Size = new System.Drawing.Size(145, 20);
            this.GPUTypeTextBox.TabIndex = 24;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(20, 154);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.GPUTypeLabel.TabIndex = 23;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Location = new System.Drawing.Point(357, 87);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(145, 20);
            this.HDDTextBox.TabIndex = 22;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(317, 90);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(31, 13);
            this.HDDLabel.TabIndex = 21;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Location = new System.Drawing.Point(83, 87);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPUTypeTextBox.TabIndex = 20;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(21, 90);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.CPUTypeLabel.TabIndex = 19;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(261, 37);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConditionTextBox.TabIndex = 18;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(195, 40);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(51, 13);
            this.ConditionLabel.TabIndex = 17;
            this.ConditionLabel.Text = "Condition";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(13, 67);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(514, 80);
            this.ProductInfoGroupBox.TabIndex = 33;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Information";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Controls.Add(this.WebCamTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.WebCameLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(13, 165);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(514, 184);
            this.TechSpecsGroupBox.TabIndex = 34;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Technical Specifications";
            // 
            // ProductButton
            // 
            this.ProductButton.Location = new System.Drawing.Point(13, 367);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(141, 23);
            this.ProductButton.TabIndex = 35;
            this.ProductButton.Text = "Select Another Product";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this._productButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(258, 367);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 36;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this._cancel_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(452, 367);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 37;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this._nextButton_Click);
            // 
            // OpenComputerFileDialog
            // 
            this.OpenComputerFileDialog.FileName = "OpenComputerFileDialog";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 398);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAnotherToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.Label WebCameLabel;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.TextBox LCDTextBox;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.OpenFileDialog OpenComputerFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveComputerFileDialog;
    }
}