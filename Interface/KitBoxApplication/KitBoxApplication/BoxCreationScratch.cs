using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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

        OleDbCommand cmd = new OleDbCommand(); //cmd for command
        OleDbConnection cn = new OleDbConnection();  // cn for connection
        OleDbDataReader dr;

        CreationScratchInside creationScratch = new CreationScratchInside();

        private void BoxCreationScratch_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Database\DB_Lespieces.accdb;";
            cmd.Connection = cn;
            LoadDataAngleColor();
            LoadDataDepth();
        }

        // Loading Angle Color data from data base 
        private void LoadDataAngleColor()
        {
            comboBoxColorAngles.Items.Clear();
            try
            {
                var count = numericUpDownQuantity.Value;
                string q = "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'COR%' AND référence NOT LIKE '%DEC' " +
                    "AND division LIKE '" + count + "'";
                cmd.CommandText = q; // execution of a SQL instruction
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        comboBoxColorAngles.Items.Add(dr[0].ToString());
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception e)
            {
                cn.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }

<<<<<<< HEAD
        // Loading Angle Color data from data base 
        private void LoadDataAngleColor()
        {
            System.Windows.Forms.ComboBox[] list = {comboBoxColorAngles};
            var count = numericUpDownQuantity.Value;
            loadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'COR%' AND référence LIKE '%DEC' " +
                    "AND division LIKE '" + count + "'");
        }   

||||||| 8331cbe... big update insertion database into scratch creation
        // Loading Angle Color data from data base 
        private void LoadDataAngleColor()
        {
            System.Windows.Forms.ComboBox[] list = { comboBoxColorAngles };
            var count = numericUpDownQuantity.Value;
            loadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'COR%' AND référence LIKE '%DEC' " +
                    "AND division LIKE '" + count + "'");
        }   

