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
            this.button4 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PriceClientTextBox = new System.Windows.Forms.TextBox();
            this.RefrenceTextBox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.RefrenceTextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.RefrenceTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ColorList = new System.Windows.Forms.ListBox();
            this.TypeList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DimensionsList = new System.Windows.Forms.ListBox();
            this.PriceClientList = new System.Windows.Forms.ListBox();
            this.StockList = new System.Windows.Forms.ListBox();
            this.RefrenceList = new System.Windows.Forms.ListBox();
            this.IdList = new System.Windows.Forms.ListBox();
            this.AddingProduct = new System.Windows.Forms.TabPage();
            this.productWizard1 = new interface_Magasinier.ProductWizard();
            this.AddingProductLabel = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.stockTab.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.AddingProduct.SuspendLayout();
            this.SuspendLayout();
            //
            // Tabs
            //
            this.Tabs.Controls.Add(this.stockTab);
            this.Tabs.Controls.Add(this.AddingProduct);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1500, 750);
            this.Tabs.TabIndex = 0;
            //
            // stockTab
            //
            this.stockTab.Controls.Add(this.button4);
            this.stockTab.Controls.Add(this.panel6);
            this.stockTab.Controls.Add(this.panel1);
            this.stockTab.Controls.Add(this.panel2);
            this.stockTab.Controls.Add(this.label7);
            this.stockTab.Controls.Add(this.label6);
            this.stockTab.Controls.Add(this.ColorList);
            this.stockTab.Controls.Add(this.TypeList);
            this.stockTab.Controls.Add(this.label5);
            this.stockTab.Controls.Add(this.label4);
            this.stockTab.Controls.Add(this.label3);
            this.stockTab.Controls.Add(this.label2);
            this.stockTab.Controls.Add(this.label1);
            this.stockTab.Controls.Add(this.DimensionsList);
            this.stockTab.Controls.Add(this.PriceClientList);
            this.stockTab.Controls.Add(this.StockList);
            this.stockTab.Controls.Add(this.RefrenceList);
            this.stockTab.Controls.Add(this.IdList);
            this.stockTab.Location = new System.Drawing.Point(4, 22);
            this.stockTab.Name = "stockTab";
            this.stockTab.Padding = new System.Windows.Forms.Padding(3);
            this.stockTab.Size = new System.Drawing.Size(1492, 724);
            this.stockTab.TabIndex = 0;
            this.stockTab.Text = "Stock";
            this.stockTab.UseVisualStyleBackColor = true;
            //
            // button4
            //
            this.button4.Location = new System.Drawing.Point(1310, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            //
            // panel6
            //
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.PriceClientTextBox);
            this.panel6.Controls.Add(this.RefrenceTextBox3);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Location = new System.Drawing.Point(1124, 301);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 122);
            this.panel6.TabIndex = 23;
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(185, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // PriceClientTextBox
            //
            this.PriceClientTextBox.Location = new System.Drawing.Point(92, 83);
            this.PriceClientTextBox.Name = "PriceClientTextBox";
            this.PriceClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceClientTextBox.TabIndex = 22;
            //
            // RefrenceTextBox3
            //
            this.RefrenceTextBox3.Location = new System.Drawing.Point(92, 40);
            this.RefrenceTextBox3.Name = "RefrenceTextBox3";
            this.RefrenceTextBox3.Size = new System.Drawing.Size(100, 20);
            this.RefrenceTextBox3.TabIndex = 21;
            //
            // label18
            //
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Price :";
            //
            // label19
            //
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Reference :";
            //
            // label20
            //
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Update Price";
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.StockTextBox);
            this.panel1.Controls.Add(this.RefrenceTextBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1124, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 122);
            this.panel1.TabIndex = 22;
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Stock :";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Reference :";
            //
            // StockTextBox
            //
            this.StockTextBox.Location = new System.Drawing.Point(92, 83);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.StockTextBox.TabIndex = 17;
            //
            // RefrenceTextBox2
            //
            this.RefrenceTextBox2.Location = new System.Drawing.Point(92, 37);
            this.RefrenceTextBox2.Name = "RefrenceTextBox2";
            this.RefrenceTextBox2.Size = new System.Drawing.Size(100, 20);
            this.RefrenceTextBox2.TabIndex = 16;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Update stock";
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(185, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // panel2
            //
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.RefrenceTextBox);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(1124, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 72);
            this.panel2.TabIndex = 21;
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Reference :";
            //
            // RefrenceTextBox
            //
            this.RefrenceTextBox.Location = new System.Drawing.Point(92, 37);
            this.RefrenceTextBox.Name = "RefrenceTextBox";
            this.RefrenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.RefrenceTextBox.TabIndex = 16;
            //
            // label14
            //
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Delete a product";
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(185, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Stock :";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Reference :";
            //
            // textBox2
            //
            this.textBox2.Location = new System.Drawing.Point(92, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(92, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Update stock";
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(185, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(949, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Color";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(807, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type";
            //
            // ColorList
            //
            this.ColorList.FormattingEnabled = true;
            this.ColorList.Location = new System.Drawing.Point(952, 57);
            this.ColorList.Name = "ColorList";
            this.ColorList.Size = new System.Drawing.Size(120, 225);
            this.ColorList.TabIndex = 11;
            this.ColorList.Click += new System.EventHandler(this.listBox2_Click);
            //
            // TypeList
            //
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Location = new System.Drawing.Point(810, 57);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(120, 225);
            this.TypeList.TabIndex = 10;
            this.TypeList.Click += new System.EventHandler(this.listBox2_Click);
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dimensions";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price/Client";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reference";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID\r\n";
            //
            // DimensionsList
            //
            this.DimensionsList.FormattingEnabled = true;
            this.DimensionsList.Location = new System.Drawing.Point(669, 57);
            this.DimensionsList.Name = "DimensionsList";
            this.DimensionsList.Size = new System.Drawing.Size(120, 225);
            this.DimensionsList.TabIndex = 4;
            this.DimensionsList.Click += new System.EventHandler(this.listBox2_Click);
            //
            // PriceClientList
            //
            this.PriceClientList.FormattingEnabled = true;
            this.PriceClientList.Location = new System.Drawing.Point(530, 57);
            this.PriceClientList.Name = "PriceClientList";
            this.PriceClientList.Size = new System.Drawing.Size(120, 225);
            this.PriceClientList.TabIndex = 3;
            this.PriceClientList.Click += new System.EventHandler(this.listBox2_Click);
            //
            // StockList
            //
            this.StockList.FormattingEnabled = true;
            this.StockList.Location = new System.Drawing.Point(387, 57);
            this.StockList.Name = "StockList";
            this.StockList.Size = new System.Drawing.Size(120, 225);
            this.StockList.TabIndex = 2;
            this.StockList.Click += new System.EventHandler(this.listBox2_Click);
            //
            // RefrenceList
            //
            this.RefrenceList.FormattingEnabled = true;
            this.RefrenceList.Location = new System.Drawing.Point(245, 57);
            this.RefrenceList.Name = "RefrenceList";
            this.RefrenceList.Size = new System.Drawing.Size(120, 225);
            this.RefrenceList.TabIndex = 1;
            this.RefrenceList.Click += new System.EventHandler(this.listBox2_Click);
            //
            // IdList
            //
            this.IdList.FormattingEnabled = true;
            this.IdList.Location = new System.Drawing.Point(103, 57);
            this.IdList.Name = "IdList";
            this.IdList.Size = new System.Drawing.Size(120, 225);
            this.IdList.TabIndex = 0;
            this.IdList.Click += new System.EventHandler(this.listBox2_Click);
            //
            // AddingProduct
            //
            this.AddingProduct.BackColor = System.Drawing.Color.Transparent;
            this.AddingProduct.Controls.Add(this.productWizard1);
            this.AddingProduct.Controls.Add(this.AddingProductLabel);
            this.AddingProduct.Location = new System.Drawing.Point(4, 22);
            this.AddingProduct.Name = "AddingProduct";
            this.AddingProduct.Padding = new System.Windows.Forms.Padding(3);
            this.AddingProduct.Size = new System.Drawing.Size(1492, 724);
            this.AddingProduct.TabIndex = 1;
            this.AddingProduct.Text = "Add a product";
            //
            // productWizard1
            //
            this.productWizard1.Location = new System.Drawing.Point(36, 85);
            this.productWizard1.Margin = new System.Windows.Forms.Padding(4);
            this.productWizard1.Name = "productWizard1";
            this.productWizard1.Size = new System.Drawing.Size(376, 534);
            this.productWizard1.TabIndex = 1;
            //
            // AddingProductLabel
            //
            this.AddingProductLabel.AutoSize = true;
            this.AddingProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingProductLabel.Location = new System.Drawing.Point(32, 37);
            this.AddingProductLabel.Name = "AddingProductLabel";
            this.AddingProductLabel.Size = new System.Drawing.Size(183, 20);
            this.AddingProductLabel.TabIndex = 0;
            this.AddingProductLabel.Text = "Adding a new product";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 716);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.stockTab.ResumeLayout(false);
            this.stockTab.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.AddingProduct.ResumeLayout(false);
            this.AddingProduct.PerformLayout();
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
        private ProductWizard productWizard1;
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
        private System.Windows.Forms.Button button4;
    }
}
