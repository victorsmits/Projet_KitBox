namespace interface_Magasinier
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.stockTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.RefrenceTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.StockList = new System.Windows.Forms.ListBox();
            this.IdList = new System.Windows.Forms.ListBox();
            this.RefrenceList = new System.Windows.Forms.ListBox();
            this.PriceClientList = new System.Windows.Forms.ListBox();
            this.DimensionsList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.RefrenceTextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PriceClientTextBox = new System.Windows.Forms.TextBox();
            this.RefrenceTextBox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.AddingProduct = new System.Windows.Forms.TabPage();
            this.supplierWizard1 = new interface_Magasinier.SupplierWizard();
            this.productWizard1 = new interface_Magasinier.ProductWizard();
            this.label11 = new System.Windows.Forms.Label();
            this.AddingProductLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.command1 = new interface_Magasinier.Command();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clientWizard1 = new interface_Magasinier.ClientWizard();
            this.label15 = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.stockTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.AddingProduct.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.stockTab);
            this.Tabs.Controls.Add(this.AddingProduct);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Location = new System.Drawing.Point(32, 29);
            this.Tabs.Margin = new System.Windows.Forms.Padding(8);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(4000, 1788);
            this.Tabs.TabIndex = 0;
            // 
            // stockTab
            // 
            this.stockTab.Controls.Add(this.panel4);
            this.stockTab.Location = new System.Drawing.Point(10, 48);
            this.stockTab.Margin = new System.Windows.Forms.Padding(8);
            this.stockTab.Name = "stockTab";
            this.stockTab.Padding = new System.Windows.Forms.Padding(8);
            this.stockTab.Size = new System.Drawing.Size(3980, 1730);
            this.stockTab.TabIndex = 0;
            this.stockTab.Text = "Stock";
            this.stockTab.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(8, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3798, 1614);
            this.panel4.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 46);
            this.label12.TabIndex = 6;
            this.label12.Text = "Stock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.RefrenceTextBox);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(2992, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 169);
            this.panel2.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 32);
            this.label13.TabIndex = 18;
            this.label13.Text = "Reference :";
            // 
            // RefrenceTextBox
            // 
            this.RefrenceTextBox.Location = new System.Drawing.Point(246, 89);
            this.RefrenceTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.RefrenceTextBox.Name = "RefrenceTextBox";
            this.RefrenceTextBox.Size = new System.Drawing.Size(260, 38);
            this.RefrenceTextBox.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 32);
            this.label14.TabIndex = 15;
            this.label14.Text = "Delete a product";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 19);
            this.button3.Margin = new System.Windows.Forms.Padding(8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 54);
            this.button3.TabIndex = 0;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.RefreshButton);
            this.panel3.Controls.Add(this.StockList);
            this.panel3.Controls.Add(this.IdList);
            this.panel3.Controls.Add(this.RefrenceList);
            this.panel3.Controls.Add(this.PriceClientList);
            this.panel3.Controls.Add(this.DimensionsList);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ColorList);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TypeList);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(42, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2910, 882);
            this.panel3.TabIndex = 25;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(2562, 23);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(8);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(296, 54);
            this.RefreshButton.TabIndex = 39;
            this.RefreshButton.Text = "Refresh the list";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // StockList
            // 
            this.StockList.FormattingEnabled = true;
            this.StockList.ItemHeight = 31;
            this.StockList.Location = new System.Drawing.Point(896, 110);
            this.StockList.Margin = new System.Windows.Forms.Padding(8);
            this.StockList.Name = "StockList";
            this.StockList.Size = new System.Drawing.Size(314, 717);
            this.StockList.TabIndex = 2;
            this.StockList.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // IdList
            // 
            this.IdList.FormattingEnabled = true;
            this.IdList.ItemHeight = 31;
            this.IdList.Location = new System.Drawing.Point(138, 110);
            this.IdList.Margin = new System.Windows.Forms.Padding(8);
            this.IdList.Name = "IdList";
            this.IdList.Size = new System.Drawing.Size(314, 717);
            this.IdList.TabIndex = 0;
            this.IdList.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // RefrenceList
            // 
            this.RefrenceList.FormattingEnabled = true;
            this.RefrenceList.ItemHeight = 31;
            this.RefrenceList.Location = new System.Drawing.Point(518, 110);
            this.RefrenceList.Margin = new System.Windows.Forms.Padding(8);
            this.RefrenceList.Name = "RefrenceList";
            this.RefrenceList.Size = new System.Drawing.Size(314, 717);
            this.RefrenceList.TabIndex = 1;
            this.RefrenceList.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // PriceClientList
            // 
            this.PriceClientList.FormattingEnabled = true;
            this.PriceClientList.ItemHeight = 31;
            this.PriceClientList.Location = new System.Drawing.Point(1278, 110);
            this.PriceClientList.Margin = new System.Windows.Forms.Padding(8);
            this.PriceClientList.Name = "PriceClientList";
            this.PriceClientList.Size = new System.Drawing.Size(314, 717);
            this.PriceClientList.TabIndex = 3;
            this.PriceClientList.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // DimensionsList
            // 
            this.DimensionsList.FormattingEnabled = true;
            this.DimensionsList.ItemHeight = 31;
            this.DimensionsList.Location = new System.Drawing.Point(1648, 110);
            this.DimensionsList.Margin = new System.Windows.Forms.Padding(8);
            this.DimensionsList.Name = "DimensionsList";
            this.DimensionsList.Size = new System.Drawing.Size(314, 717);
            this.DimensionsList.TabIndex = 4;
            this.DimensionsList.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2394, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2016, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reference";
            // 
            // ColorList
            // 
            this.ColorList.FormattingEnabled = true;
            this.ColorList.ItemHeight = 31;
            this.ColorList.Location = new System.Drawing.Point(2402, 110);
            this.ColorList.Margin = new System.Windows.Forms.Padding(8);
            this.ColorList.Name = "ColorList";
            this.ColorList.Size = new System.Drawing.Size(314, 717);
            this.ColorList.TabIndex = 11;
            this.ColorList.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(888, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock";
            // 
            // TypeList
            // 
            this.TypeList.FormattingEnabled = true;
            this.TypeList.ItemHeight = 31;
            this.TypeList.Location = new System.Drawing.Point(2024, 110);
            this.TypeList.Margin = new System.Windows.Forms.Padding(8);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(314, 717);
            this.TypeList.TabIndex = 10;
            this.TypeList.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1270, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price/Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1640, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dimensions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.StockTextBox);
            this.panel1.Controls.Add(this.RefrenceTextBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2992, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 289);
            this.panel1.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Stock :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Reference :";
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(246, 198);
            this.StockTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(260, 38);
            this.StockTextBox.TabIndex = 17;
            // 
            // RefrenceTextBox2
            // 
            this.RefrenceTextBox2.Location = new System.Drawing.Point(246, 89);
            this.RefrenceTextBox2.Margin = new System.Windows.Forms.Padding(8);
            this.RefrenceTextBox2.Name = "RefrenceTextBox2";
            this.RefrenceTextBox2.Size = new System.Drawing.Size(260, 38);
            this.RefrenceTextBox2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Update stock";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.PriceClientTextBox);
            this.panel6.Controls.Add(this.RefrenceTextBox3);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Location = new System.Drawing.Point(2992, 674);
            this.panel6.Margin = new System.Windows.Forms.Padding(8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(704, 289);
            this.panel6.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 54);
            this.button2.TabIndex = 20;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PriceClientTextBox
            // 
            this.PriceClientTextBox.Location = new System.Drawing.Point(246, 198);
            this.PriceClientTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.PriceClientTextBox.Name = "PriceClientTextBox";
            this.PriceClientTextBox.Size = new System.Drawing.Size(260, 38);
            this.PriceClientTextBox.TabIndex = 22;
            // 
            // RefrenceTextBox3
            // 
            this.RefrenceTextBox3.Location = new System.Drawing.Point(246, 95);
            this.RefrenceTextBox3.Margin = new System.Windows.Forms.Padding(8);
            this.RefrenceTextBox3.Name = "RefrenceTextBox3";
            this.RefrenceTextBox3.Size = new System.Drawing.Size(260, 38);
            this.RefrenceTextBox3.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(62, 205);
            this.label18.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 32);
            this.label18.TabIndex = 19;
            this.label18.Text = "Price :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(62, 103);
            this.label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 32);
            this.label19.TabIndex = 18;
            this.label19.Text = "Reference :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(62, 31);
            this.label20.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(179, 32);
            this.label20.TabIndex = 15;
            this.label20.Text = "Update Price";
            // 
            // AddingProduct
            // 
            this.AddingProduct.BackColor = System.Drawing.Color.Transparent;
            this.AddingProduct.Controls.Add(this.supplierWizard1);
            this.AddingProduct.Controls.Add(this.productWizard1);
            this.AddingProduct.Controls.Add(this.label11);
            this.AddingProduct.Controls.Add(this.AddingProductLabel);
            this.AddingProduct.Location = new System.Drawing.Point(10, 48);
            this.AddingProduct.Margin = new System.Windows.Forms.Padding(8);
            this.AddingProduct.Name = "AddingProduct";
            this.AddingProduct.Padding = new System.Windows.Forms.Padding(8);
            this.AddingProduct.Size = new System.Drawing.Size(3980, 1730);
            this.AddingProduct.TabIndex = 1;
            this.AddingProduct.Text = "Add a product or supplier";
            // 
            // supplierWizard1
            // 
            this.supplierWizard1.Location = new System.Drawing.Point(1686, 172);
            this.supplierWizard1.Margin = new System.Windows.Forms.Padding(10);
            this.supplierWizard1.Name = "supplierWizard1";
            this.supplierWizard1.Size = new System.Drawing.Size(1602, 1567);
            this.supplierWizard1.TabIndex = 7;
            // 
            // productWizard1
            // 
            this.productWizard1.Location = new System.Drawing.Point(54, 176);
            this.productWizard1.Margin = new System.Windows.Forms.Padding(10);
            this.productWizard1.Name = "productWizard1";
            this.productWizard1.Size = new System.Drawing.Size(1570, 1304);
            this.productWizard1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1674, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(432, 46);
            this.label11.TabIndex = 4;
            this.label11.Text = "Adding a new supplier";
            // 
            // AddingProductLabel
            // 
            this.AddingProductLabel.AutoSize = true;
            this.AddingProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingProductLabel.Location = new System.Drawing.Point(86, 89);
            this.AddingProductLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AddingProductLabel.Name = "AddingProductLabel";
            this.AddingProductLabel.Size = new System.Drawing.Size(426, 46);
            this.AddingProductLabel.TabIndex = 0;
            this.AddingProductLabel.Text = "Adding a new product";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.command1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(3980, 1730);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Order";
            // 
            // command1
            // 
            this.command1.BackColor = System.Drawing.Color.Transparent;
            this.command1.Location = new System.Drawing.Point(8, 112);
            this.command1.Margin = new System.Windows.Forms.Padding(10);
            this.command1.Name = "command1";
            this.command1.Size = new System.Drawing.Size(3712, 982);
            this.command1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.clientWizard1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(3980, 1730);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Customer";
            // 
            // clientWizard1
            // 
            this.clientWizard1.Location = new System.Drawing.Point(8, 107);
            this.clientWizard1.Margin = new System.Windows.Forms.Padding(10);
            this.clientWizard1.Name = "clientWizard1";
            this.clientWizard1.Size = new System.Drawing.Size(2854, 1498);
            this.clientWizard1.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(78, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(458, 46);
            this.label15.TabIndex = 6;
            this.label15.Text = "Adding a new customer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1707);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.stockTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.AddingProduct.ResumeLayout(false);
            this.AddingProduct.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage stockTab;
        private System.Windows.Forms.TabPage AddingProduct;
        private System.Windows.Forms.ListBox DimensionsList;
        private System.Windows.Forms.ListBox PriceClientList;
        private System.Windows.Forms.ListBox StockList;
        private System.Windows.Forms.ListBox RefrenceList;
        private System.Windows.Forms.ListBox IdList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ColorList;
        private System.Windows.Forms.ListBox TypeList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AddingProductLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PriceClientTextBox;
        private System.Windows.Forms.TextBox RefrenceTextBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.TextBox RefrenceTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox RefrenceTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private ClientWizard clientWizard1;
        private ProductWizard productWizard1;
        private SupplierWizard supplierWizard1;
        private Command command1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button RefreshButton;
    }
}
