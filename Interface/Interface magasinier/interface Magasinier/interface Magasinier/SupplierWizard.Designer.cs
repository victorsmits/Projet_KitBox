namespace interface_Magasinier
{
    partial class SupplierWizard
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
            this.supplierGroupBox = new System.Windows.Forms.GroupBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.supplierPriceLabel = new System.Windows.Forms.Label();
            this.SupplierChoice = new System.Windows.Forms.Label();
            this.delayNum = new System.Windows.Forms.NumericUpDown();
            this.SupplierList = new System.Windows.Forms.ComboBox();
            this.supplierPriceTextBox = new System.Windows.Forms.TextBox();
            this.delayOrderLabel = new System.Windows.Forms.Label();
            this.supplierGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierGroupBox
            // 
            this.supplierGroupBox.Controls.Add(this.finishButton);
            this.supplierGroupBox.Controls.Add(this.supplierPriceLabel);
            this.supplierGroupBox.Controls.Add(this.SupplierChoice);
            this.supplierGroupBox.Controls.Add(this.delayNum);
            this.supplierGroupBox.Controls.Add(this.SupplierList);
            this.supplierGroupBox.Controls.Add(this.supplierPriceTextBox);
            this.supplierGroupBox.Controls.Add(this.delayOrderLabel);
            this.supplierGroupBox.Location = new System.Drawing.Point(3, 3);
            this.supplierGroupBox.Name = "supplierGroupBox";
            this.supplierGroupBox.Size = new System.Drawing.Size(312, 167);
            this.supplierGroupBox.TabIndex = 33;
            this.supplierGroupBox.TabStop = false;
            this.supplierGroupBox.Text = "Supplier";
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(16, 130);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 31;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // supplierPriceLabel
            // 
            this.supplierPriceLabel.AutoSize = true;
            this.supplierPriceLabel.Location = new System.Drawing.Point(6, 67);
            this.supplierPriceLabel.Name = "supplierPriceLabel";
            this.supplierPriceLabel.Size = new System.Drawing.Size(77, 13);
            this.supplierPriceLabel.TabIndex = 3;
            this.supplierPriceLabel.Text = "Supplier price :";
            // 
            // SupplierChoice
            // 
            this.SupplierChoice.AutoSize = true;
            this.SupplierChoice.Location = new System.Drawing.Point(6, 38);
            this.SupplierChoice.Name = "SupplierChoice";
            this.SupplierChoice.Size = new System.Drawing.Size(101, 13);
            this.SupplierChoice.TabIndex = 1;
            this.SupplierChoice.Text = "From what supplier :";
            // 
            // delayNum
            // 
            this.delayNum.Location = new System.Drawing.Point(113, 96);
            this.delayNum.Name = "delayNum";
            this.delayNum.Size = new System.Drawing.Size(65, 20);
            this.delayNum.TabIndex = 30;
            // 
            // SupplierList
            // 
            this.SupplierList.FormattingEnabled = true;
            this.SupplierList.Items.AddRange(new object[] {
            "test1",
            "test2"});
            this.SupplierList.Location = new System.Drawing.Point(113, 35);
            this.SupplierList.Name = "SupplierList";
            this.SupplierList.Size = new System.Drawing.Size(121, 21);
            this.SupplierList.TabIndex = 2;
            // 
            // supplierPriceTextBox
            // 
            this.supplierPriceTextBox.Location = new System.Drawing.Point(113, 65);
            this.supplierPriceTextBox.Name = "supplierPriceTextBox";
            this.supplierPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplierPriceTextBox.TabIndex = 29;
            // 
            // delayOrderLabel
            // 
            this.delayOrderLabel.AutoSize = true;
            this.delayOrderLabel.Location = new System.Drawing.Point(6, 96);
            this.delayOrderLabel.Name = "delayOrderLabel";
            this.delayOrderLabel.Size = new System.Drawing.Size(97, 13);
            this.delayOrderLabel.TabIndex = 4;
            this.delayOrderLabel.Text = "Delay of the order :";
            // 
            // SupplierWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.supplierGroupBox);
            this.Name = "SupplierWizard";
            this.Size = new System.Drawing.Size(324, 183);
            this.supplierGroupBox.ResumeLayout(false);
            this.supplierGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox supplierGroupBox;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label supplierPriceLabel;
        private System.Windows.Forms.Label SupplierChoice;
        private System.Windows.Forms.NumericUpDown delayNum;
        private System.Windows.Forms.ComboBox SupplierList;
        private System.Windows.Forms.TextBox supplierPriceTextBox;
        private System.Windows.Forms.Label delayOrderLabel;
    }
}
