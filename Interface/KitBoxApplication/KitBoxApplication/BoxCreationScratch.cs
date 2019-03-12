using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBoxApplication
{
    public partial class BoxCreationScratch : UserControl
    {
        public BoxCreationScratch()
        {
            InitializeComponent();

            // enables design of tabheader
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabPageBox1_DrawItem);
           
            EnablePage(tabPageBox2, false);
            EnablePage(tabPageBox3, false);
            EnablePage(tabPageBox4, false);
            EnablePage(tabPageBox5, false);
            EnablePage(tabPageBox6, false);
            EnablePage(tabPageBox7, false);

            
            
        }   

        // -- Method to design tabheader 
        private void tabPageBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            Color col = Color.FromArgb(27, 29, 33);
       
            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);
            
            Font font = new Font("Century Gothic", 12, FontStyle.Bold);

            Color myColor = Color.FromArgb(60,120,138);
            SolidBrush myBrush = new SolidBrush(myColor);

            SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, font);
            e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, font, myBrush, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

            Rectangle rect = e.Bounds;
            rect.Offset(0, 2);
            rect.Inflate(0, -2);
            e.Graphics.DrawRectangle(Pens.Transparent, rect);
            e.DrawFocusRectangle();
        }

        private List<TabPage> hiddenPages = new List<TabPage>();

        private void EnablePage(TabPage page, bool enable)
        {
            if (enable)
            {
                tabControl1.TabPages.Add(page);
                hiddenPages.Remove(page);
            }
            else
            {
                tabControl1.TabPages.Remove(page);
                hiddenPages.Add(page);
            }
        }

        

        // function to make tabs visible or not in function of how many boxes has been chosen
        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDownQuantity.Value);
            if (count > 0)
            {
                
                EnablePage(tabPageBox2, false);
                if (count > 1)
                {
                    EnablePage(tabPageBox2, true);
                    EnablePage(tabPageBox3, false);
                    if (count > 2)
                    {
                        EnablePage(tabPageBox3, true);
                        EnablePage(tabPageBox4, false);
                        if (count > 3)
                        {
                            EnablePage(tabPageBox4, true);
                            EnablePage(tabPageBox5, false);
                            if (count > 4)
                            {
                                EnablePage(tabPageBox5, true);
                                EnablePage(tabPageBox6, false);
                                if (count > 5)
                                {
                                    EnablePage(tabPageBox6, true);
                                    EnablePage(tabPageBox7, false);
                                    if (count > 6)
                                    {
                                        EnablePage(tabPageBox7, true);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    
}