=======
>>>>>>> parent of 8331cbe... big update insertion database into scratch creation
        // Loading Depth data from data base 
        private void LoadDataDepth()
        {
<<<<<<< HEAD
            System.Windows.Forms.ComboBox[] list = {
                creationScratchInside1.ComboBoxDepth,
                creationScratchInside2.ComboBoxDepth,
                creationScratchInside3.ComboBoxDepth,
                creationScratchInside4.ComboBoxDepth,
                creationScratchInside5.ComboBoxDepth,
                creationScratchInside6.ComboBoxDepth,
                creationScratchInside7.ComboBoxDepth,
            };
            loadDataGeneral(list, "SELECT DISTINCT profondeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAR%' ");   
        }

        // Loading Height data from data base 
        private void LoadDataHeight()
        {
            System.Windows.Forms.ComboBox[] list = {
                creationScratchInside1.ComboBoxHeight,
                creationScratchInside2.ComboBoxHeight,
                creationScratchInside3.ComboBoxHeight,
                creationScratchInside4.ComboBoxHeight,
                creationScratchInside5.ComboBoxHeight,
                creationScratchInside6.ComboBoxHeight,
                creationScratchInside7.ComboBoxHeight,
            };           
            loadDataGeneral(list, "SELECT DISTINCT hauteur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAH%' ");
        }

        // Loading Width data from data base 
        public void LoadDataWidth()
        {
            System.Windows.Forms.ComboBox[] list = {
                creationScratchInside1.ComboBoxWidth,
                creationScratchInside2.ComboBoxWidth,
                creationScratchInside3.ComboBoxWidth,
                creationScratchInside4.ComboBoxWidth,
                creationScratchInside5.ComboBoxWidth,
                creationScratchInside6.ComboBoxWidth,
                creationScratchInside7.ComboBoxWidth,
            };
            if ((creationScratchInside1.DoorNo == true) && (creationScratchInside2.DoorNo == true) && 
                (creationScratchInside3.DoorNo == true) && (creationScratchInside4.DoorNo == true) &&
                (creationScratchInside5.DoorNo == true) && (creationScratchInside6.DoorNo == true) &&
                (creationScratchInside7.DoorNo == true))
            {
                loadDataGeneral(list, "SELECT DISTINCT largeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAG%' ");
||||||| 8331cbe... big update insertion database into scratch creation
            System.Windows.Forms.ComboBox[] list = {
                creationScratchInside1.ComboBoxDepth,
                creationScratchInside2.ComboBoxDepth,
                creationScratchInside3.ComboBoxDepth,
                creationScratchInside4.ComboBoxDepth,
                creationScratchInside5.ComboBoxDepth,
                creationScratchInside6.ComboBoxDepth,
                creationScratchInside7.ComboBoxDepth,
            };
            loadDataGeneral(list, "SELECT DISTINCT profondeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAR%' ");   
        }

        // Loading Height data from data base 
        private void LoadDataHeight()
        {
            System.Windows.Forms.ComboBox[] list = {
                creationScratchInside1.ComboBoxHeight,
                creationScratchInside2.ComboBoxHeight,
                creationScratchInside3.ComboBoxHeight,
                creationScratchInside4.ComboBoxHeight,
                creationScratchInside5.ComboBoxHeight,
                creationScratchInside6.ComboBoxHeight,
                creationScratchInside7.ComboBoxHeight,
            };           
            loadDataGeneral(list, "SELECT DISTINCT hauteur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAH%' ");
        }

        // Loading Width data from data base 
        private void LoadDataWidth()
        {
            System.Windows.Forms.ComboBox[] list = {
                creationScratchInside1.ComboBoxWidth,
                creationScratchInside2.ComboBoxWidth,
                creationScratchInside3.ComboBoxWidth,
                creationScratchInside4.ComboBoxWidth,
                creationScratchInside5.ComboBoxWidth,
                creationScratchInside6.ComboBoxWidth,
                creationScratchInside7.ComboBoxWidth,
            };
            if ((creationScratchInside1.DoorNo == true) && (creationScratchInside2.DoorNo == true) && 
                (creationScratchInside3.DoorNo == true) && (creationScratchInside4.DoorNo == true) &&
                (creationScratchInside5.DoorNo == true) && (creationScratchInside6.DoorNo == true) &&
                (creationScratchInside7.DoorNo == true))
            {
                loadDataGeneral(list, "SELECT DISTINCT largeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAG%' ");
=======
            
            creationScratch.ComboBoxDepth.Items.Clear();
            comboBoxHeight.Items.Clear();
            try
            {                
                string q = "SELECT DISTINCT profondeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAR%' ";
                cmd.CommandText = q; // execution of a SQL instruction
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        creationScratch.ComboBoxDepth.Items.Add(dr[0].ToString());
                        comboBoxHeight.Items.Add(dr[0].ToString());
                    }
                }
                dr.Close();
                cn.Close();
>>>>>>> parent of 8331cbe... big update insertion database into scratch creation
            }
            catch (Exception e)
            {
                cn.Close();
                MessageBox.Show(e.Message.ToString());
            }
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

        // -- Method to enable the appearance of a tabpage or not
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
                creationScratchInside2.Visible = false;
                if (count > 1)
                {
                    EnablePage(tabPageBox2, true);
                    EnablePage(tabPageBox3, false);
                    creationScratchInside2.Visible = true;
                    creationScratchInside3.Visible = false;
                    if (count > 2)
                    {
                        EnablePage(tabPageBox3, true);
                        EnablePage(tabPageBox4, false);
                        creationScratchInside3.Visible = true;
                        creationScratchInside4.Visible = false;
                        if (count > 3)
                        {
                            EnablePage(tabPageBox4, true);
                            EnablePage(tabPageBox5, false);
                            creationScratchInside4.Visible = true;
                            creationScratchInside5.Visible = false;
                            if (count > 4)
                            {
                                EnablePage(tabPageBox5, true);
                                EnablePage(tabPageBox6, false);
                                creationScratchInside5.Visible = true;
                                creationScratchInside6.Visible = false;
                                if (count > 5)
                                {
                                    EnablePage(tabPageBox6, true);
                                    EnablePage(tabPageBox7, false);
                                    creationScratchInside6.Visible = true;
                                    creationScratchInside7.Visible = false;
                                    if (count > 6)
                                    {
                                        EnablePage(tabPageBox7, true);
                                        creationScratchInside7.Visible = true;                                        
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
