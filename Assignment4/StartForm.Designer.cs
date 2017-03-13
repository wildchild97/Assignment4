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
            this.newOrderButton = new System.Windows.Forms.Button();
            this.loadOrder = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dollarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dollarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(22, 168);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(103, 21);
            this.newOrderButton.TabIndex = 0;
            this.newOrderButton.Text = "Start New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            // 
            // loadOrder
            // 
            this.loadOrder.Location = new System.Drawing.Point(22, 197);
            this.loadOrder.Name = "loadOrder";
            this.loadOrder.Size = new System.Drawing.Size(103, 23);
            this.loadOrder.TabIndex = 1;
            this.loadOrder.Text = "Load Saved Order";
            this.loadOrder.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(22, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // dollarPictureBox
            // 
            this.dollarPictureBox.Image = global::Assignment4.Properties.Resources.dollar_sign;
            this.dollarPictureBox.Location = new System.Drawing.Point(12, 12);
            this.dollarPictureBox.Name = "dollarPictureBox";
            this.dollarPictureBox.Size = new System.Drawing.Size(125, 150);
            this.dollarPictureBox.TabIndex = 3;
            this.dollarPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 261);
            this.ControlBox = false;
            this.Controls.Add(this.dollarPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadOrder);
            this.Controls.Add(this.newOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            ((System.ComponentModel.ISupportInitialize)(this.dollarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button loadOrder;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox dollarPictureBox;
    }
}

