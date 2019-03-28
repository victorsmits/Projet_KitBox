using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormPanel = System.Windows.Forms.Panel;
using System.Data.OleDb;
using System.IO;
using KitBoxSourceCode;

namespace KitBoxApplication
{
    public partial class BoxCreationScratch : UserControl
    {
        public BoxCreationScratch()
        {
            InitializeComponent();

            // enables design of tabheader
            this.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabPageBox1_DrawItem);

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
        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDownQuantity.Value);
            if (count > 0)
            {
                panelInside1.Visible = true;
                EnablePage(tabPageBox2, false);
                panelInside2.Visible = false;
                panelShelf2.Visible = false;
                if (count == 1)
                {
                    // resets radiobutton only if
                    radioButtonNo2.Checked = true;
                    // resets comboBox selected items
                    comboBoxColor2.SelectedItem = null;
                    comboBoxHeight2.SelectedItem = null;
                }
                if (count > 1)
                {
                    EnablePage(tabPageBox2, true);
                    EnablePage(tabPageBox3, false);
                    panelInside2.Visible = true;
                    panelInside3.Visible = false;
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
                        panelInside3.Visible = true;
                        panelInside4.Visible = false;
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
                            panelInside4.Visible = true;
                            panelInside5.Visible = false;
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
                                panelInside5.Visible = true;
                                panelInside6.Visible = false;
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
                                    panelInside6.Visible = true;
                                    panelInside7.Visible = false;
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

        // general function to remove door image
        private void RemoveDoor(ComboBox a, WinFormPanel b)
        {
            if (a.Text == "")
            {
                Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blancNoDoor.png");
                b.BackgroundImage = myImage;
            }
            else
            {
                string color = a.Text;
                Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                b.BackgroundImage = myImage;
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
        private void radioButtonsYesNo_CheckedChangedPanel2(object sender, EventArgs e)
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
        private void radioButtonsYesNo_CheckedChangedPanel3(object sender, EventArgs e)
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
        private void radioButtonsYesNo_CheckedChangedPanel4(object sender, EventArgs e)
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
        private void radioButtonsYesNo_CheckedChangedPanel5(object sender, EventArgs e)
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
        private void radioButtonsYesNo_CheckedChangedPanel6(object sender, EventArgs e)
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
        private void radioButtonsYesNo_CheckedChangedPanel7(object sender, EventArgs e)
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
        private void AddColorToBox(ComboBox box, ComboBox door, WinFormPanel shelf)
        {
            string color = box.Text;
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
        private void comboBoxColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColor1, comboBoxDoorMat1, panelShelf1);
        }

        // function to change color of boxPanel2
        private void comboBoxColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColor2, comboBoxDoorMat2, panelShelf2);
        }

        // function to change color of boxPanel3
        private void comboBoxColor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColor3, comboBoxDoorMat3, panelShelf3);
        }

        // function to change color of boxPanel4
        private void comboBoxColor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColor4, comboBoxDoorMat4, panelShelf4);
        }

        // function to change color of boxPanel5
        private void comboBoxColor5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColor5, comboBoxDoorMat5, panelShelf5);
        }

        // function to change color of boxPanel6
        private void comboBoxColor6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColor6, comboBoxDoorMat6, panelShelf6);
        }

        // function to change color of boxPanel7
        private void comboBoxColor7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColor7, comboBoxDoorMat7, panelShelf7);
        }

        // general function to add door and color door to cabinet image
        private void AddDoorToBox(ComboBox door, ComboBox box, WinFormPanel shelf)
        {
            string doorMat = door.Text;
            if (box.Text == "")
            {
                if (doorMat != "")
                {
                    Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blanc" + doorMat + ".png");
                    shelf.BackgroundImage = myImage;
                }
            }
            else
            {
                string color = box.Text;
                if (doorMat != "")
                {
                    Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat + ".png");
                    shelf.BackgroundImage = myImage;
                }
                else
                {
                    Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                    shelf.BackgroundImage = myImage;
                }
            }
        }

        // function to change color of door material of box 1
        private void comboBoxDoorMat1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMat1, comboBoxColor1, panelShelf1);
        }

        // function to change color of door material of box 2
        private void comboBoxDoorMat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMat2, comboBoxColor2, panelShelf2);
        }

        // function to change color of door material of box 3
        private void comboBoxDoorMat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMat3, comboBoxColor3, panelShelf3);
        }

        // function to change color of door material of box 4
        private void comboBoxDoorMat4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMat4, comboBoxColor4, panelShelf4);
        }

        // function to change color of door material of box 5
        private void comboBoxDoorMat5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMat5, comboBoxColor5, panelShelf5);
        }

        // function to change color of door material of box 6
        private void comboBoxDoorMat6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMat6, comboBoxColor6, panelShelf6);
        }

        // function to change color of door material of box 7
        private void comboBoxDoorMat7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMat7, comboBoxColor7, panelShelf7);
        }

        // -- Method to design tabheader
        private void tabPageBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl.TabPages[e.Index];
            Color col = Color.FromArgb(27, 29, 33);

            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            Font font = new Font("Century Gothic", 12, FontStyle.Bold);

            Color myColor = Color.FromArgb(60, 120, 138);
            SolidBrush myBrush = new SolidBrush(myColor);

            SizeF sz = e.Graphics.MeasureString(tabControl.TabPages[e.Index].Text, font);
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

        /*
         * generating each box with its features 
             */
        private CabinetFloor GenerateBox1()
        {
            int height = Int32.Parse(comboBoxHeight1.SelectedItem.ToString());
            int width = Int32.Parse(comboBoxWidth.SelectedItem.ToString());
            int depth = Int32.Parse(comboBoxDepth.SelectedItem.ToString());
            string color = comboBoxColor1.Text;
            string doorMat = null;
            if (radioButtonYes1.Checked == true)
            {
                doorMat = comboBoxDoorMat1.Text;
            }
            CabinetFloor box = new CabinetFloor(height, width, depth, doorMat, color);
            return box;
        }

        private CabinetFloor GenerateBox2()
        {

            int height = Int32.Parse(comboBoxHeight2.SelectedItem.ToString());
            int width = Int32.Parse(comboBoxWidth.SelectedItem.ToString());
            int depth = Int32.Parse(comboBoxDepth.SelectedItem.ToString());
            string color = comboBoxColor2.Text;
            string doorMat = null;
            if (radioButtonYes2.Checked == true)
            {
                doorMat = comboBoxDoorMat2.Text;
            }
            CabinetFloor box = new CabinetFloor(height, width, depth, doorMat, color);
            return box;
        }

        private CabinetFloor GenerateBox3()
        {

            int height = Int32.Parse(comboBoxHeight3.SelectedItem.ToString());
            int width = Int32.Parse(comboBoxWidth.SelectedItem.ToString());
            int depth = Int32.Parse(comboBoxDepth.SelectedItem.ToString());
            string color = comboBoxColor3.Text;
            string doorMat = null;
            if (radioButtonYes3.Checked == true)
            {
                doorMat = comboBoxDoorMat3.Text;
            }
            CabinetFloor box = new CabinetFloor(height, width, depth, doorMat, color);
            return box;
        }

        private CabinetFloor GenerateBox4()
        {

            int height = Int32.Parse(comboBoxHeight4.SelectedItem.ToString());
            int width = Int32.Parse(comboBoxWidth.SelectedItem.ToString());
            int depth = Int32.Parse(comboBoxDepth.SelectedItem.ToString());
            string color = comboBoxColor4.Text;
            string doorMat = null;
            if (radioButtonYes4.Checked == true)
            {
                doorMat = comboBoxDoorMat4.Text;
            }
            CabinetFloor box = new CabinetFloor(height, width, depth, doorMat, color);
            return box;
        }

        private CabinetFloor GenerateBox5()
        {

            int height = Int32.Parse(comboBoxHeight5.SelectedItem.ToString());
            int width = Int32.Parse(comboBoxWidth.SelectedItem.ToString());
            int depth = Int32.Parse(comboBoxDepth.SelectedItem.ToString());
            string color = comboBoxColor5.Text;
            string doorMat = null;
            if (radioButtonYes5.Checked == true)
            {
                doorMat = comboBoxDoorMat5.Text;
            }
            CabinetFloor box = new CabinetFloor(height, width, depth, doorMat, color);
            return box;
        }

        private CabinetFloor GenerateBox6()
        {

            int height = Int32.Parse(comboBoxHeight6.SelectedItem.ToString());
            int width = Int32.Parse(comboBoxWidth.SelectedItem.ToString());
            int depth = Int32.Parse(comboBoxDepth.SelectedItem.ToString());
            string color = comboBoxColor6.Text;
            string doorMat = null;
            if (radioButtonYes6.Checked == true)
            {
                doorMat = comboBoxDoorMat6.Text;
            }
            CabinetFloor box = new CabinetFloor(height, width, depth, doorMat, color);
            return box;
        }

        private CabinetFloor GenerateBox7()
        {

            int height = Int32.Parse(comboBoxHeight7.SelectedItem.ToString());
            int width = Int32.Parse(comboBoxWidth.SelectedItem.ToString());
            int depth = Int32.Parse(comboBoxDepth.SelectedItem.ToString());
            string color = comboBoxColor7.Text;
            string doorMat = null;
            if (radioButtonYes7.Checked == true)
            {
                doorMat = comboBoxDoorMat7.Text;
            }
            CabinetFloor box = new CabinetFloor(height, width, depth, doorMat, color);
            return box;
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            //If the cart is empty, create it
            if (CartPage.Cart == null)
            {
                CartPage.Cart = new Cart();
            }

            Cabinet cabinet = new Cabinet();

            int totalHeight = ActualHeight();
            if (totalHeight > 375)
            {
                MessageBox.Show("You have exceeded the max height as it was shown under max height (red)");
                MessageBox.Show("Please change the height of some boxes until actual height is green!");
            }
            else
            {
                try
                {
                    int qty = (int)numericUpDownQuantity.Value;

                    if (qty >= 1)
                    {
                        cabinet.AddStorageBox(GenerateBox1());
                        if (qty >= 2)
                        {
                            cabinet.AddStorageBox(GenerateBox2());
                            if (qty >= 3)
                            {
                                cabinet.AddStorageBox(GenerateBox3());
                                if (qty >= 4)
                                {
                                    cabinet.AddStorageBox(GenerateBox4());
                                    if (qty >= 5)
                                    {
                                        cabinet.AddStorageBox(GenerateBox5());
                                        if (qty >= 6)
                                        {
                                            cabinet.AddStorageBox(GenerateBox6());
                                            if (qty >= 7)
                                            {
                                                cabinet.AddStorageBox(GenerateBox7());
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    string angleColor = comboBoxColorAngles.SelectedItem.ToString();
                    cabinet.AddScratchAngles(angleColor);

                    CartPage.Cart.AddToCart(cabinet);

                    MessageBox.Show("This cabinet has been added to the cart succesfully!");
                }
                catch (NullReferenceException except)
                {
                    MessageBox.Show("Please enter all the necessary information\n");
                }
            }  
        }

        private void panelShelf1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox1);
        }

        private void panelShelf2_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox2);
        }

        private void panelShelf3_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox3);
        }

        private void panelShelf4_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox4);
        }

        private void panelShelf5_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox5);
        }

        private void panelShelf6_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox6);
        }

        private void panelShelf7_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageBox7);
        }

        /* function to calculate actual height of Cabinet
         * used to verify cabinet doesn't exceeds max height avalaible
         * used to change color of actual height label to show it exceeds
         */
        private int ActualHeight()
        {
            int height1 = 0;
            int height2 = 0;
            int height3 = 0;
            int height4 = 0;
            int height5 = 0;
            int height6 = 0;
            int height7 = 0;
            if (comboBoxHeight1.Text != "")
            {
                height1 = int.Parse(comboBoxHeight1.Text.ToString());
            }
            if (comboBoxHeight2.Text != "")
            {
                height2 = int.Parse(comboBoxHeight2.Text.ToString());
            }
            if (comboBoxHeight3.Text != "")
            {
                height3 = int.Parse(comboBoxHeight3.Text.ToString());
            }
            if (comboBoxHeight4.Text != "")
            {
                height4 = int.Parse(comboBoxHeight4.Text.ToString());
            }
            if (comboBoxHeight5.Text != "")
            {
                height5 = int.Parse(comboBoxHeight5.Text.ToString());
            }
            if (comboBoxHeight6.Text != "")
            {
                height6 = int.Parse(comboBoxHeight6.Text.ToString());
            }
            if (comboBoxHeight7.Text != "")
            {
                height7 = int.Parse(comboBoxHeight7.Text.ToString());
            }

            int total = height1 + height2 + height3 + height4 + height5 + height6 + height7;
            return total;
        }

        private void comboBoxHeight_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
