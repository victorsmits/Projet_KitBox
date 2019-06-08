namespace KitBoxApplication
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonCart = new System.Windows.Forms.Button();
            this.buttonCreation = new System.Windows.Forms.Button();
            this.buttonDash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.KitBoxHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.homePage3 = new KitBoxApplication.HomePage();
            this.creation2 = new KitBoxApplication.Creation();
            this.cartPage1 = new KitBoxApplication.CartPage();
            this.aboutUs1 = new KitBoxApplication.AboutUs();
            this.SidePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.SidePanel.Controls.Add(this.buttonAbout);
            this.SidePanel.Controls.Add(this.buttonCart);
            this.SidePanel.Controls.Add(this.buttonCreation);
            this.SidePanel.Controls.Add(this.buttonDash);
            this.SidePanel.Controls.Add(this.panel2);
            this.SidePanel.Controls.Add(this.ButtonHome);
            this.SidePanel.Controls.Add(this.LogoPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(392, 2985);
            this.SidePanel.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.Location = new System.Drawing.Point(0, 762);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(392, 208);
            this.buttonAbout.TabIndex = 104;
            this.buttonAbout.Text = "About Us";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonCart
            // 
            this.buttonCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCart.FlatAppearance.BorderSize = 0;
            this.buttonCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCart.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCart.ForeColor = System.Drawing.Color.White;
            this.buttonCart.Image = ((System.Drawing.Image)(resources.GetObject("buttonCart.Image")));
            this.buttonCart.Location = new System.Drawing.Point(0, 554);
            this.buttonCart.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(392, 208);
            this.buttonCart.TabIndex = 103;
            this.buttonCart.Text = "Cart";
            this.buttonCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCart.UseVisualStyleBackColor = true;
            this.buttonCart.Click += new System.EventHandler(this.ButtonCart_Click);
            // 
            // buttonCreation
            // 
            this.buttonCreation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreation.FlatAppearance.BorderSize = 0;
            this.buttonCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreation.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreation.ForeColor = System.Drawing.Color.White;
            this.buttonCreation.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreation.Image")));
            this.buttonCreation.Location = new System.Drawing.Point(0, 346);
            this.buttonCreation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCreation.Name = "buttonCreation";
            this.buttonCreation.Size = new System.Drawing.Size(392, 208);
            this.buttonCreation.TabIndex = 101;
            this.buttonCreation.Text = "Creation";
            this.buttonCreation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCreation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCreation.UseVisualStyleBackColor = true;
            this.buttonCreation.Click += new System.EventHandler(this.ButtonCreation_Click);
            // 
            // buttonDash
            // 
            this.buttonDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDash.FlatAppearance.BorderSize = 0;
            this.buttonDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDash.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDash.ForeColor = System.Drawing.Color.White;
            this.buttonDash.Image = ((System.Drawing.Image)(resources.GetObject("buttonDash.Image")));
            this.buttonDash.Location = new System.Drawing.Point(0, 138);
            this.buttonDash.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonDash.Name = "buttonDash";
            this.buttonDash.Size = new System.Drawing.Size(392, 208);
            this.buttonDash.TabIndex = 100;
            this.buttonDash.Text = "Dashboard";
            this.buttonDash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDash.UseVisualStyleBackColor = true;
            this.buttonDash.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(392, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2235, 1068);
            this.panel2.TabIndex = 5;
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonHome.Location = new System.Drawing.Point(0, 138);
            this.ButtonHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(392, 115);
            this.ButtonHome.TabIndex = 1;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(392, 138);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 138);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.HeaderPanel.Controls.Add(this.KitBoxHeader);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(392, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(4303, 138);
            this.HeaderPanel.TabIndex = 1;
            // 
            // KitBoxHeader
            // 
            this.KitBoxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.KitBoxHeader.AutoSize = true;
            this.KitBoxHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.KitBoxHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KitBoxHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(97)))), ((int)(((byte)(24)))));
            this.KitBoxHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KitBoxHeader.Location = new System.Drawing.Point(1980, 35);
            this.KitBoxHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KitBoxHeader.Name = "KitBoxHeader";
            this.KitBoxHeader.Size = new System.Drawing.Size(209, 69);
            this.KitBoxHeader.TabIndex = 0;
            this.KitBoxHeader.Text = "KitBox";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(97)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(392, 2877);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4303, 108);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(97)))), ((int)(((byte)(24)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(97)))), ((int)(((byte)(24)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(75)))), ((int)(((byte)(19)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(8962, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 106;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(5260, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CopyRight Reserved";
            // 
            // homePage3
            // 
            this.homePage3.AutoSize = true;
            this.homePage3.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePage3.Location = new System.Drawing.Point(392, 1860);
            this.homePage3.Margin = new System.Windows.Forms.Padding(0);
            this.homePage3.Name = "homePage3";
            this.homePage3.Size = new System.Drawing.Size(4303, 1570);
            this.homePage3.TabIndex = 6;
            // 
            // creation2
            // 
            this.creation2.AllowDrop = true;
            this.creation2.Dock = System.Windows.Forms.DockStyle.Top;
            this.creation2.Location = new System.Drawing.Point(392, 138);
            this.creation2.Margin = new System.Windows.Forms.Padding(0);
            this.creation2.Name = "creation2";
            this.creation2.Size = new System.Drawing.Size(4303, 1722);
            this.creation2.TabIndex = 5;
            this.creation2.Visible = false;
            // 
            // cartPage1
            // 
            this.cartPage1.Location = new System.Drawing.Point(615, 250);
            this.cartPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartPage1.Name = "cartPage1";
            this.cartPage1.Size = new System.Drawing.Size(3133, 1733);
            this.cartPage1.TabIndex = 7;
            this.cartPage1.Visible = false;
            // 
            // aboutUs1
            // 
            this.aboutUs1.AutoSize = true;
            this.aboutUs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.aboutUs1.Location = new System.Drawing.Point(650, 350);
            this.aboutUs1.Name = "aboutUs1";
            this.aboutUs1.Size = new System.Drawing.Size(2750, 1484);
            this.aboutUs1.TabIndex = 8;
            this.aboutUs1.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(4695, 2985);
            this.Controls.Add(this.aboutUs1);
            this.Controls.Add(this.cartPage1);
            this.Controls.Add(this.homePage3);
            this.Controls.Add(this.creation2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SidePanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(9744, 6083);
            this.MinimumSize = new System.Drawing.Size(3653, 2158);
            this.Name = "Dashboard";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SidePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label KitBoxHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.Button buttonCreation;
        private System.Windows.Forms.Button buttonDash;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private HomePage homePage3;
        private Creation creation2;
        private CartPage cartPage1;
        private AboutUs aboutUs1;
    }
}
