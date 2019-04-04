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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.comfirmCartButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.clientIdentifier1 = new KitBoxApplication.ClientIdentifier();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(1072, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empty";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // comfirmCartButton
            // 
            this.comfirmCartButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comfirmCartButton.Location = new System.Drawing.Point(1083, 545);
            this.comfirmCartButton.Name = "comfirmCartButton";
            this.comfirmCartButton.Size = new System.Drawing.Size(92, 53);
            this.comfirmCartButton.TabIndex = 1;
            this.comfirmCartButton.Text = "Comfirm cart";
            this.comfirmCartButton.UseVisualStyleBackColor = true;
            this.comfirmCartButton.Visible = false;
            this.comfirmCartButton.Click += new System.EventHandler(this.comfirmCartButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.totalLabel.Location = new System.Drawing.Point(1084, 61);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(59, 20);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total :";
            this.totalLabel.Visible = false;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.costLabel.Location = new System.Drawing.Point(1090, 85);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Visible = false;
            // 
            // clientIdentifier1
            // 
            this.clientIdentifier1.Location = new System.Drawing.Point(386, 222);
            this.clientIdentifier1.Name = "clientIdentifier1";
            this.clientIdentifier1.Size = new System.Drawing.Size(354, 147);
            this.clientIdentifier1.TabIndex = 0;
            this.clientIdentifier1.Visible = false;
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientIdentifier1);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.comfirmCartButton);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CartPage";
            this.Size = new System.Drawing.Size(1175, 601);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button comfirmCartButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label costLabel;
        private ClientIdentifier clientIdentifier1;
    }
}
