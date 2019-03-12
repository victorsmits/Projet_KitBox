namespace interface_Magasinier
{
    partial class ProductWizard
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
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.SupplierBox = new System.Windows.Forms.TextBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.supplierPriceLabel = new System.Windows.Forms.Label();
            this.SupplierChoice = new System.Windows.Forms.Label();
            this.delayNum = new System.Windows.Forms.NumericUpDown();
            this.supplierPriceTextBox = new System.Windows.Forms.TextBox();
            this.delayOrderLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.referenceLabel = new System.Windows.Forms.Label();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.InitialStockNum = new System.Windows.Forms.NumericUpDown();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.ClientPrice = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.clientPriceTextBox = new System.Windows.Forms.TextBox();
            this.HeigthTextBox = new System.Windows.Forms.TextBox();
            this.minimumStockLabel = new System.Windows.Forms.Label();
            this.divisionTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DimensionsTextBox = new System.Windows.Forms.TextBox();
            this.DimensionLabel = new System.Windows.Forms.Label();
            this.numberPerBoxNum = new System.Windows.Forms.NumericUpDown();
            this.divisionLabel = new System.Windows.Forms.Label();
            this.MinimumStockNum = new System.Windows.Forms.NumericUpDown();
            this.depthLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.productGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialStockNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPerBoxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumStockNum)).BeginInit();
            this.SuspendLayout();
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.SupplierBox);
            this.productGroupBox.Controls.Add(this.finishButton);
            this.productGroupBox.Controls.Add(this.supplierPriceLabel);
            this.productGroupBox.Controls.Add(this.SupplierChoice);
            this.productGroupBox.Controls.Add(this.delayNum);
            this.productGroupBox.Controls.Add(this.supplierPriceTextBox);
            this.productGroupBox.Controls.Add(this.delayOrderLabel);
            this.productGroupBox.Controls.Add(this.heightLabel);
            this.productGroupBox.Controls.Add(this.referenceLabel);
            this.productGroupBox.Controls.Add(this.referenceTextBox);
            this.productGroupBox.Controls.Add(this.colorTextBox);
            this.productGroupBox.Controls.Add(this.stockLabel);
            this.productGroupBox.Controls.Add(this.codeTextBox);
            this.productGroupBox.Controls.Add(this.InitialStockNum);
            this.productGroupBox.Controls.Add(this.widthTextBox);
            this.productGroupBox.Controls.Add(this.ClientPrice);
            this.productGroupBox.Controls.Add(this.depthTextBox);
            this.productGroupBox.Controls.Add(this.clientPriceTextBox);
            this.productGroupBox.Controls.Add(this.HeigthTextBox);
            this.productGroupBox.Controls.Add(this.minimumStockLabel);
            this.productGroupBox.Controls.Add(this.divisionTextBox);
            this.productGroupBox.Controls.Add(this.label12);
            this.productGroupBox.Controls.Add(this.DimensionsTextBox);
            this.productGroupBox.Controls.Add(this.DimensionLabel);
            this.productGroupBox.Controls.Add(this.numberPerBoxNum);
            this.productGroupBox.Controls.Add(this.divisionLabel);
            this.productGroupBox.Controls.Add(this.MinimumStockNum);
            this.productGroupBox.Controls.Add(this.depthLabel);
            this.productGroupBox.Controls.Add(this.colorLabel);
            this.productGroupBox.Controls.Add(this.widthLabel);
            this.productGroupBox.Controls.Add(this.codeLabel);
            this.productGroupBox.Location = new System.Drawing.Point(3, 3);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(407, 531);
            this.productGroupBox.TabIndex = 32;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product";
            // 
            // SupplierBox
            // 
            this.SupplierBox.Location = new System.Drawing.Point(114, 395);
            this.SupplierBox.Name = "SupplierBox";
            this.SupplierBox.Size = new System.Drawing.Size(100, 20);
            this.SupplierBox.TabIndex = 39;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(17, 495);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 38;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // supplierPriceLabel
            // 
            this.supplierPriceLabel.AutoSize = true;
            this.supplierPriceLabel.Location = new System.Drawing.Point(7, 425);
            this.supplierPriceLabel.Name = "supplierPriceLabel";
            this.supplierPriceLabel.Size = new System.Drawing.Size(77, 13);
            this.supplierPriceLabel.TabIndex = 34;
            this.supplierPriceLabel.Text = "Supplier price :";
            // 
            // SupplierChoice
            // 
            this.SupplierChoice.AutoSize = true;
            this.SupplierChoice.Location = new System.Drawing.Point(7, 398);
            this.SupplierChoice.Name = "SupplierChoice";
            this.SupplierChoice.Size = new System.Drawing.Size(101, 13);
            this.SupplierChoice.TabIndex = 32;
            this.SupplierChoice.Text = "From what supplier :";
            // 
            // delayNum
            // 
            this.delayNum.Location = new System.Drawing.Point(114, 454);
            this.delayNum.Name = "delayNum";
            this.delayNum.Size = new System.Drawing.Size(65, 20);
            this.delayNum.TabIndex = 37;
            // 
            // supplierPriceTextBox
            // 
            this.supplierPriceTextBox.Location = new System.Drawing.Point(114, 425);
            this.supplierPriceTextBox.Name = "supplierPriceTextBox";
            this.supplierPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplierPriceTextBox.TabIndex = 36;
            // 
            // delayOrderLabel
            // 
            this.delayOrderLabel.AutoSize = true;
            this.delayOrderLabel.Location = new System.Drawing.Point(6, 456);
            this.delayOrderLabel.Name = "delayOrderLabel";
            this.delayOrderLabel.Size = new System.Drawing.Size(97, 13);
            this.delayOrderLabel.TabIndex = 35;
            this.delayOrderLabel.Text = "Delay of the order :";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(7, 244);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(44, 13);
            this.heightLabel.TabIndex = 15;
            this.heightLabel.Text = "Height :";
            // 
            // referenceLabel
            // 
            this.referenceLabel.AutoSize = true;
            this.referenceLabel.Location = new System.Drawing.Point(10, 31);
            this.referenceLabel.Name = "referenceLabel";
            this.referenceLabel.Size = new System.Drawing.Size(63, 13);
            this.referenceLabel.TabIndex = 5;
            this.referenceLabel.Text = "Reference :";
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Location = new System.Drawing.Point(101, 28);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.referenceTextBox.TabIndex = 6;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(101, 362);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 28;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(10, 61);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(66, 13);
            this.stockLabel.TabIndex = 7;
            this.stockLabel.Text = "Initial stock :";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(101, 331);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 27;
            // 
            // InitialStockNum
            // 
            this.InitialStockNum.Location = new System.Drawing.Point(101, 59);
            this.InitialStockNum.Name = "InitialStockNum";
            this.InitialStockNum.Size = new System.Drawing.Size(58, 20);
            this.InitialStockNum.TabIndex = 7;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(101, 301);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 26;
            // 
            // ClientPrice
            // 
            this.ClientPrice.AutoSize = true;
            this.ClientPrice.Location = new System.Drawing.Point(10, 120);
            this.ClientPrice.Name = "ClientPrice";
            this.ClientPrice.Size = new System.Drawing.Size(65, 13);
            this.ClientPrice.TabIndex = 9;
            this.ClientPrice.Text = "Client price :";
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(101, 272);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(100, 20);
            this.depthTextBox.TabIndex = 25;
            // 
            // clientPriceTextBox
            // 
            this.clientPriceTextBox.Location = new System.Drawing.Point(101, 117);
            this.clientPriceTextBox.Name = "clientPriceTextBox";
            this.clientPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientPriceTextBox.TabIndex = 9;
            // 
            // HeigthTextBox
            // 
            this.HeigthTextBox.Location = new System.Drawing.Point(101, 241);
            this.HeigthTextBox.Name = "HeigthTextBox";
            this.HeigthTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeigthTextBox.TabIndex = 24;
            // 
            // minimumStockLabel
            // 
            this.minimumStockLabel.AutoSize = true;
            this.minimumStockLabel.Location = new System.Drawing.Point(10, 90);
            this.minimumStockLabel.Name = "minimumStockLabel";
            this.minimumStockLabel.Size = new System.Drawing.Size(85, 13);
            this.minimumStockLabel.TabIndex = 11;
            this.minimumStockLabel.Text = "Minimum Stock :";
            // 
            // divisionTextBox
            // 
            this.divisionTextBox.Location = new System.Drawing.Point(101, 211);
            this.divisionTextBox.Name = "divisionTextBox";
            this.divisionTextBox.Size = new System.Drawing.Size(100, 20);
            this.divisionTextBox.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Number needed for one box :";
            // 
            // DimensionsTextBox
            // 
            this.DimensionsTextBox.Location = new System.Drawing.Point(101, 180);
            this.DimensionsTextBox.Name = "DimensionsTextBox";
            this.DimensionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.DimensionsTextBox.TabIndex = 22;
            // 
            // DimensionLabel
            // 
            this.DimensionLabel.AutoSize = true;
            this.DimensionLabel.Location = new System.Drawing.Point(7, 183);
            this.DimensionLabel.Name = "DimensionLabel";
            this.DimensionLabel.Size = new System.Drawing.Size(67, 13);
            this.DimensionLabel.TabIndex = 13;
            this.DimensionLabel.Text = "Dimensions :";
            // 
            // numberPerBoxNum
            // 
            this.numberPerBoxNum.Location = new System.Drawing.Point(161, 147);
            this.numberPerBoxNum.Name = "numberPerBoxNum";
            this.numberPerBoxNum.Size = new System.Drawing.Size(58, 20);
            this.numberPerBoxNum.TabIndex = 10;
            // 
            // divisionLabel
            // 
            this.divisionLabel.AutoSize = true;
            this.divisionLabel.Location = new System.Drawing.Point(7, 214);
            this.divisionLabel.Name = "divisionLabel";
            this.divisionLabel.Size = new System.Drawing.Size(53, 13);
            this.divisionLabel.TabIndex = 14;
            this.divisionLabel.Text = "Division : ";
            // 
            // MinimumStockNum
            // 
            this.MinimumStockNum.Location = new System.Drawing.Point(101, 85);
            this.MinimumStockNum.Name = "MinimumStockNum";
            this.MinimumStockNum.Size = new System.Drawing.Size(58, 20);
            this.MinimumStockNum.TabIndex = 8;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(7, 275);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(42, 13);
            this.depthLabel.TabIndex = 16;
            this.depthLabel.Text = "Depth :";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(7, 365);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(37, 13);
            this.colorLabel.TabIndex = 19;
            this.colorLabel.Text = "Color :";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(7, 304);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(41, 13);
            this.widthLabel.TabIndex = 17;
            this.widthLabel.Text = "Width :";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(7, 334);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(38, 13);
            this.codeLabel.TabIndex = 18;
            this.codeLabel.Text = "Code :";
            // 
            // ProductWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productGroupBox);
            this.Name = "ProductWizard";
            this.Size = new System.Drawing.Size(449, 633);
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialStockNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPerBoxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumStockNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label referenceLabel;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.NumericUpDown InitialStockNum;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label ClientPrice;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.TextBox clientPriceTextBox;
        private System.Windows.Forms.TextBox HeigthTextBox;
        private System.Windows.Forms.Label minimumStockLabel;
        private System.Windows.Forms.TextBox divisionTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DimensionsTextBox;
        private System.Windows.Forms.Label DimensionLabel;
        private System.Windows.Forms.NumericUpDown numberPerBoxNum;
        private System.Windows.Forms.Label divisionLabel;
        private System.Windows.Forms.NumericUpDown MinimumStockNum;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label supplierPriceLabel;
        private System.Windows.Forms.Label SupplierChoice;
        private System.Windows.Forms.NumericUpDown delayNum;
        private System.Windows.Forms.TextBox supplierPriceTextBox;
        private System.Windows.Forms.Label delayOrderLabel;
        private System.Windows.Forms.TextBox SupplierBox;
    }
}
