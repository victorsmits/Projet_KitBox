namespace KitBoxApplication
{
    partial class Creation
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
            this.label1 = new System.Windows.Forms.Label();
            this.standardCreation = new System.Windows.Forms.CheckBox();
            this.completeCreation = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.creationExplanation1 = new KitBoxApplication.CreationExplanation();
            this.boxCreationScratch1 = new KitBoxApplication.BoxCreationScratch();
            this.boxStandard2 = new KitBoxApplication.BoxStandard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(904, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Composition of the cabinet";
            // 
            // standardCreation
            // 
            this.standardCreation.Appearance = System.Windows.Forms.Appearance.Button;
            this.standardCreation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.standardCreation.Location = new System.Drawing.Point(1240, 117);
            this.standardCreation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.standardCreation.Name = "standardCreation";
            this.standardCreation.Size = new System.Drawing.Size(339, 155);
            this.standardCreation.TabIndex = 2;
            this.standardCreation.Text = "Creation from standard dimensions";
            this.standardCreation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.standardCreation.UseVisualStyleBackColor = true;
            this.standardCreation.CheckedChanged += new System.EventHandler(this.StandardCreationAppear);
            // 
            // completeCreation
            // 
            this.completeCreation.Appearance = System.Windows.Forms.Appearance.Button;
            this.completeCreation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.completeCreation.Location = new System.Drawing.Point(675, 117);
            this.completeCreation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.completeCreation.Name = "completeCreation";
            this.completeCreation.Size = new System.Drawing.Size(339, 155);
            this.completeCreation.TabIndex = 1;
            this.completeCreation.Text = "Total Creation";
            this.completeCreation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.completeCreation.UseVisualStyleBackColor = true;
            this.completeCreation.CheckedChanged += new System.EventHandler(this.CompleteCreationAppear);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.creationExplanation1);
            this.panel1.Controls.Add(this.completeCreation);
            this.panel1.Controls.Add(this.boxCreationScratch1);
            this.panel1.Controls.Add(this.standardCreation);
            this.panel1.Controls.Add(this.boxStandard2);
            this.panel1.Location = new System.Drawing.Point(480, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2453, 1698);
            this.panel1.TabIndex = 25;
            // 
            // creationExplanation1
            // 
            this.creationExplanation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.creationExplanation1.Location = new System.Drawing.Point(475, 281);
            this.creationExplanation1.Margin = new System.Windows.Forms.Padding(0);
            this.creationExplanation1.Name = "creationExplanation1";
            this.creationExplanation1.Size = new System.Drawing.Size(1499, 1009);
            this.creationExplanation1.TabIndex = 24;
            // 
            // boxCreationScratch1
            // 
            this.boxCreationScratch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.boxCreationScratch1.Location = new System.Drawing.Point(21, 281);
            this.boxCreationScratch1.Margin = new System.Windows.Forms.Padding(0);
            this.boxCreationScratch1.Name = "boxCreationScratch1";
            this.boxCreationScratch1.Size = new System.Drawing.Size(2416, 1407);
            this.boxCreationScratch1.TabIndex = 23;
            this.boxCreationScratch1.Visible = false;
            this.boxCreationScratch1.Load += new System.EventHandler(this.boxCreationScratch1_Load);
            // 
            // boxStandard2
            // 
            this.boxStandard2.AutoSize = true;
            this.boxStandard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.boxStandard2.Font = new System.Drawing.Font("Century Gothic", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStandard2.Location = new System.Drawing.Point(21, 281);
            this.boxStandard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxStandard2.MinimumSize = new System.Drawing.Size(416, 0);
            this.boxStandard2.Name = "boxStandard2";
            this.boxStandard2.Size = new System.Drawing.Size(2416, 1407);
            this.boxStandard2.TabIndex = 22;
            this.boxStandard2.Visible = false;
            // 
            // Creation
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Creation";
            this.Size = new System.Drawing.Size(3416, 1722);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox standardCreation;
        private System.Windows.Forms.CheckBox completeCreation;
        private BoxStandard boxStandard2;
        private BoxCreationScratch boxCreationScratch1;
        private CreationExplanation creationExplanation1;
        private System.Windows.Forms.Panel panel1;
    }
}
