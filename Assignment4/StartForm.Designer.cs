namespace Assignment4
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.LoadOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DollarPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenOrderFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DollarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(22, 168);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(103, 21);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "Start New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this._newOrderButton_Click);
            // 
            // LoadOrderButton
            // 
            this.LoadOrderButton.Location = new System.Drawing.Point(22, 197);
            this.LoadOrderButton.Name = "LoadOrderButton";
            this.LoadOrderButton.Size = new System.Drawing.Size(103, 23);
            this.LoadOrderButton.TabIndex = 1;
            this.LoadOrderButton.Text = "Load Saved Order";
            this.LoadOrderButton.UseVisualStyleBackColor = true;
            this.LoadOrderButton.Click += new System.EventHandler(this._loadOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(22, 226);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(103, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit Program";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DollarPictureBox
            // 
            this.DollarPictureBox.Image = global::Assignment4.Properties.Resources.dollar_sign;
            this.DollarPictureBox.Location = new System.Drawing.Point(12, 12);
            this.DollarPictureBox.Name = "DollarPictureBox";
            this.DollarPictureBox.Size = new System.Drawing.Size(125, 150);
            this.DollarPictureBox.TabIndex = 3;
            this.DollarPictureBox.TabStop = false;
            // 
            // OpenOrderFileDialog
            // 
            this.OpenOrderFileDialog.FileName = "OpenOrderFileDialog";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 261);
            this.ControlBox = false;
            this.Controls.Add(this.DollarPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            ((System.ComponentModel.ISupportInitialize)(this.DollarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button LoadOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox DollarPictureBox;
        private System.Windows.Forms.OpenFileDialog OpenOrderFileDialog;
    }
}

