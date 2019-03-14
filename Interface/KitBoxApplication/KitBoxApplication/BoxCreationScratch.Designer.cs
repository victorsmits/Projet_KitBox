namespace KitBoxApplication
{
    partial class BoxCreationScratch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxCreationScratch));
            this.comboBoxColorAngles = new System.Windows.Forms.ComboBox();
            this.labelColorAngles = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelQuantityBox = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBox1 = new System.Windows.Forms.TabPage();
            this.creationScratchInside2 = new KitBoxApplication.CreationScratchInside();
            this.tabPageBox2 = new System.Windows.Forms.TabPage();
            this.creationScratchInside1 = new KitBoxApplication.CreationScratchInside();
            this.tabPageBox3 = new System.Windows.Forms.TabPage();
            this.creationScratchInside3 = new KitBoxApplication.CreationScratchInside();
            this.tabPageBox4 = new System.Windows.Forms.TabPage();
            this.creationScratchInside4 = new KitBoxApplication.CreationScratchInside();
            this.tabPageBox5 = new System.Windows.Forms.TabPage();
            this.creationScratchInside5 = new KitBoxApplication.CreationScratchInside();
            this.tabPageBox6 = new System.Windows.Forms.TabPage();
            this.creationScratchInside6 = new KitBoxApplication.CreationScratchInside();
            this.tabPageBox7 = new System.Windows.Forms.TabPage();
            this.creationScratchInside7 = new KitBoxApplication.CreationScratchInside();
            this.button2 = new System.Windows.Forms.Button();
            this.labelExplanation = new System.Windows.Forms.Label();
            this.labelHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageBox1.SuspendLayout();
            this.tabPageBox2.SuspendLayout();
            this.tabPageBox3.SuspendLayout();
            this.tabPageBox4.SuspendLayout();
            this.tabPageBox5.SuspendLayout();
            this.tabPageBox6.SuspendLayout();
            this.tabPageBox7.SuspendLayout();
            this.SuspendLayout();
            //
            // labelColorAngles
            //
            this.labelColorAngles.AutoSize = true;
            this.labelColorAngles.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorAngles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelColorAngles.Location = new System.Drawing.Point(50, 200);
            this.labelColorAngles.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelColorAngles.Name = "labelColorAngles";
            this.labelColorAngles.Size = new System.Drawing.Size(328, 40);
            this.labelColorAngles.TabIndex = 64;
            this.labelColorAngles.Text = "Color of the Angles";
            //
            // numericUpDownQuantity
            //
            this.numericUpDownQuantity.AutoSize = true;
            this.numericUpDownQuantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numericUpDownQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownQuantity.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDownQuantity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDownQuantity.Location = new System.Drawing.Point(441, 120);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(150, 38);
            this.numericUpDownQuantity.TabIndex = 61;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            //
            // labelQuantityBox
            //
            this.labelQuantityBox.AutoSize = true;
            this.labelQuantityBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelQuantityBox.Location = new System.Drawing.Point(50, 120);
            this.labelQuantityBox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelQuantityBox.Name = "labelQuantityBox";
            this.labelQuantityBox.Size = new System.Drawing.Size(309, 40);
            this.labelQuantityBox.TabIndex = 60;
            this.labelQuantityBox.Text = "Quantity of boxes";
            //
            // labelTitle
            //
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(2416, 74);
            this.labelTitle.TabIndex = 70;
            this.labelTitle.Text = "Construction Cabinet";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tabControl1
            //
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPageBox1);
            this.tabControl1.Controls.Add(this.tabPageBox2);
            this.tabControl1.Controls.Add(this.tabPageBox3);
            this.tabControl1.Controls.Add(this.tabPageBox4);
            this.tabControl1.Controls.Add(this.tabPageBox5);
            this.tabControl1.Controls.Add(this.tabPageBox6);
            this.tabControl1.Controls.Add(this.tabPageBox7);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 30);
            this.tabControl1.Location = new System.Drawing.Point(60, 371);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(16, 9);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1365, 717);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            //
            // tabPageBox1
            //
            this.tabPageBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tabPageBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.tabPageBox1.Controls.Add(this.creationScratchInside2);
            this.tabPageBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tabPageBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabPageBox1.ImageIndex = 1;
            this.tabPageBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPageBox1.Location = new System.Drawing.Point(4, 34);
            this.tabPageBox1.Name = "tabPageBox1";
            this.tabPageBox1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBox1.Size = new System.Drawing.Size(1357, 679);
            this.tabPageBox1.TabIndex = 0;
            this.tabPageBox1.Text = "Box 1";
            //
            // creationScratchInside2
            //
            this.creationScratchInside2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.creationScratchInside2.Location = new System.Drawing.Point(45, 36);
            this.creationScratchInside2.Margin = new System.Windows.Forms.Padding(4);
            this.creationScratchInside2.Name = "creationScratchInside2";
            this.creationScratchInside2.Size = new System.Drawing.Size(1170, 589);
            this.creationScratchInside2.TabIndex = 0;
            //
            // tabPageBox2
            //
            this.tabPageBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.tabPageBox2.Controls.Add(this.creationScratchInside1);
            this.tabPageBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBox2.Location = new System.Drawing.Point(4, 34);
            this.tabPageBox2.Name = "tabPageBox2";
            this.tabPageBox2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBox2.Size = new System.Drawing.Size(1357, 679);
            this.tabPageBox2.TabIndex = 1;
            this.tabPageBox2.Text = "Box 2";
            //
            // creationScratchInside1
            //
            this.creationScratchInside1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.creationScratchInside1.Location = new System.Drawing.Point(45, 36);
            this.creationScratchInside1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creationScratchInside1.Name = "creationScratchInside1";
            this.creationScratchInside1.Size = new System.Drawing.Size(1142, 569);
            this.creationScratchInside1.TabIndex = 0;
            //
            // tabPageBox3
            //
            this.tabPageBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.tabPageBox3.Controls.Add(this.creationScratchInside3);
            this.tabPageBox3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tabPageBox3.ImageKey = "(none)";
            this.tabPageBox3.Location = new System.Drawing.Point(4, 34);
            this.tabPageBox3.Name = "tabPageBox3";
            this.tabPageBox3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBox3.Size = new System.Drawing.Size(1357, 679);
            this.tabPageBox3.TabIndex = 2;
            this.tabPageBox3.Text = "Box 3";
            //
            // creationScratchInside3
            //
            this.creationScratchInside3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.creationScratchInside3.Location = new System.Drawing.Point(45, 36);
            this.creationScratchInside3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creationScratchInside3.Name = "creationScratchInside3";
            this.creationScratchInside3.Size = new System.Drawing.Size(1142, 569);
            this.creationScratchInside3.TabIndex = 0;
            //
            // tabPageBox4
            //
            this.tabPageBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.tabPageBox4.Controls.Add(this.creationScratchInside4);
            this.tabPageBox4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tabPageBox4.Location = new System.Drawing.Point(4, 34);
            this.tabPageBox4.Name = "tabPageBox4";
            this.tabPageBox4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBox4.Size = new System.Drawing.Size(1357, 679);
            this.tabPageBox4.TabIndex = 3;
            this.tabPageBox4.Text = "Box 4";
            //
            // creationScratchInside4
            //
            this.creationScratchInside4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.creationScratchInside4.Location = new System.Drawing.Point(45, 36);
            this.creationScratchInside4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creationScratchInside4.Name = "creationScratchInside4";
            this.creationScratchInside4.Size = new System.Drawing.Size(1142, 569);
            this.creationScratchInside4.TabIndex = 0;
            //
            // tabPageBox5
            //
            this.tabPageBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.tabPageBox5.Controls.Add(this.creationScratchInside5);
            this.tabPageBox5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tabPageBox5.Location = new System.Drawing.Point(4, 34);
            this.tabPageBox5.Name = "tabPageBox5";
            this.tabPageBox5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBox5.Size = new System.Drawing.Size(1357, 679);
            this.tabPageBox5.TabIndex = 4;
            this.tabPageBox5.Text = "Box 5";
            //
            // creationScratchInside5
            //
            this.creationScratchInside5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.creationScratchInside5.Location = new System.Drawing.Point(45, 36);
            this.creationScratchInside5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creationScratchInside5.Name = "creationScratchInside5";
            this.creationScratchInside5.Size = new System.Drawing.Size(1142, 569);
            this.creationScratchInside5.TabIndex = 0;
            //
            // tabPageBox6
            //
            this.tabPageBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.tabPageBox6.Controls.Add(this.creationScratchInside6);
            this.tabPageBox6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tabPageBox6.Location = new System.Drawing.Point(4, 34);
            this.tabPageBox6.Name = "tabPageBox6";
            this.tabPageBox6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBox6.Size = new System.Drawing.Size(1357, 679);
            this.tabPageBox6.TabIndex = 5;
            this.tabPageBox6.Text = "Box 6";
            //
            // creationScratchInside6
            //
            this.creationScratchInside6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.creationScratchInside6.Location = new System.Drawing.Point(45, 36);
            this.creationScratchInside6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creationScratchInside6.Name = "creationScratchInside6";
            this.creationScratchInside6.Size = new System.Drawing.Size(1142, 569);
            this.creationScratchInside6.TabIndex = 0;
            //
            // tabPageBox7
            //
            this.tabPageBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.tabPageBox7.Controls.Add(this.creationScratchInside7);
            this.tabPageBox7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tabPageBox7.ForeColor = System.Drawing.Color.Black;
            this.tabPageBox7.Location = new System.Drawing.Point(4, 34);
            this.tabPageBox7.Name = "tabPageBox7";
            this.tabPageBox7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBox7.Size = new System.Drawing.Size(1357, 679);
            this.tabPageBox7.TabIndex = 6;
            this.tabPageBox7.Text = "Box 7";
            //
            // creationScratchInside7
            //
            this.creationScratchInside7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.creationScratchInside7.Location = new System.Drawing.Point(45, 36);
            this.creationScratchInside7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creationScratchInside7.Name = "creationScratchInside7";
            this.creationScratchInside7.Size = new System.Drawing.Size(1142, 569);
            this.creationScratchInside7.TabIndex = 0;
            //
            // button2
            //
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.button2.Location = new System.Drawing.Point(2000, 1189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 87);
            this.button2.TabIndex = 74;
            this.button2.Text = "Add To Cart";
            this.button2.UseVisualStyleBackColor = false;
            //
            // labelExplanation
            //
            this.labelExplanation.AllowDrop = true;
            this.labelExplanation.AutoSize = true;
            this.labelExplanation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExplanation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExplanation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExplanation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelExplanation.Location = new System.Drawing.Point(1579, 203);
            this.labelExplanation.MaximumSize = new System.Drawing.Size(750, 0);
            this.labelExplanation.Name = "labelExplanation";
            this.labelExplanation.Size = new System.Drawing.Size(736, 187);
            this.labelExplanation.TabIndex = 73;
            this.labelExplanation.Text = resources.GetString("labelExplanation.Text");
            //
            // labelHelp
            //
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelHelp.Location = new System.Drawing.Point(1909, 109);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(109, 47);
            this.labelHelp.TabIndex = 72;
            this.labelHelp.Text = "Help";
            //
            // comboBoxHeight
            //
            this.comboBoxHeight.FormattingEnabled = true;
            this.comboBoxHeight.Items.AddRange(new object[] {
            "Brun",
            "Blanc",
            "Galvinisé",
            "Noir"});
            this.comboBoxHeight.Location = new System.Drawing.Point(868, 200);
            this.comboBoxHeight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxHeight.Name = "comboBoxHeight";
            this.comboBoxHeight.Size = new System.Drawing.Size(200, 39);
            this.comboBoxHeight.TabIndex = 75;
            //
            // comboBoxColorAngles
            //
            this.comboBoxColorAngles.FormattingEnabled = true;
            this.comboBoxColorAngles.Items.AddRange(new object[] {
            "Brun",
            "Blanc",
            "Galvinisé",
            "Noir"});
            this.comboBoxColorAngles.Location = new System.Drawing.Point(441, 201);
            this.comboBoxColorAngles.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxColorAngles.Name = "comboBoxColorAngles";
            this.comboBoxColorAngles.Size = new System.Drawing.Size(200, 39);
            this.comboBoxColorAngles.TabIndex = 76;
            //
            // BoxCreationScratch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelExplanation);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxColorAngles);
            this.Controls.Add(this.labelColorAngles);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.labelQuantityBox);
            this.Name = "BoxCreationScratch";
            this.Size = new System.Drawing.Size(2416, 1407);
            this.Load += new System.EventHandler(this.BoxCreationScratch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageBox1.ResumeLayout(false);
            this.tabPageBox2.ResumeLayout(false);
            this.tabPageBox3.ResumeLayout(false);
            this.tabPageBox4.ResumeLayout(false);
            this.tabPageBox5.ResumeLayout(false);
            this.tabPageBox6.ResumeLayout(false);
            this.tabPageBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxColorAngles;
        private System.Windows.Forms.Label labelColorAngles;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantityBox;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBox1;
        private System.Windows.Forms.TabPage tabPageBox2;
        private System.Windows.Forms.TabPage tabPageBox3;
        private System.Windows.Forms.TabPage tabPageBox4;
        private System.Windows.Forms.TabPage tabPageBox5;
        private System.Windows.Forms.TabPage tabPageBox6;
        private System.Windows.Forms.TabPage tabPageBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Label labelHelp;
        private CreationScratchInside creationScratchInside2;
        private CreationScratchInside creationScratchInside1;
        private CreationScratchInside creationScratchInside3;
        private CreationScratchInside creationScratchInside4;
        private CreationScratchInside creationScratchInside5;
        private CreationScratchInside creationScratchInside6;
        private CreationScratchInside creationScratchInside7;
    }
}
