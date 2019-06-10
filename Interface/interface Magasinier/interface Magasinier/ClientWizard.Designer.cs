namespace interface_Magasinier
{
    partial class ClientWizard
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
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ZipList = new System.Windows.Forms.ListBox();
            this.IdZipList = new System.Windows.Forms.ListBox();
            this.CityList = new System.Windows.Forms.ListBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.PhoneClient = new System.Windows.Forms.ListBox();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ZipClientList = new System.Windows.Forms.ListBox();
            this.IdClientList = new System.Windows.Forms.ListBox();
            this.NumberClientList = new System.Windows.Forms.ListBox();
            this.NameClientList = new System.Windows.Forms.ListBox();
            this.StreetClientList = new System.Windows.Forms.ListBox();
            this.EmailClientList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.ClientEmail = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NumbertextBox = new System.Windows.Forms.TextBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.addzip = new System.Windows.Forms.Button();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.ZipBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.supplierGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierGroupBox
            // 
            this.supplierGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.supplierGroupBox.Controls.Add(this.label14);
            this.supplierGroupBox.Controls.Add(this.panel4);
            this.supplierGroupBox.Controls.Add(this.panel3);
            this.supplierGroupBox.Controls.Add(this.panel2);
            this.supplierGroupBox.Controls.Add(this.label1);
            this.supplierGroupBox.Controls.Add(this.label7);
            this.supplierGroupBox.Controls.Add(this.panel1);
            this.supplierGroupBox.Controls.Add(this.label5);
            this.supplierGroupBox.Location = new System.Drawing.Point(19, 13);
            this.supplierGroupBox.Name = "supplierGroupBox";
            this.supplierGroupBox.Size = new System.Drawing.Size(1014, 630);
            this.supplierGroupBox.TabIndex = 34;
            this.supplierGroupBox.TabStop = false;
            this.supplierGroupBox.Text = "Client";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Client information";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.ZipList);
            this.panel4.Controls.Add(this.IdZipList);
            this.panel4.Controls.Add(this.CityList);
            this.panel4.Controls.Add(this.IdLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(36, 212);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 133);
            this.panel4.TabIndex = 59;
            // 
            // ZipList
            // 
            this.ZipList.FormattingEnabled = true;
            this.ZipList.Location = new System.Drawing.Point(149, 22);
            this.ZipList.Name = "ZipList";
            this.ZipList.Size = new System.Drawing.Size(120, 95);
            this.ZipList.TabIndex = 39;
            this.ZipList.Click += new System.EventHandler(this.ziplistBox_Click);
            // 
            // IdZipList
            // 
            this.IdZipList.FormattingEnabled = true;
            this.IdZipList.Location = new System.Drawing.Point(8, 22);
            this.IdZipList.Name = "IdZipList";
            this.IdZipList.Size = new System.Drawing.Size(120, 95);
            this.IdZipList.TabIndex = 38;
            this.IdZipList.Click += new System.EventHandler(this.ziplistBox_Click);
            // 
            // CityList
            // 
            this.CityList.FormattingEnabled = true;
            this.CityList.Location = new System.Drawing.Point(293, 22);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(120, 95);
            this.CityList.TabIndex = 40;
            this.CityList.Click += new System.EventHandler(this.ziplistBox_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(5, 5);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 42;
            this.IdLabel.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Zip code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "City :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.PhoneClient);
            this.panel3.Controls.Add(this.NameLabel1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.ZipClientList);
            this.panel3.Controls.Add(this.IdClientList);
            this.panel3.Controls.Add(this.NumberClientList);
            this.panel3.Controls.Add(this.NameClientList);
            this.panel3.Controls.Add(this.StreetClientList);
            this.panel3.Controls.Add(this.EmailClientList);
            this.panel3.Location = new System.Drawing.Point(36, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 139);
            this.panel3.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(682, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "Phone number :";
            // 
            // PhoneClient
            // 
            this.PhoneClient.FormattingEnabled = true;
            this.PhoneClient.Location = new System.Drawing.Point(685, 32);
            this.PhoneClient.Name = "PhoneClient";
            this.PhoneClient.Size = new System.Drawing.Size(120, 95);
            this.PhoneClient.TabIndex = 59;
            this.PhoneClient.Click += new System.EventHandler(this.ClientlistBox_Click);
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Location = new System.Drawing.Point(147, 15);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(41, 13);
            this.NameLabel1.TabIndex = 58;
            this.NameLabel1.Text = "Name :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Email :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(419, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Street:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(815, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Zip code :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Id:";
            // 
            // ZipClientList
            // 
            this.ZipClientList.FormattingEnabled = true;
            this.ZipClientList.Location = new System.Drawing.Point(818, 32);
            this.ZipClientList.Name = "ZipClientList";
            this.ZipClientList.Size = new System.Drawing.Size(120, 95);
            this.ZipClientList.TabIndex = 53;
            this.ZipClientList.Click += new System.EventHandler(this.ClientlistBox_Click);
            // 
            // IdClientList
            // 
            this.IdClientList.FormattingEnabled = true;
            this.IdClientList.Location = new System.Drawing.Point(15, 32);
            this.IdClientList.Name = "IdClientList";
            this.IdClientList.Size = new System.Drawing.Size(120, 95);
            this.IdClientList.TabIndex = 48;
            this.IdClientList.Click += new System.EventHandler(this.ClientlistBox_Click);
            // 
            // NumberClientList
            // 
            this.NumberClientList.FormattingEnabled = true;
            this.NumberClientList.Location = new System.Drawing.Point(553, 32);
            this.NumberClientList.Name = "NumberClientList";
            this.NumberClientList.Size = new System.Drawing.Size(120, 95);
            this.NumberClientList.TabIndex = 52;
            this.NumberClientList.Click += new System.EventHandler(this.ClientlistBox_Click);
            // 
            // NameClientList
            // 
            this.NameClientList.FormattingEnabled = true;
            this.NameClientList.Location = new System.Drawing.Point(149, 32);
            this.NameClientList.Name = "NameClientList";
            this.NameClientList.Size = new System.Drawing.Size(120, 95);
            this.NameClientList.TabIndex = 49;
            this.NameClientList.Click += new System.EventHandler(this.ClientlistBox_Click);
            // 
            // StreetClientList
            // 
            this.StreetClientList.FormattingEnabled = true;
            this.StreetClientList.Location = new System.Drawing.Point(422, 32);
            this.StreetClientList.Name = "StreetClientList";
            this.StreetClientList.Size = new System.Drawing.Size(120, 95);
            this.StreetClientList.TabIndex = 51;
            this.StreetClientList.Click += new System.EventHandler(this.ClientlistBox_Click);
            // 
            // EmailClientList
            // 
            this.EmailClientList.FormattingEnabled = true;
            this.EmailClientList.Location = new System.Drawing.Point(286, 32);
            this.EmailClientList.Name = "EmailClientList";
            this.EmailClientList.Size = new System.Drawing.Size(120, 95);
            this.EmailClientList.TabIndex = 50;
            this.EmailClientList.Click += new System.EventHandler(this.ClientlistBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.PhoneNumberBox);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.ZipTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.StreetTextBox);
            this.panel2.Controls.Add(this.MailTextBox);
            this.panel2.Controls.Add(this.ClientEmail);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.StreetLabel);
            this.panel2.Controls.Add(this.NumberLabel);
            this.panel2.Controls.Add(this.NumbertextBox);
            this.panel2.Controls.Add(this.finishButton);
            this.panel2.Location = new System.Drawing.Point(36, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 223);
            this.panel2.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "Phone Number :";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(120, 126);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberBox.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Name :";
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(120, 153);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZipTextBox.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Zip Code :";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(120, 69);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.StreetTextBox.TabIndex = 35;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(120, 41);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(100, 20);
            this.MailTextBox.TabIndex = 29;
            // 
            // ClientEmail
            // 
            this.ClientEmail.AutoSize = true;
            this.ClientEmail.Location = new System.Drawing.Point(13, 44);
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.Size = new System.Drawing.Size(38, 13);
            this.ClientEmail.TabIndex = 3;
            this.ClientEmail.Text = "Email :";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(120, 15);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 32;
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(13, 72);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(41, 13);
            this.StreetLabel.TabIndex = 33;
            this.StreetLabel.Text = "Street :";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(13, 101);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(50, 13);
            this.NumberLabel.TabIndex = 34;
            this.NumberLabel.Text = "Number :";
            // 
            // NumbertextBox
            // 
            this.NumbertextBox.Location = new System.Drawing.Point(120, 98);
            this.NumbertextBox.Name = "NumbertextBox";
            this.NumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.NumbertextBox.TabIndex = 36;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(10, 182);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(143, 23);
            this.finishButton.TabIndex = 31;
            this.finishButton.Text = "Add the new Supplier";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "If the zip code is in the list select it to fill the textBox in the wizard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Fill the text box and select the zip code in the list to add a new Client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CityBox);
            this.panel1.Controls.Add(this.addzip);
            this.panel1.Controls.Add(this.ZipLabel);
            this.panel1.Controls.Add(this.ZipBox);
            this.panel1.Location = new System.Drawing.Point(517, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 121);
            this.panel1.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "City :";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(92, 41);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(100, 20);
            this.CityBox.TabIndex = 38;
            // 
            // addzip
            // 
            this.addzip.Location = new System.Drawing.Point(11, 80);
            this.addzip.Name = "addzip";
            this.addzip.Size = new System.Drawing.Size(109, 23);
            this.addzip.TabIndex = 0;
            this.addzip.Text = "add the zip code";
            this.addzip.UseVisualStyleBackColor = true;
            this.addzip.Click += new System.EventHandler(this.addzip_Click);
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(16, 18);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(56, 13);
            this.ZipLabel.TabIndex = 1;
            this.ZipLabel.Text = "Zip Code :";
            // 
            // ZipBox
            // 
            this.ZipBox.Location = new System.Drawing.Point(92, 15);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(100, 20);
            this.ZipBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Otherwise add it to the llist by filling this textBox";
            // 
            // ClientWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.supplierGroupBox);
            this.Name = "ClientWizard";
            this.Size = new System.Drawing.Size(1070, 664);
            this.Load += new System.EventHandler(this.loadList);
            this.supplierGroupBox.ResumeLayout(false);
            this.supplierGroupBox.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox supplierGroupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Label ClientEmail;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox NumbertextBox;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Button addzip;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TextBox ZipBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CityList;
        private System.Windows.Forms.ListBox ZipList;
        private System.Windows.Forms.ListBox IdZipList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NameLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox ZipClientList;
        private System.Windows.Forms.ListBox IdClientList;
        private System.Windows.Forms.ListBox NumberClientList;
        private System.Windows.Forms.ListBox NameClientList;
        private System.Windows.Forms.ListBox StreetClientList;
        private System.Windows.Forms.ListBox EmailClientList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox PhoneClient;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PhoneNumberBox;
    }
}
