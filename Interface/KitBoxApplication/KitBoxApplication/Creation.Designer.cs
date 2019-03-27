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
            this.standartCreation = new System.Windows.Forms.CheckBox();
            this.completeCreation = new System.Windows.Forms.CheckBox();
            this.creationExplanation1 = new KitBoxApplication.CreationExplanation();
            this.boxCreationScratch1 = new KitBoxApplication.BoxCreationScratch();
            this.boxStandard2 = new KitBoxApplication.BoxStandard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(339, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Composition of the cabinet";
            // 
            // standartCreation
            // 
            this.standartCreation.Appearance = System.Windows.Forms.Appearance.Button;
            this.standartCreation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.standartCreation.Location = new System.Drawing.Point(465, 49);
            this.standartCreation.Name = "standartCreation";
            this.standartCreation.Size = new System.Drawing.Size(127, 65);
            this.standartCreation.TabIndex = 16;
            this.standartCreation.Text = "Creation from standard dimensions";
            this.standartCreation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.standartCreation.UseVisualStyleBackColor = true;
            this.standartCreation.CheckedChanged += new System.EventHandler(this.standartCreationAppear);
            // 
            // completeCreation
            // 
            this.completeCreation.Appearance = System.Windows.Forms.Appearance.Button;
            this.completeCreation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.completeCreation.Location = new System.Drawing.Point(253, 49);
            this.completeCreation.Name = "completeCreation";
            this.completeCreation.Size = new System.Drawing.Size(127, 65);
            this.completeCreation.TabIndex = 15;
            this.completeCreation.Text = "Total Creation";
            this.completeCreation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.completeCreation.UseVisualStyleBackColor = true;
            this.completeCreation.CheckedChanged += new System.EventHandler(this.completeCreationAppear);
            // 
            // creationExplanation1
            // 
            this.creationExplanation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.creationExplanation1.Location = new System.Drawing.Point(158, 118);
            this.creationExplanation1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.creationExplanation1.Name = "creationExplanation1";
            this.creationExplanation1.Size = new System.Drawing.Size(525, 419);
            this.creationExplanation1.TabIndex = 24;
            // 
            // boxCreationScratch1
            // 
            this.boxCreationScratch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.boxCreationScratch1.Location = new System.Drawing.Point(8, 118);
            this.boxCreationScratch1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.boxCreationScratch1.Name = "boxCreationScratch1";
            this.boxCreationScratch1.Size = new System.Drawing.Size(906, 590);
            this.boxCreationScratch1.TabIndex = 23;
            this.boxCreationScratch1.Visible = false;
            // 
            // boxStandard2
            // 
            this.boxStandard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.boxStandard2.Font = new System.Drawing.Font("Century Gothic", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStandard2.Location = new System.Drawing.Point(8, 118);
            this.boxStandard2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.boxStandard2.MinimumSize = new System.Drawing.Size(156, 0);
            this.boxStandard2.Name = "boxStandard2";
            this.boxStandard2.Size = new System.Drawing.Size(906, 590);
            this.boxStandard2.TabIndex = 22;
            this.boxStandard2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.creationExplanation1);
            this.panel1.Controls.Add(this.completeCreation);
            this.panel1.Controls.Add(this.boxCreationScratch1);
            this.panel1.Controls.Add(this.standartCreation);
            this.panel1.Controls.Add(this.boxStandard2);
            this.panel1.Location = new System.Drawing.Point(180, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 712);
            this.panel1.TabIndex = 25;
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Creation";
            this.Size = new System.Drawing.Size(1281, 722);
            this.Load += new System.EventHandler(this.Creation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox standartCreation;
        private System.Windows.Forms.CheckBox completeCreation;
        private BoxStandard boxStandard2;
        private BoxCreationScratch boxCreationScratch1;
        private CreationExplanation creationExplanation1;
        private System.Windows.Forms.Panel panel1;
    }
}
