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
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabPageBox1_DrawItem);
            
            
          
        }

        private void tabPageBox1_Click(object sender, EventArgs e)
        {

        }        

        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();

        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            tabControl1.Invalidate();
        }
        private void tabPageBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            Color col = Color.FromArgb(27, 29, 33);
            /*
            switch(e.Index)
            {
                case 0:
                    col = Color.Black;
                    break;
                case 1:
                    col = Color.Beige;
                    break;
                case 2:
                    col = Color.Red;
                    break;
                case 3:
                    col = Color.AliceBlue;
                    break;
                case 4:
                    col = Color.Beige;
                    break;
                case 5:
                    col = Color.Red;
                    break;
                case 6:
                    col = Color.Blue;
                    break;
                default:
                    col = Color.Red;
                    break;
            }
            */
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
    }
    
}
