using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormPanel = System.Windows.Forms.Panel;
using System.Data.OleDb;
using System.IO;
using KitBoxSourceCode;
using System.ComponentModel;
using System.Linq;

namespace KitBoxApplication
{
    public partial class BoxCreationScratch : UserControl
    {

        private int increment = 1;

        public BoxCreationScratch()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = false;

            // enables design of tabheader
            this.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabPageBox1_DrawItem);

            EnablePage(tabPageBox2, false);
            EnablePage(tabPageBox3, false);
            EnablePage(tabPageBox4, false);
            EnablePage(tabPageBox5, false);
            EnablePage(tabPageBox6, false);
            EnablePage(tabPageBox7, false);

            // radio buttons in same group added to same function - group : --panelYesNoIf1--
            radioButtonYes1.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo1.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYes2.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo2.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf3--
            radioButtonYes3.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo3.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf4--
            radioButtonNo4.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo4.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf5--
            radioButtonYes5.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo5.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf6--
            radioButtonYes6.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo6.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);

            // radio buttons in same group added to same function - group : --panelYesNoIf7--
            radioButtonYes7.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);
            radioButtonNo7.CheckedChanged += new EventHandler(RadioButtonsYesNo_CheckedChangedPanel1);
        }

        OleDbCommand cmd = new OleDbCommand(); //cmd for command
        OleDbConnection cn = new OleDbConnection();  // cn for connection
        OleDbDataReader dr;
        
        private void BoxCreationScratch_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= " + GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Database\DB_Lespieces.accdb;";
            cmd.Connection = cn;
            LoadDataAngleColor();
            LoadDataWidth();
            LoadDataDepth();
            LoadDataBoxHeight();
            LoadDataDoor();
            LoadDataBoxColor();
        }

        // function model for loadData
        private void LoadDataGeneral(System.Windows.Forms.ComboBox[] m, string n)
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

        // function model for height loaddata
        private void LoadDataGeneralForHeight(System.Windows.Forms.ComboBox[] m, string n)
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
                            string column = dr[0].ToString();
                            int internalHeight = int.Parse(column);
                            int externalHeigth = internalHeight + 4;
                            i.Items.Add(externalHeigth.ToString());
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
            System.Windows.Forms.ComboBox[] list = { comboBoxColorAngles };
            var count = numericUpDownQuantity.Value;
            LoadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'COR%' AND référence NOT LIKE '%DEC' " + "AND division LIKE '" + count + "'");
        }

        // Loading Width data from data base if cabinet without doors
        private void LoadDataWidth()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxWidth,
            };
            LoadDataGeneral(list, "SELECT DISTINCT largeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAG%' ");
        }

        // Loading Width data from data base if cabinet with doors
        private void LoadDataWidthDoor()
        {
            System.Windows.Forms.ComboBox[] listprov = {
                comboBoxWidth,
            };
            LoadDataGeneral(listprov, "SELECT DISTINCT largeur FROM Piece WHERE référence LIKE 'PAR%100BL' OR référence LIKE 'PAR%120BL' OR référence LIKE 'PAR%80BL' OR référence LIKE 'PAR%62BL'");
        }

        // Loading Depth data from data base
        private void LoadDataDepth()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxDepth,
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
            LoadDataGeneralForHeight(list, "SELECT DISTINCT hauteur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAH%' ");
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
        private void NumericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDownQuantity.Value);
            if (count > 0)
            {
                EnablePage(tabPageBox2, false);
                panelShelf2.Visible = false;

                if (count == 1)
                {
                    // resets radiobutton only if
                    radioButtonNo2.Checked = true;
                    // resets comboBox selected items
                    comboBoxColor2.SelectedItem = null;
                    comboBoxHeight2.SelectedItem = null;
                    
                    EnablePage(tabPageBox3, false);
                    EnablePage(tabPageBox4, false);
                    EnablePage(tabPageBox5, false);
                    EnablePage(tabPageBox6, false);
                    EnablePage(tabPageBox7, false);
                }

                if (count > 1)
                {
                    EnablePage(tabPageBox2, true);
                    EnablePage(tabPageBox3, false);

                    panelShelf2.Visible = true;
                    panelShelf3.Visible = false;

                    if (count == 2)
                    {
                        // resets radiobutton only if
                        radioButtonNo3.Checked = true;
                        // resets comboBox selected items
                        comboBoxColor3.SelectedItem = null;
                        comboBoxHeight3.SelectedItem = null;
                    }

                    if (count > 2)
                    {
                        EnablePage(tabPageBox3, true);
                        EnablePage(tabPageBox4, false);

                        panelShelf3.Visible = true;
                        panelShelf4.Visible = false;

                        if (count == 3)
                        {
                            // resets radiobutton only if
                            radioButtonNo4.Checked = true;
                            // resets comboBox selected items
                            comboBoxColor4.SelectedItem = null;
                            comboBoxHeight4.SelectedItem = null;
                        }

                        if (count > 3)
                        {
                            EnablePage(tabPageBox4, true);
                            EnablePage(tabPageBox5, false);

                            panelShelf4.Visible = true;
                            panelShelf5.Visible = false;

                            if (count == 4)
                            {
                                // resets radiobutton only if
                                radioButtonNo5.Checked = true;
                                // resets comboBox selected items
                                comboBoxColor5.SelectedItem = null;
                                comboBoxHeight5.SelectedItem = null;
                            }

                            if (count > 4)
                            {
                                EnablePage(tabPageBox5, true);
                                EnablePage(tabPageBox6, false);

                                panelShelf5.Visible = true;
                                panelShelf6.Visible = false;

                                if (count == 5)
                                {
                                    // resets radiobutton only if
                                    radioButtonNo6.Checked = true;
                                    // resets comboBox selected items
                                    comboBoxColor6.SelectedItem = null;
                                    comboBoxHeight6.SelectedItem = null;
                                }

                                if (count > 5)
                                {
                                    EnablePage(tabPageBox6, true);
                                    EnablePage(tabPageBox7, false); 
                                    
                                    panelShelf6.Visible = true;
                                    panelShelf7.Visible = false;

                                    if (count == 6)
                                    {
                                        // resets radiobutton only if
                                        radioButtonNo7.Checked = true;
                                        // resets comboBox selected items
                                        comboBoxColor7.SelectedItem = null;
                                        comboBoxHeight7.SelectedItem = null;
                                    }

                                    if (count > 6)
                                    {
                                        EnablePage(tabPageBox7, true);
                                        panelShelf7.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // general function to remove door image
        private void RemoveDoor(ComboBox color, WinFormPanel shelf)
        {
            if (color.Text == "")
            {
                Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blancNoDoor.png");
                shelf.BackgroundImage = myImage;
            }
            else
            {
                string colorBox = color.Text;
                Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + colorBox + "NoDoor.png");
                shelf.BackgroundImage = myImage;
            }
        }

        /* for every radiobutton
         * if yes selected -> shows door material choice
         * if atleast one of the door radiobuttons is selected as yes, loads certain set of values for the width of the cabinet
         * if all door radiobuttons is selected as no, loads other set of values for the width of cabinet
         */

        // function to add door or not to box 1
        private void RadioButtonsYesNo_CheckedChangedPanel1(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes1)
                {
                    panelDoorMaterial1.Visible = true;
                    if (radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidthDoor();
                        comboBoxWidth.Text = "";
                    }
                }
                else if (((RadioButton)sender) == radioButtonNo1)
                {
                    panelDoorMaterial1.Visible = false;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidth();
                    }
                    comboBoxDoorMat1.SelectedItem = null;
                    RemoveDoor(comboBoxColor1, panelShelf1);
                }
            }
        }

        // function to add door or not to box 2
        private void RadioButtonsYesNo_CheckedChangedPanel2(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes2)
                {
                    panelDoorMaterial2.Visible = true;
                    if (radioButtonNo1.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidthDoor();
                        comboBoxWidth.Text = "";
                    }
                }
                else if (((RadioButton)sender) == radioButtonNo2)
                {
                    panelDoorMaterial2.Visible = false;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidth();
                    }
                    comboBoxDoorMat2.SelectedItem = null;
                    RemoveDoor(comboBoxColor2, panelShelf2);
                }
            }
        }

        // function to add door or not to box 3
        private void RadioButtonsYesNo_CheckedChangedPanel3(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes3)
                {
                    panelDoorMaterial3.Visible = true;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidthDoor();
                        comboBoxWidth.Text = "";
                    }
                }
                else if (((RadioButton)sender) == radioButtonNo3)
                {
                    panelDoorMaterial3.Visible = false;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidth();
                    }
                    comboBoxDoorMat3.SelectedItem = null;
                    RemoveDoor(comboBoxColor3, panelShelf3);
                }
            }
        }

        // function to add door or not to box 4
        private void RadioButtonsYesNo_CheckedChangedPanel4(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes4)
                {
                    panelDoorMaterial4.Visible = true;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidthDoor();
                        comboBoxWidth.Text = "";
                    }
                }
                else if (((RadioButton)sender) == radioButtonNo4)
                {
                    panelDoorMaterial4.Visible = false;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidth();
                    }
                    comboBoxDoorMat4.SelectedItem = null;
                    RemoveDoor(comboBoxColor4, panelShelf4);
                }
            }
        }

        // function to add door or not to box 5
        private void RadioButtonsYesNo_CheckedChangedPanel5(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes5)
                {
                    panelDoorMaterial5.Visible = true;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidthDoor();
                        comboBoxWidth.Text = "";
                    }
                }
                else if (((RadioButton)sender) == radioButtonNo5)
                {
                    panelDoorMaterial5.Visible = false;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidth();
                    }
                    comboBoxDoorMat5.SelectedItem = null;
                    RemoveDoor(comboBoxColor5, panelShelf5);
                }
            }
        }

        // function to add door or not to box 6
        private void RadioButtonsYesNo_CheckedChangedPanel6(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes6)
                {
                    panelDoorMaterial6.Visible = true;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidthDoor();
                        comboBoxWidth.Text = "";
                    }
                }
                else if (((RadioButton)sender) == radioButtonNo6)
                {
                    panelDoorMaterial6.Visible = false;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidth();
                    }
                    comboBoxDoorMat6.SelectedItem = null;
                    RemoveDoor(comboBoxColor6, panelShelf6);
                }
            }
        }

        // function to add door or not to box 7
        private void RadioButtonsYesNo_CheckedChangedPanel7(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes7)
                {
                    panelDoorMaterial7.Visible = true;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked)
                    {
                        LoadDataWidthDoor();
                        comboBoxWidth.Text = "";
                    }
                }
                else if (((RadioButton)sender) == radioButtonNo7)
                {
                    panelDoorMaterial7.Visible = false;
                    if (radioButtonNo1.Checked && radioButtonNo2.Checked && radioButtonNo3.Checked && radioButtonNo4.Checked && radioButtonNo5.Checked && radioButtonNo6.Checked && radioButtonNo7.Checked)
                    {
                        LoadDataWidth();
                    }
                    comboBoxDoorMat7.SelectedItem = null;
                    RemoveDoor(comboBoxColor7, panelShelf7);
                }
            }
        }

        // function to get relative path to a file
        private string GetRelativePath(string directory)
        {
            char[] test1 = "\\".ToCharArray();
            string[] test = directory.Split(test1);
            string root = test[0];
            string user = test[1];
            string namePC = test[2];
            string dir = root + "\\" + user + "\\" + namePC + "\\";
            return dir;
        }

        // general function to add color to box cabinet image
        private void AddColorOrDoorToBox(ComboBox box, ComboBox door, WinFormPanel shelf)
        {
            string color = box.Text;
            // in case color reset to null (initial state is white)
            if (color == "")
            {
                color = "blanc";
            }
            if (door.Text == "")
            {
                Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                shelf.BackgroundImage = myImage;
            }
            else
            {
                string doorMat = door.Text;
                Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                shelf.BackgroundImage = myImage;
            }
        }

        // function to change color of boxPanel1
        private void ComboBoxColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor1, comboBoxDoorMat1, panelShelf1);
        }

        // function to change color of boxPanel2
        private void ComboBoxColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor2, comboBoxDoorMat2, panelShelf2);
        }

        // function to change color of boxPanel3
        private void ComboBoxColor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor3, comboBoxDoorMat3, panelShelf3);
        }

        // function to change color of boxPanel4
        private void ComboBoxColor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor4, comboBoxDoorMat4, panelShelf4);
        }

        // function to change color of boxPanel5
        private void ComboBoxColor5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor5, comboBoxDoorMat5, panelShelf5);
        }

        // function to change color of boxPanel6
        private void ComboBoxColor6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor6, comboBoxDoorMat6, panelShelf6);
        }

        // function to change color of boxPanel7
        private void ComboBoxColor7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor7, comboBoxDoorMat7, panelShelf7);
        }
       
        // function to change color of door material of box 1
        private void ComboBoxDoorMat1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            AddColorOrDoorToBox(comboBoxColor1, comboBoxDoorMat1, panelShelf1);
        }

        // function to change color of door material of box 2
        private void ComboBoxDoorMat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor2, comboBoxDoorMat2, panelShelf2);
        }

        // function to change color of door material of box 3
        private void ComboBoxDoorMat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor3, comboBoxDoorMat3, panelShelf3);
        }

        // function to change color of door material of box 4
        private void ComboBoxDoorMat4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor4, comboBoxDoorMat4, panelShelf4);
        }

        // function to change color of door material of box 5
        private void ComboBoxDoorMat5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor5, comboBoxDoorMat5, panelShelf5);
        }

        // function to change color of door material of box 6
        private void ComboBoxDoorMat6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor6, comboBoxDoorMat6, panelShelf6);
        }

        // function to change color of door material of box 7
        private void ComboBoxDoorMat7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorOrDoorToBox(comboBoxColor7, comboBoxDoorMat7, panelShelf7);
        }

        // -- Method to design tabheader
        private void TabPageBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl.TabPages[e.Index];
            Color col = Color.FromArgb(27, 29, 33);

            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            Font font = new Font("Century Gothic", 12, FontStyle.Bold);

            Color myColor = Color.FromArgb(60, 120, 138);
            SolidBrush myBrush = new SolidBrush(myColor);

            SizeF sz = e.Graphics.MeasureString(tabControl.TabPages[e.Index].Text, font);

            // changes color of text when tab is selected
            if (tabControl.SelectedIndex == e.Index)
            {
                myColor = Color.FromArgb(230, 232, 237);
                myBrush = new SolidBrush(myColor);
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font, myBrush, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);
            }
            e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font, myBrush, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

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
                tabControl.TabPages.Add(page);
                hiddenPages.Remove(page);
            }
            else
            {
                tabControl.TabPages.Remove(page);
                hiddenPages.Add(page);
            }
        }

        // function to add newly configured cabinet to the cart 
        private void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            //If the cart is empty, create it
            if (CartPage.Cart == null)
            {
                CartPage.Cart = new Cart();
            }

            try
            {
                int qty = (int)numericUpDownQuantity.Value;
                int totalHeight = ActualHeight();
                int width = int.Parse(comboBoxWidth.SelectedItem.ToString());
                int depth = int.Parse(comboBoxDepth.SelectedItem.ToString());
                string angleColor = comboBoxColorAngles.SelectedItem.ToString();
                List<int> height = new List<int>
                {
                    (qty >= 1) ? int.Parse(comboBoxHeight1.SelectedItem.ToString()): 0,
                    (qty >= 2) ? int.Parse(comboBoxHeight2.SelectedItem.ToString()): 0,
                    (qty >= 3) ? int.Parse(comboBoxHeight3.SelectedItem.ToString()): 0,
                    (qty >= 4) ? int.Parse(comboBoxHeight4.SelectedItem.ToString()): 0,
                    (qty >= 5) ? int.Parse(comboBoxHeight5.SelectedItem.ToString()): 0,
                    (qty >= 6) ? int.Parse(comboBoxHeight6.SelectedItem.ToString()): 0,
                    (qty >= 7) ? int.Parse(comboBoxHeight7.SelectedItem.ToString()): 0
                };
                List<string> color = new List<string>
                {
                    (qty >= 1) ? comboBoxColor1.SelectedItem.ToString(): null,
                    (qty >= 2) ? comboBoxColor2.SelectedItem.ToString(): null,
                    (qty >= 3) ? comboBoxColor3.SelectedItem.ToString(): null,
                    (qty >= 4) ? comboBoxColor4.SelectedItem.ToString(): null,
                    (qty >= 5) ? comboBoxColor5.SelectedItem.ToString(): null,
                    (qty >= 6) ? comboBoxColor6.SelectedItem.ToString(): null,
                    (qty >= 7) ? comboBoxColor7.SelectedItem.ToString(): null
                };
                List<string> door = new List<string>
                {
                    (radioButtonYes1.Checked) ? comboBoxDoorMat1.SelectedItem.ToString(): null,
                    (radioButtonYes2.Checked) ? comboBoxDoorMat2.SelectedItem.ToString(): null,
                    (radioButtonYes3.Checked) ? comboBoxDoorMat3.SelectedItem.ToString(): null,
                    (radioButtonYes4.Checked) ? comboBoxDoorMat4.SelectedItem.ToString(): null,
                    (radioButtonYes5.Checked) ? comboBoxDoorMat5.SelectedItem.ToString(): null,
                    (radioButtonYes6.Checked) ? comboBoxDoorMat6.SelectedItem.ToString(): null,
                    (radioButtonYes7.Checked) ? comboBoxDoorMat7.SelectedItem.ToString(): null
                };

                List<Object> list = new List<Object> { qty, totalHeight, height, width, depth, angleColor, color, door };

                panel2.Visible = true;
                progressBar.Value = 0;

                loadingLabel.Text = "Status : Creating cabinet : Floor";

                backgroundWorker1.RunWorkerAsync(list);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please enter all the necessary information\n");
            }
        }

        /* enables click on the panelshelf images
         * when certain shelf clicked, caracteristics of that box is shown
         */
        private void PanelShelf1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox1);
        }

        private void PanelShelf2_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox2);
        }

        private void PanelShelf3_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox3);
        }

        private void PanelShelf4_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox4);
        }

        private void PanelShelf5_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox5);
        }

        private void PanelShelf6_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox6);
        }

        private void PanelShelf7_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox7);
        }

        /* function to calculate actual height of Cabinet
         * used to verify cabinet doesn't exceeds max height avalaible
         * used to change color of actual height label to show it exceeds
         */
        private int ActualHeight()
        {
            List<int> heights = Enumerable.Repeat<int>(0, 7).ToList();

            heights = new List<int>
            {
                (comboBoxHeight1.Text != "") ? int.Parse(comboBoxHeight1.Text.ToString()): 0,
                (comboBoxHeight2.Text != "") ? int.Parse(comboBoxHeight2.Text.ToString()): 0,
                (comboBoxHeight3.Text != "") ? int.Parse(comboBoxHeight3.Text.ToString()): 0,
                (comboBoxHeight4.Text != "") ? int.Parse(comboBoxHeight4.Text.ToString()): 0,
                (comboBoxHeight5.Text != "") ? int.Parse(comboBoxHeight5.Text.ToString()): 0,
                (comboBoxHeight6.Text != "") ? int.Parse(comboBoxHeight6.Text.ToString()): 0,
                (comboBoxHeight7.Text != "") ? int.Parse(comboBoxHeight7.Text.ToString()): 0
            };

            int total = 0;

            foreach(int i in heights)
            {
                total += i;
            }

            return total;
        }

        // changes the color of the actual height label depending on the sum of the comboBoxheight values
        private void ComboBoxHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = ActualHeight();
            labelActualHeight.Text = "Actual height of Cabinet :  " + total.ToString() + " cm";
            if (total > 375)
            {
                labelActualHeight.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            }
            else
            {
                labelActualHeight.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
            }
        }

        // function to reset every combobox, numericupdown, radiobutton and checkbox to his initial state
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            numericUpDownQuantity.Value = 1;
            comboBoxColor1.SelectedItem = null;
            comboBoxDepth.SelectedItem = null;
            comboBoxColorAngles.SelectedItem = null;
            comboBoxHeight1.SelectedItem = null;
            comboBoxWidth.SelectedItem = null;
            radioButtonNo1.Checked = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            worker.ReportProgress(5);

            Cabinet cabinet = new Cabinet();

            List<Object> list = e.Argument as List<Object>;
            int qty = (int)list[0];
            int totalHeight = (int)list[1];
            List<int> height = (List<int>)list[2];
            int width = (int)list[3];
            int depth = (int)list[4];
            string angleColor = (string)list[5];
            List<string> color = (List<string>)list[6];
            List<string> door = (List<string>)list[7];



            if (totalHeight > 375)
            {
                MessageBox.Show("You have exceeded the max height as it was shown under max height (red)");
                MessageBox.Show("Please change the height of some boxes until actual height is green!");
            }
            else
            {
                try
                {
                    int nbr = qty + 1;

                    if (qty >= 1)
                    {
                        //int progress = 100 / nbr * 1;
                        worker.ReportProgress(100 / nbr * 1);
                        cabinet.AddStorageBox(new CabinetFloor(height[0], width, depth, door[0], panelCol: color[0]));
                        if (qty >= 2)
                        {
                            worker.ReportProgress(100 / nbr * 2);
                            incrementer();
                            cabinet.AddStorageBox(new CabinetFloor(height[1], width, depth, door[1], panelCol: color[1]));
                            if (qty >= 3)
                            {
                                worker.ReportProgress(100 / nbr * 3);
                                incrementer();
                                cabinet.AddStorageBox(new CabinetFloor(height[2], width, depth, door[2], panelCol: color[2])); 
                                if (qty >= 4)
                                {
                                    worker.ReportProgress(100 / nbr * 4);
                                    incrementer();
                                    cabinet.AddStorageBox(new CabinetFloor(height[3], width, depth, door[3], panelCol: color[3]));
                                    if (qty >= 5)
                                    {
                                        worker.ReportProgress(100 / nbr * 5);
                                        incrementer();
                                        cabinet.AddStorageBox(new CabinetFloor(height[4], width, depth, door[4], panelCol: color[4]));
                                        if (qty >= 6)
                                        {
                                            worker.ReportProgress(100 / nbr * 6);
                                            incrementer();
                                            cabinet.AddStorageBox(new CabinetFloor(height[5], width, depth, door[5], panelCol: color[5]));
                                            if (qty >= 7)
                                            {
                                                worker.ReportProgress(100 / nbr * 7);
                                                incrementer();
                                                cabinet.AddStorageBox(new CabinetFloor(height[6], width, depth, door[6], panelCol: color[6]));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    worker.ReportProgress(100);
                    
                    cabinet.AddScratchAngles(angleColor);

                    CartPage.Cart.AddToCart(cabinet);

                    MessageBox.Show("This cabinet has been added to the cart succesfully!");
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please enter all the necessary information\n");
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == 100)
            {
                incrementLabel.Text = "";
                loadingLabel.Text = "Status : Done!";
            }
            else
            {
                incrementLabel.Text = increment.ToString();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panel2.Visible = false;
            incrementLabel.Text = "0";
            increment = 1;
            progressBar.Value = 0;
        }

        private void incrementer()
        {
            increment++;
        }
    }
}
