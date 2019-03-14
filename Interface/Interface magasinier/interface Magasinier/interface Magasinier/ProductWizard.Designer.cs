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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ReferenceSupplier = new System.Windows.Forms.ListBox();
            this.IdSupplier = new System.Windows.Forms.ListBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RefLabel = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.productGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialStockNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPerBoxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumStockNum)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.panel2);
            this.productGroupBox.Controls.Add(this.panel1);
            this.productGroupBox.Location = new System.Drawing.Point(4, 4);
            this.productGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productGroupBox.Size = new System.Drawing.Size(742, 654);
            this.productGroupBox.TabIndex = 32;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.ReferenceSupplier);
            this.panel1.Controls.Add(this.IdSupplier);
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RefLabel);
            this.panel1.Location = new System.Drawing.Point(371, 410);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 220);
            this.panel1.TabIndex = 40;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(105, 182);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(148, 28);
            this.RefreshButton.TabIndex = 38;
            this.RefreshButton.Text = "Refresh the list";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ReferenceSupplier
            // 
            this.ReferenceSupplier.FormattingEnabled = true;
            this.ReferenceSupplier.ItemHeight = 16;
            this.ReferenceSupplier.Location = new System.Drawing.Point(188, 58);
            this.ReferenceSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReferenceSupplier.Name = "ReferenceSupplier";
            this.ReferenceSupplier.Size = new System.Drawing.Size(159, 116);
            this.ReferenceSupplier.TabIndex = 33;
            this.ReferenceSupplier.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // IdSupplier
            // 
            this.IdSupplier.FormattingEnabled = true;
            this.IdSupplier.ItemHeight = 16;
            this.IdSupplier.Location = new System.Drawing.Point(20, 58);
            this.IdSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdSupplier.Name = "IdSupplier";
            this.IdSupplier.Size = new System.Drawing.Size(159, 116);
            this.IdSupplier.TabIndex = 34;
            this.IdSupplier.Click += new System.EventHandler(this.listBox2_Click);
            this.IdSupplier.SelectedIndexChanged += new System.EventHandler(this.listBox2_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(33, 38);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 17);
            this.IdLabel.TabIndex = 35;
            this.IdLabel.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Pick up the supplier in the  list bellow";
            // 
            // RefLabel
            // 
            this.RefLabel.AutoSize = true;
            this.RefLabel.Location = new System.Drawing.Point(219, 38);
            this.RefLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RefLabel.Name = "RefLabel";
            this.RefLabel.Size = new System.Drawing.Size(74, 17);
            this.RefLabel.TabIndex = 36;
            this.RefLabel.Text = "Reference";
            // 
            // SupplierBox
            // 
            this.SupplierBox.Location = new System.Drawing.Point(166, 463);
            this.SupplierBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SupplierBox.Name = "SupplierBox";
            this.SupplierBox.Size = new System.Drawing.Size(132, 22);
            this.SupplierBox.TabIndex = 39;
            this.SupplierBox.Click += new System.EventHandler(this.listBox2_Click);
            this.SupplierBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // finishButton
            // 
            this.finishButton.Enabled = false;
            this.finishButton.Location = new System.Drawing.Point(37, 586);
            this.finishButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(100, 28);
            this.finishButton.TabIndex = 38;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // supplierPriceLabel
            // 
            this.supplierPriceLabel.AutoSize = true;
            this.supplierPriceLabel.Location = new System.Drawing.Point(23, 500);
            this.supplierPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplierPriceLabel.Name = "supplierPriceLabel";
            this.supplierPriceLabel.Size = new System.Drawing.Size(103, 17);
            this.supplierPriceLabel.TabIndex = 34;
            this.supplierPriceLabel.Text = "Supplier price :";
            // 
            // SupplierChoice
            // 
            this.SupplierChoice.AutoSize = true;
            this.SupplierChoice.Location = new System.Drawing.Point(23, 467);
            this.SupplierChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierChoice.Name = "SupplierChoice";
            this.SupplierChoice.Size = new System.Drawing.Size(135, 17);
            this.SupplierChoice.TabIndex = 32;
            this.SupplierChoice.Text = "From what supplier :";
            // 
            // delayNum
            // 
            this.delayNum.Location = new System.Drawing.Point(166, 536);
            this.delayNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delayNum.Name = "delayNum";
            this.delayNum.Size = new System.Drawing.Size(87, 22);
            this.delayNum.TabIndex = 37;
            this.delayNum.ValueChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // supplierPriceTextBox
            // 
            this.supplierPriceTextBox.Location = new System.Drawing.Point(166, 500);
            this.supplierPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierPriceTextBox.Name = "supplierPriceTextBox";
            this.supplierPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.supplierPriceTextBox.TabIndex = 36;
            this.supplierPriceTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // delayOrderLabel
            // 
            this.delayOrderLabel.AutoSize = true;
            this.delayOrderLabel.Location = new System.Drawing.Point(22, 538);
            this.delayOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delayOrderLabel.Name = "delayOrderLabel";
            this.delayOrderLabel.Size = new System.Drawing.Size(130, 17);
            this.delayOrderLabel.TabIndex = 35;
            this.delayOrderLabel.Text = "Delay of the order :";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(23, 277);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(57, 17);
            this.heightLabel.TabIndex = 15;
            this.heightLabel.Text = "Height :";
            // 
            // referenceLabel
            // 
            this.referenceLabel.AutoSize = true;
            this.referenceLabel.Location = new System.Drawing.Point(27, 15);
            this.referenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.referenceLabel.Name = "referenceLabel";
            this.referenceLabel.Size = new System.Drawing.Size(82, 17);
            this.referenceLabel.TabIndex = 5;
            this.referenceLabel.Text = "Reference :";
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Location = new System.Drawing.Point(149, 11);
            this.referenceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(132, 22);
            this.referenceTextBox.TabIndex = 6;
            this.referenceTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(149, 423);
            this.colorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(132, 22);
            this.colorTextBox.TabIndex = 28;
            this.colorTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(27, 52);
            this.stockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(85, 17);
            this.stockLabel.TabIndex = 7;
            this.stockLabel.Text = "Initial stock :";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(149, 384);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(132, 22);
            this.codeTextBox.TabIndex = 27;
            this.codeTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // InitialStockNum
            // 
            this.InitialStockNum.Location = new System.Drawing.Point(149, 50);
            this.InitialStockNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InitialStockNum.Name = "InitialStockNum";
            this.InitialStockNum.Size = new System.Drawing.Size(77, 22);
            this.InitialStockNum.TabIndex = 7;
            this.InitialStockNum.ValueChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(149, 347);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(132, 22);
            this.widthTextBox.TabIndex = 26;
            this.widthTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // ClientPrice
            // 
            this.ClientPrice.AutoSize = true;
            this.ClientPrice.Location = new System.Drawing.Point(27, 125);
            this.ClientPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientPrice.Name = "ClientPrice";
            this.ClientPrice.Size = new System.Drawing.Size(86, 17);
            this.ClientPrice.TabIndex = 9;
            this.ClientPrice.Text = "Client price :";
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(149, 312);
            this.depthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(132, 22);
            this.depthTextBox.TabIndex = 25;
            this.depthTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // clientPriceTextBox
            // 
            this.clientPriceTextBox.Location = new System.Drawing.Point(149, 121);
            this.clientPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientPriceTextBox.Name = "clientPriceTextBox";
            this.clientPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.clientPriceTextBox.TabIndex = 9;
            this.clientPriceTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // HeigthTextBox
            // 
            this.HeigthTextBox.Location = new System.Drawing.Point(149, 274);
            this.HeigthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeigthTextBox.Name = "HeigthTextBox";
            this.HeigthTextBox.Size = new System.Drawing.Size(132, 22);
            this.HeigthTextBox.TabIndex = 24;
            this.HeigthTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // minimumStockLabel
            // 
            this.minimumStockLabel.AutoSize = true;
            this.minimumStockLabel.Location = new System.Drawing.Point(27, 88);
            this.minimumStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimumStockLabel.Name = "minimumStockLabel";
            this.minimumStockLabel.Size = new System.Drawing.Size(110, 17);
            this.minimumStockLabel.TabIndex = 11;
            this.minimumStockLabel.Text = "Minimum Stock :";
            // 
            // divisionTextBox
            // 
            this.divisionTextBox.Location = new System.Drawing.Point(149, 237);
            this.divisionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.divisionTextBox.Name = "divisionTextBox";
            this.divisionTextBox.Size = new System.Drawing.Size(132, 22);
            this.divisionTextBox.TabIndex = 23;
            this.divisionTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 160);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Number needed for one box :";
            // 
            // DimensionsTextBox
            // 
            this.DimensionsTextBox.Location = new System.Drawing.Point(149, 199);
            this.DimensionsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DimensionsTextBox.Name = "DimensionsTextBox";
            this.DimensionsTextBox.Size = new System.Drawing.Size(132, 22);
            this.DimensionsTextBox.TabIndex = 22;
            this.DimensionsTextBox.TextChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // DimensionLabel
            // 
            this.DimensionLabel.AutoSize = true;
            this.DimensionLabel.Location = new System.Drawing.Point(23, 202);
            this.DimensionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DimensionLabel.Name = "DimensionLabel";
            this.DimensionLabel.Size = new System.Drawing.Size(89, 17);
            this.DimensionLabel.TabIndex = 13;
            this.DimensionLabel.Text = "Dimensions :";
            // 
            // numberPerBoxNum
            // 
            this.numberPerBoxNum.Location = new System.Drawing.Point(236, 158);
            this.numberPerBoxNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberPerBoxNum.Name = "numberPerBoxNum";
            this.numberPerBoxNum.Size = new System.Drawing.Size(77, 22);
            this.numberPerBoxNum.TabIndex = 10;
            this.numberPerBoxNum.ValueChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // divisionLabel
            // 
            this.divisionLabel.AutoSize = true;
            this.divisionLabel.Location = new System.Drawing.Point(23, 240);
            this.divisionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.divisionLabel.Name = "divisionLabel";
            this.divisionLabel.Size = new System.Drawing.Size(69, 17);
            this.divisionLabel.TabIndex = 14;
            this.divisionLabel.Text = "Division : ";
            // 
            // MinimumStockNum
            // 
            this.MinimumStockNum.Location = new System.Drawing.Point(149, 82);
            this.MinimumStockNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumStockNum.Name = "MinimumStockNum";
            this.MinimumStockNum.Size = new System.Drawing.Size(77, 22);
            this.MinimumStockNum.TabIndex = 8;
            this.MinimumStockNum.ValueChanged += new System.EventHandler(this.checkingToEnable);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(23, 315);
            this.depthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(54, 17);
            this.depthLabel.TabIndex = 16;
            this.depthLabel.Text = "Depth :";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(23, 426);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(49, 17);
            this.colorLabel.TabIndex = 19;
            this.colorLabel.Text = "Color :";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(23, 351);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(52, 17);
            this.widthLabel.TabIndex = 17;
            this.widthLabel.Text = "Width :";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(23, 388);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(49, 17);
            this.codeLabel.TabIndex = 18;
            this.codeLabel.Text = "Code :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.referenceTextBox);
            this.panel2.Controls.Add(this.codeLabel);
            this.panel2.Controls.Add(this.SupplierBox);
            this.panel2.Controls.Add(this.widthLabel);
            this.panel2.Controls.Add(this.finishButton);
            this.panel2.Controls.Add(this.colorLabel);
            this.panel2.Controls.Add(this.supplierPriceLabel);
            this.panel2.Controls.Add(this.depthLabel);
            this.panel2.Controls.Add(this.SupplierChoice);
            this.panel2.Controls.Add(this.MinimumStockNum);
            this.panel2.Controls.Add(this.delayNum);
            this.panel2.Controls.Add(this.divisionLabel);
            this.panel2.Controls.Add(this.supplierPriceTextBox);
            this.panel2.Controls.Add(this.numberPerBoxNum);
            this.panel2.Controls.Add(this.delayOrderLabel);
            this.panel2.Controls.Add(this.DimensionLabel);
            this.panel2.Controls.Add(this.heightLabel);
            this.panel2.Controls.Add(this.DimensionsTextBox);
            this.panel2.Controls.Add(this.referenceLabel);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.divisionTextBox);
            this.panel2.Controls.Add(this.colorTextBox);
            this.panel2.Controls.Add(this.minimumStockLabel);
            this.panel2.Controls.Add(this.stockLabel);
            this.panel2.Controls.Add(this.HeigthTextBox);
            this.panel2.Controls.Add(this.codeTextBox);
            this.panel2.Controls.Add(this.clientPriceTextBox);
            this.panel2.Controls.Add(this.InitialStockNum);
            this.panel2.Controls.Add(this.depthTextBox);
            this.panel2.Controls.Add(this.widthTextBox);
            this.panel2.Controls.Add(this.ClientPrice);
            this.panel2.Location = new System.Drawing.Point(22, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 621);
            this.panel2.TabIndex = 41;
            // 
            // ProductWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductWizard";
            this.Size = new System.Drawing.Size(785, 673);
            this.Load += new System.EventHandler(this.LoadList);
            this.productGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialStockNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPerBoxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumStockNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label RefLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ListBox IdSupplier;
        private System.Windows.Forms.ListBox ReferenceSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel panel2;
    }
}
