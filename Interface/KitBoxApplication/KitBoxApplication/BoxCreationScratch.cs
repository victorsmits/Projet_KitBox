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
            this.tabPage.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabPage.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabPageBox1_DrawItem);

            EnablePage(tabPageBox2, false);
            EnablePage(tabPageBox3, false);
            EnablePage(tabPageBox4, false);
            EnablePage(tabPageBox5, false);
            EnablePage(tabPageBox6, false);
            EnablePage(tabPageBox7, false);

            // radio buttons in same group added to same function - group : --panelYesNoIf1--
            radioButtonYes1.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo1.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYes2.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo2.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf3--
            radioButtonYes3.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo3.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf4--
            radioButtonNo4.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo4.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf5--
            radioButtonYes5.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo5.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf6--
            radioButtonYes6.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo6.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf7--
            radioButtonYes7.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo7.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChangedPanel1);

        }

        OleDbCommand cmd = new OleDbCommand(); //cmd for command
        OleDbConnection cn = new OleDbConnection();  // cn for connection
        OleDbDataReader dr;

        //CreationScratchInside creationScratch = new CreationScratchInside();

        private void BoxCreationScratch_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Database\DB_Lespieces.accdb;";
            cmd.Connection = cn;
            LoadDataAngleColor();
            LoadDataWidth();
            LoadDataDepth();
            LoadDataBoxHeight();
            LoadDataDoor();
            LoadDataBoxColor();
        }

        // function model for loadData
        public void LoadDataGeneral(System.Windows.Forms.ComboBox[] m, string n)
        {
            foreach (System.Windows.Forms.ComboBox i in m)
            {
                i.Items.Clear();
            }
            try
            {                
                string q = n;
                cmd.CommandText = q; // execution of a SQL instruction
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        foreach (System.Windows.Forms.ComboBox i in m)
                        {
                            i.Items.Add(dr[0].ToString());
                        }
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

        // Loading Angle Color data from data base
        private void LoadDataAngleColor()
        {
            System.Windows.Forms.ComboBox[] list = {comboBoxColorAngles};
            var count = numericUpDownQuantity.Value;
            LoadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'COR%' AND référence NOT LIKE '%DEC' " +"AND division LIKE '" + count + "'");           
        }

        // Loading Width data from data base if cabinet without doors
        private void LoadDataWidth()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxWidth1,
                comboBoxWidth2,
                comboBoxWidth3,
                comboBoxWidth4,
                comboBoxWidth5,
                comboBoxWidth6,
                comboBoxWidth7
            };
            LoadDataGeneral(list, "SELECT DISTINCT largeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAG%' ");
        }

        // Loading Width data from data base if cabinet with doors
        private void LoadDataWidthDoor()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxWidth1,
                comboBoxWidth2,
                comboBoxWidth3,
                comboBoxWidth4,
                comboBoxWidth5,
                comboBoxWidth6,
                comboBoxWidth7
            };
            LoadDataGeneral(list, "SELECT DISTINCT largeur FROM Piece WHERE référence LIKE 'POR%' ");
        }

        // Loading Depth data from data base
        private void LoadDataDepth()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxDepth1,
                comboBoxDepth2,
                comboBoxDepth3,
                comboBoxDepth4,
                comboBoxDepth5,
                comboBoxDepth6,
                comboBoxDepth7
            };
            LoadDataGeneral(list, "SELECT DISTINCT profondeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAR%' ");
        }

        // Loading Height data from data base
        private void LoadDataBoxHeight()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxHeight1,
                comboBoxHeight2,
                comboBoxHeight3,
                comboBoxHeight4,
                comboBoxHeight5,
                comboBoxHeight6,
                comboBoxHeight7
            };
            LoadDataGeneral(list, "SELECT DISTINCT hauteur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAH%' ");
        }

        // Loading Box Color data from data base
        private void LoadDataBoxColor()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxColor1,
                comboBoxColor2,
                comboBoxColor3,
                comboBoxColor4,
                comboBoxColor5,
                comboBoxColor6,
                comboBoxColor7,
            };
            LoadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'PA%' ");
        }

        // Loading Door Material data from data base
        private void LoadDataDoor()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxDoorMat1,
                comboBoxDoorMat2,
                comboBoxDoorMat3,
                comboBoxDoorMat4,
                comboBoxDoorMat5,
                comboBoxDoorMat6,
                comboBoxDoorMat7,
            };
            LoadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'POR%' ");
        }

        // function to make tabs visible or not in function of how many boxes has been chosen
        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDownQuantity.Value);
            if (count > 0)
            {
                panelInside1.Visible = true;
                EnablePage(tabPageBox2, false);
                panelInside2.Visible = false;
                panelShelf2.Visible = false;
                if (count > 1)
                {
                    EnablePage(tabPageBox2, true);
                    EnablePage(tabPageBox3, false);
                    panelInside2.Visible = true;
                    panelInside3.Visible = false;
                    panelShelf2.Visible = true;
                    panelShelf3.Visible = false;
                    if (count > 2)
                    {
                        EnablePage(tabPageBox3, true);
                        EnablePage(tabPageBox4, false);
                        panelInside3.Visible = true;
                        panelInside4.Visible = false;
                        panelShelf3.Visible = true;
                        panelShelf4.Visible = false;
                        if (count > 3)
                        {
                            EnablePage(tabPageBox4, true);
                            EnablePage(tabPageBox5, false);
                            panelInside4.Visible = true;
                            panelInside5.Visible = false;
                            panelShelf4.Visible = true;
                            panelShelf5.Visible = false;
                            if (count > 4)
                            {
                                EnablePage(tabPageBox5, true);
                                EnablePage(tabPageBox6, false);
                                panelInside5.Visible = true;
                                panelInside6.Visible = false;
                                panelShelf5.Visible = true;
                                panelShelf6.Visible = false;
                                if (count > 5)
                                {
                                    EnablePage(tabPageBox6, true);
                                    EnablePage(tabPageBox7, false);
                                    panelInside6.Visible = true;
                                    panelInside7.Visible = false;
                                    panelShelf6.Visible = true;
                                    panelShelf7.Visible = false;
                                    if (count > 6)
                                    {
                                        EnablePage(tabPageBox7, true);
                                        panelInside7.Visible = true;
                                        panelShelf7.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // function to add door or not to box 1
        private void radioButtonsYesNo_CheckedChangedPanel1(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes1)
                {
                    panelDoorMaterial1.Visible = true;
                    LoadDataWidthDoor();
                }
                else if (((RadioButton)sender) == radioButtonNo1)
                {
                    panelDoorMaterial1.Visible = false;
                    LoadDataWidth();
                    comboBoxWidth1.Text = "";
                }
            }
        }

        // function to add door or not to box 2
        private void radioButtonsYesNo_CheckedChangedPanel2(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes2)
                {
                    panelDoorMaterial2.Visible = true;
                    LoadDataWidthDoor();
                }
                else if (((RadioButton)sender) == radioButtonNo2)
                {
                    panelDoorMaterial2.Visible = false;
                    LoadDataWidth();
                    comboBoxWidth2.Text = "";
                }
            }
        }

        // function to add door or not to box 3
        private void radioButtonsYesNo_CheckedChangedPanel3(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes3)
                {
                    panelDoorMaterial3.Visible = true;
                    LoadDataWidthDoor();
                }
                else if (((RadioButton)sender) == radioButtonNo3)
                {
                    panelDoorMaterial3.Visible = false;
                    LoadDataWidth();
                    comboBoxWidth3.Text = "";
                }
            }
        }

        // function to add door or not to box 4
        private void radioButtonsYesNo_CheckedChangedPanel4(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes4)
                {
                    panelDoorMaterial4.Visible = true;
                    LoadDataWidthDoor();
                }
                else if (((RadioButton)sender) == radioButtonNo4)
                {
                    panelDoorMaterial4.Visible = false;
                    LoadDataWidth();
                    comboBoxWidth4.Text = "";
                }
            }
        }

        // function to add door or not to box 5
        private void radioButtonsYesNo_CheckedChangedPanel5(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes5)
                {
                    panelDoorMaterial5.Visible = true;
                    LoadDataWidthDoor();                   
                }
                else if (((RadioButton)sender) == radioButtonNo5)
                {
                    panelDoorMaterial5.Visible = false;
                    LoadDataWidth();
                    comboBoxWidth5.Text = "";
                }
            }
        }

        // function to add door or not to box 6
        private void radioButtonsYesNo_CheckedChangedPanel6(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes6)
                {
                    panelDoorMaterial6.Visible = true;
                    LoadDataWidthDoor();                   
                }
                else if (((RadioButton)sender) == radioButtonNo6)
                {
                    panelDoorMaterial6.Visible = false;
                    LoadDataWidth();
                    comboBoxWidth6.Text = "";
                }
            }
        }

        // function to add door or not to box 7
        private void radioButtonsYesNo_CheckedChangedPanel7(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes7)
                {
                    panelDoorMaterial7.Visible = true;
                    LoadDataWidthDoor();                    
                }
                else if (((RadioButton)sender) == radioButtonNo7)
                {
                    panelDoorMaterial7.Visible = false;
                    LoadDataWidth();
                    comboBoxWidth7.Text = "";
                }
            }
        }

        // function to change color of boxPanel1
        private void comboBoxColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBoxColor1.Text;
            if (comboBoxDoorMat1.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                panelShelf1.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string doorMat = comboBoxDoorMat1.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf1.BackgroundImage = myImage;
            }
        }

        // function to change color of boxPanel2
        private void comboBoxColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBoxColor2.Text;
            if (comboBoxDoorMat2.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                panelShelf2.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string doorMat = comboBoxDoorMat2.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf2.BackgroundImage = myImage;
            }
        }

        // function to change color of boxPanel3
        private void comboBoxColor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBoxColor3.Text;
            if (comboBoxDoorMat3.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                panelShelf3.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string doorMat = comboBoxDoorMat3.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf3.BackgroundImage = myImage;
            }
        }

        // function to change color of boxPanel4
        private void comboBoxColor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBoxColor4.Text;
            if (comboBoxDoorMat4.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                panelShelf4.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string doorMat = comboBoxDoorMat4.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf4.BackgroundImage = myImage;
            }
        }

        // function to change color of boxPanel5
        private void comboBoxColor5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBoxColor5.Text;
            if (comboBoxDoorMat5.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                panelShelf5.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string doorMat = comboBoxDoorMat5.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf5.BackgroundImage = myImage;
            }
        }

        // function to change color of boxPanel6
        private void comboBoxColor6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBoxColor6.Text;
            if (comboBoxDoorMat6.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                panelShelf6.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string doorMat = comboBoxDoorMat6.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf6.BackgroundImage = myImage;
            }
        }

        // function to change color of boxPanel7
        private void comboBoxColor7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBoxColor7.Text;
            if (comboBoxDoorMat7.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                panelShelf7.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string doorMat = comboBoxDoorMat7.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf7.BackgroundImage = myImage;
            }
        }

        // -- Method to design tabheader
        private void tabPageBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabPage.TabPages[e.Index];
            Color col = Color.FromArgb(27, 29, 33);

            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            Font font = new Font("Century Gothic", 12, FontStyle.Bold);

            Color myColor = Color.FromArgb(60,120,138);
            SolidBrush myBrush = new SolidBrush(myColor);

            SizeF sz = e.Graphics.MeasureString(tabPage.TabPages[e.Index].Text, font);
            e.Graphics.DrawString(tabPage.TabPages[e.Index].Text, font, myBrush, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

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
                tabPage.TabPages.Add(page);
                hiddenPages.Remove(page);
            }
            else
            {
                tabPage.TabPages.Remove(page);
                hiddenPages.Add(page);
            }
        }

        // function to change color of door material of box 1
        private void comboBoxDoorMat1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doorMat = comboBoxDoorMat1.Text;
            if (comboBoxColor1.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blanc" + doorMat + ".png");
                panelShelf1.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string color = comboBoxColor1.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf1.BackgroundImage = myImage;
            }
        }

        // function to change color of door material of box 2
        private void comboBoxDoorMat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doorMat = comboBoxDoorMat2.Text;
            if (comboBoxColor2.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blanc" + doorMat + ".png");
                panelShelf2.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string color = comboBoxColor2.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf2.BackgroundImage = myImage;
            }
        }

        // function to change color of door material of box 3
        private void comboBoxDoorMat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doorMat = comboBoxDoorMat3.Text;
            if (comboBoxColor3.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blanc" + doorMat + ".png");
                panelShelf3.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string color = comboBoxColor3.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf3.BackgroundImage = myImage;
            }
        }

        // function to change color of door material of box 4
        private void comboBoxDoorMat4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doorMat = comboBoxDoorMat4.Text;
            if (comboBoxColor4.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blanc" + doorMat + ".png");
                panelShelf4.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string color = comboBoxColor4.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf4.BackgroundImage = myImage;
            }
        }

        // function to change color of door material of box 5
        private void comboBoxDoorMat5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doorMat = comboBoxDoorMat5.Text;
            if (comboBoxColor5.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blanc" + doorMat + ".png");
                panelShelf5.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string color = comboBoxColor5.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf5.BackgroundImage = myImage;
            }
        }

        // function to change color of door material of box 6
        private void comboBoxDoorMat6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doorMat = comboBoxDoorMat6.Text;
            if (comboBoxColor6.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blanc" + doorMat + ".png");
                panelShelf6.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string color = comboBoxColor6.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf6.BackgroundImage = myImage;
            }
        }

        // function to change color of door material of box 7
        private void comboBoxDoorMat7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doorMat = comboBoxDoorMat7.Text;
            if (comboBoxColor7.Text == "")
            {
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blanc" + doorMat + ".png");
                panelShelf7.BackgroundImage = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
            }
            else
            {
                string color = comboBoxColor7.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                panelShelf7.BackgroundImage = myImage;
            }
        }

        //public System.Drawing.Image PanelShelf1
        //{
        //    get { return this.panelShelf1.BackgroundImage; }
        //    set { this.panelShelf1.BackgroundImage = value; }
        //}

        //public string ColorAngles
        //{
        //    get { return labelColorAngles.Text; }
        //    set { labelColorAngles.Text = value; }
        //}

        //public System.Windows.Forms.Panel PanelShelf2
        //{
        //    get { return this.panelShelf2; }
        //    set { this.panelShelf2 = value; }
        //}

        //public System.Drawing.Image PanelShelf3
        //{
        //    get { return this.panelShelf3.BackgroundImage; }
        //    set { this.panelShelf3.BackgroundImage = value; }
        //}

        //public System.Windows.Forms.Panel PanelShelf4
        //{
        //    get { return this.panelShelf4; }
        //    set { this.panelShelf4 = value; }
        //}

        //public System.Windows.Forms.Panel PanelShelf5
        //{
        //    get { return this.panelShelf5; }
        //    set { this.panelShelf5 = value; }
        //}

        //public System.Windows.Forms.Panel PanelShelf6
        //{
        //    get { return this.panelShelf6; }
        //    set { this.panelShelf6 = value; }
        //}

        //public System.Windows.Forms.Panel PanelShelf7
        //{
        //    get { return this.panelShelf7; }
        //    set { this.panelShelf7 = value; }
        //}

        //private void comboBoxColorAngles_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    BoxCreationScratch boxCreationScratch = new BoxCreationScratch();

        //    Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\brunbrun.png");
        //    panelShelf1.BackgroundImage = myImage;
        //    //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources\.phWpbBprWdlGdrG);
        //    labelColorAngles.Text = "hello";
        //}
    }
}
