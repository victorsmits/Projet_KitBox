namespace KitBoxApplication
{
    partial class CartPage
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clientIdentifier1 = new KitBoxApplication.ClientIdentifier();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.comfirmCartButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPage1.Controls.Add(this.clientIdentifier1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(2820, 1280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empty";
            // 
            // clientIdentifier1
            // 
            this.clientIdentifier1.Location = new System.Drawing.Point(891, 416);
            this.clientIdentifier1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.clientIdentifier1.Name = "clientIdentifier1";
            this.clientIdentifier1.Size = new System.Drawing.Size(1350, 600);
            this.clientIdentifier1.TabIndex = 0;
            this.clientIdentifier1.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(8, 93);
            this.tabControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2840, 1338);
            this.tabControl.TabIndex = 0;
            // 
            // comfirmCartButton
            // 
            this.comfirmCartButton.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirmCartButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comfirmCartButton.Location = new System.Drawing.Point(2888, 1300);
            this.comfirmCartButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comfirmCartButton.Name = "comfirmCartButton";
            this.comfirmCartButton.Size = new System.Drawing.Size(245, 126);
            this.comfirmCartButton.TabIndex = 1;
            this.comfirmCartButton.Text = "Confirm cart";
            this.comfirmCartButton.UseVisualStyleBackColor = true;
            this.comfirmCartButton.Visible = false;
            this.comfirmCartButton.Click += new System.EventHandler(this.ConfirmCartButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.totalLabel.Location = new System.Drawing.Point(2891, 145);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(133, 47);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total :";
            this.totalLabel.Visible = false;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.costLabel.Location = new System.Drawing.Point(2907, 203);
            this.costLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 32);
            this.costLabel.TabIndex = 4;
            this.costLabel.Visible = false;
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.comfirmCartButton);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CartPage";
            this.Size = new System.Drawing.Size(3133, 1433);
            this.tabPage1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button comfirmCartButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label costLabel;
        private ClientIdentifier clientIdentifier1;
    }
}
