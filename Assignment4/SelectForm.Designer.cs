namespace Assignment4
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dollarComputersDataGridView = new System.Windows.Forms.DataGridView();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.hardwareTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dollar Computers Hardware List";
            // 
            // dollarComputersDataGridView
            // 
            this.dollarComputersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dollarComputersDataGridView.Location = new System.Drawing.Point(6, 40);
            this.dollarComputersDataGridView.Name = "dollarComputersDataGridView";
            this.dollarComputersDataGridView.ReadOnly = true;
            this.dollarComputersDataGridView.Size = new System.Drawing.Size(617, 265);
            this.dollarComputersDataGridView.TabIndex = 1;
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(3, 314);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(79, 13);
            this.selectionLabel.TabIndex = 2;
            this.selectionLabel.Text = "Your Selection:";
            this.selectionLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // hardwareTextBox
            // 
            this.hardwareTextBox.Location = new System.Drawing.Point(88, 311);
            this.hardwareTextBox.Name = "hardwareTextBox";
            this.hardwareTextBox.ReadOnly = true;
            this.hardwareTextBox.Size = new System.Drawing.Size(324, 20);
            this.hardwareTextBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(452, 311);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(536, 311);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 337);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.hardwareTextBox);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.dollarComputersDataGridView);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Form";
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dollarComputersDataGridView;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.TextBox hardwareTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
    }
}