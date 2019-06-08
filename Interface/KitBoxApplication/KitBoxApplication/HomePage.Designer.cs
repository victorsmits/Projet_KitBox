namespace KitBoxApplication
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.slidePic = new System.Windows.Forms.PictureBox();
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
            this.SuspendLayout();
            // 
            // slidePic
            // 
            this.slidePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.slidePic.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidePic.Image = ((System.Drawing.Image)(resources.GetObject("slidePic.Image")));
            this.slidePic.Location = new System.Drawing.Point(0, 0);
            this.slidePic.Name = "slidePic";
            this.slidePic.Size = new System.Drawing.Size(3416, 1200);
            this.slidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slidePic.TabIndex = 4;
            this.slidePic.TabStop = false;
            // 
            // timerSlider
            // 
            this.timerSlider.Enabled = true;
            this.timerSlider.Interval = 5000;
            this.timerSlider.Tick += new System.EventHandler(this.TimerSlider_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(97)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(1193, 1338);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(976, 232);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcoming message! Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauri" +
    "s ut malesuada urna. Sed elementum orci id pretium iaculis. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slidePic);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(3416, 1722);
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Timer timerSlider;
        private System.Windows.Forms.Label label1;
    }
}
