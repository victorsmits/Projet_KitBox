namespace KitBoxApplication
{
    partial class ClientIdentifier
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.confirmClientButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmClientButton
            // 
            this.confirmClientButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.confirmClientButton.Location = new System.Drawing.Point(93, 108);
            this.confirmClientButton.Name = "confirmClientButton";
            this.confirmClientButton.Size = new System.Drawing.Size(75, 23);
            this.confirmClientButton.TabIndex = 0;
            this.confirmClientButton.Text = "Confirm";
            this.confirmClientButton.UseVisualStyleBackColor = true;
            this.confirmClientButton.Click += new System.EventHandler(this.comfirmClientButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cancelButton.Location = new System.Drawing.Point(175, 108);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.checkBox1.Location = new System.Drawing.Point(97, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Subscribe to the newletter";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 3;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mailLabel.Location = new System.Drawing.Point(55, 62);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(32, 13);
            this.mailLabel.TabIndex = 4;
            this.mailLabel.Text = "Mail :";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.instructionLabel.Location = new System.Drawing.Point(4, 6);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(336, 24);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = "Enter your mail to confirm your cart";
            // 
            // ClientIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmClientButton);
            this.Name = "ClientIdentifier";
            this.Size = new System.Drawing.Size(352, 144);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmClientButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label instructionLabel;
    }
}
