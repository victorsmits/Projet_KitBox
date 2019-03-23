using System;
using System.Data.OleDb;
using System.Windows.Forms;
using KitBoxSourceCode;
using System.Drawing;
using Newtonsoft.Json.Linq;
using System.IO;

namespace KitBoxApplication
{
    public partial class BoxStandard : UserControl
    {


        public BoxStandard()
        {
            InitializeComponent();

            // Add a "CheckedChanged" event handler for each radio button.
            // Ensure that all radio buttons are in the same groupbox control.

            // radio buttons in same group added to same function - group : --panelYesNoIf1--
            radioButtonYesIf1.CheckedChanged += new EventHandler(radioButtonsYesNoIf1_CheckedChanged);
            radioButtonNoIf1.CheckedChanged += new EventHandler(radioButtonsYesNoIf1_CheckedChanged);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYesIf2.CheckedChanged += new EventHandler(radioButtonsYesNoIf2_CheckedChanged);
            radioButtonNoIf2.CheckedChanged += new EventHandler(radioButtonsYesNoIf2_CheckedChanged);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYesBox1.CheckedChanged += new EventHandler(radioButtonBox1_CheckedChanged);
            radioButtonNoBox1.CheckedChanged += new EventHandler(radioButtonBox1_CheckedChanged);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYesBox2.CheckedChanged += new EventHandler(radioButtonBox2_CheckedChanged);
            radioButtonNoBox2.CheckedChanged += new EventHandler(radioButtonBox2_CheckedChanged);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYesBox3.CheckedChanged += new EventHandler(radioButtonBox3_CheckedChanged);
            radioButtonNoBox3.CheckedChanged += new EventHandler(radioButtonBox3_CheckedChanged);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYesBox4.CheckedChanged += new EventHandler(radioButtonBox4_CheckedChanged);
            radioButtonNoBox4.CheckedChanged += new EventHandler(radioButtonBox4_CheckedChanged);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYesBox5.CheckedChanged += new EventHandler(radioButtonBox5_CheckedChanged);
            radioButtonNoBox5.CheckedChanged += new EventHandler(radioButtonBox5_CheckedChanged);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYesBox6.CheckedChanged += new EventHandler(radioButtonBox6_CheckedChanged);
            radioButtonNoBox6.CheckedChanged += new EventHandler(radioButtonBox6_CheckedChanged);

            // radio buttons in same group added to same function - group : --panelYesNoIf2--
            radioButtonYesBox7.CheckedChanged += new EventHandler(radioButtonBox7_CheckedChanged);
            radioButtonNoBox7.CheckedChanged += new EventHandler(radioButtonBox7_CheckedChanged);
        }

        OleDbCommand cmd = new OleDbCommand(); //cmd for command
        OleDbConnection cn = new OleDbConnection();  // cn for connection
        OleDbDataReader dr;

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

        // Connection to the DB and loading the data into the box
        private void BoxStandard_Load(object sender, EventArgs e)
        {

            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= " + GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Database\DB_Lespieces.accdb;";
            cmd.Connection = cn;
            LoadData();
            LoadDataWidth();
            LoadDataDepth();
            LoadDataAngleColor();
            LoadDataBoxColor();
            LoadDataDoor();
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

        // Loading data from data base
        private void LoadData()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxHeight,
                comboBoxDepth,
                comboBoxWidth,
                comboBoxColorAngles,
                comboBoxColorIf1,
                comboBoxColorS1,
                comboBoxColorS2,
                comboBoxColorS3,
                comboBoxColorS4,
                comboBoxColorS5,
                comboBoxColorS6,
                comboBoxColorS7,
                comboBoxColorSA,
                comboBoxDoorMatBox1,
                comboBoxDoorMatBox2,
                comboBoxDoorMatBox3,
                comboBoxDoorMatBox4,
                comboBoxDoorMatBox5,
                comboBoxDoorMatBox6,
                comboBoxDoorMatBox7
            };
            var count = numericUpDownQuantity.Value;
            LoadDataGeneral(list, "SELECT DISTINCT hauteur FROM Piece WHERE référence LIKE 'COR%' AND référence NOT LIKE '%DEC' " +
                    "AND division LIKE '" + count + "'");
        }

        // Loading Height data from data base
        private void LoadDataHeight()
        {
            System.Windows.Forms.ComboBox[] list = { comboBoxHeight };
            var count = numericUpDownQuantity.Value;
            LoadDataGeneral(list, "SELECT DISTINCT hauteur FROM Piece WHERE référence LIKE 'COR%' AND référence NOT LIKE '%DEC' " + "AND division LIKE '" + count + "'");
        }

        // Loading Width data from data base if cabinet without doors
        private void LoadDataWidth()
        {
            System.Windows.Forms.ComboBox[] list = {comboBoxWidth};
            LoadDataGeneral(list, "SELECT DISTINCT largeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAG%' ");
        }

        // Loading Width data from data base if cabinet with doors
        private void LoadDataWidthDoor()
        {
            System.Windows.Forms.ComboBox[] list = {comboBoxWidth};
            LoadDataGeneral(list, "SELECT DISTINCT largeur FROM Piece WHERE référence LIKE 'POR%' ");
        }

        // Loading Depth data from data base
        private void LoadDataDepth()
        {
            System.Windows.Forms.ComboBox[] list = {comboBoxDepth};
            LoadDataGeneral(list, "SELECT DISTINCT profondeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAR%' ");
        }

        // Loading Angle Color data from data base
        private void LoadDataAngleColor()
        {
            System.Windows.Forms.ComboBox[] list = {comboBoxColorAngles};
            var count = numericUpDownQuantity.Value;
            LoadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'COR%' AND référence NOT LIKE '%DEC' " +
                    "AND division LIKE '" + count + "'");
        }

        // Loading Box Color data from data base
        private void LoadDataBoxColor()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxColorIf1,
                comboBoxColorS1,
                comboBoxColorS2,
                comboBoxColorS3,
                comboBoxColorS4,
                comboBoxColorS5,
                comboBoxColorS6,
                comboBoxColorS7,
                comboBoxColorSA,
            };
            LoadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'PA%' ");
        }

        // Loading Door Material data from data base
        private void LoadDataDoor()
        {
            System.Windows.Forms.ComboBox[] list = {
                comboBoxDoorMatIf1,
                comboBoxDoorMatBox1,
                comboBoxDoorMatBox2,
                comboBoxDoorMatBox3,
                comboBoxDoorMatBox4,
                comboBoxDoorMatBox5,
                comboBoxDoorMatBox6,
                comboBoxDoorMatBox7
            };
            LoadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'POR%' ");
        }

        // function to make appear color choice for all the boxes at once and door choice
        private void checkBoxColorYes_CheckedChanged(object sender, EventArgs e)
        {
            if (panelColorChoiceAll.Visible == true)
            {
                panelColorChoiceAll.Visible = false;
                panelDoorChoiceMultiple.Visible = false;
            }
            else
            {
                panelColorChoiceAll.Visible = true;
                checkBoxColorNo.Checked = false;
                panelDoorChoiceMultiple.Visible = true;
            }
        }

        // function to make appear color choice for all boxes apart and door choice
        private void checkBoxColorNo_CheckedChanged(object sender, EventArgs e)
        {
            if (panelColorChoice.Visible == true)
            {
                panelColorChoice.Visible = false;
                panelDoorChoiceMultiple.Visible = false;
            }
            else
            {
                panelColorChoice.Visible = true;
                checkBoxColorYes.Checked = false;
                panelDoorChoiceMultiple.Visible = true;
            }
        }

        // function applied to number read on the numericUpDown
        // different groups will appear or disappear in function of how many boxes have
        // been chosen
        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDownQuantity.Value);
            LoadDataHeight();
            LoadColorAllSame();
            comboBoxHeight.Text = "";
            if (count == 1)
            {
                // visibility for which panel to show (case1 : 1box, case2: 1+boxes)
                panelColorBoxIf1.Visible = true;
                panelColorBoxIfN1.Visible = false;
                panelDoorChoiceMultiple.Visible = false;
                // resets radiobuttons door for more than one box
                radioButtonNoIf2.Checked = true;    // no door at all
                radioButtonNoBox1.Checked = true;   // no door for box 1 checked
                radioButtonNoBox2.Checked = true;   // no door for box 2 checked
                // shelf image
                panelShelf2.Visible = false;
            }
            else if (count > 1)
            {
                // visibility for which panel to show (case1 : 1box, case2: 1+boxes)
                panelDoorChoiceMultiple.Visible = true;
                panelColorBoxIf1.Visible = false;
                panelColorBoxIfN1.Visible = true;
                // part to make appear features for box color and door
                // color features box 3
                labelColorS3.Visible = false;
                comboBoxColorS3.Visible = false;
                // door features box 3
                labelDoorBox3.Visible = false;
                panelYesNoBox3.Visible = false;
                // resets radiobuttons
                radioButtonNoIf1.Checked = true;
                radioButtonNoBox3.Checked = true;
                // shelf image
                panelShelf2.Visible = true;
                panelShelf3.Visible = false;
                if (count > 2)
                {
                    // color features box 3 and box 4
                    labelColorS3.Visible = true;
                    comboBoxColorS3.Visible = true;
                    labelColorS4.Visible = false;
                    comboBoxColorS4.Visible = false;
                    // door features box 3 and box 4
                    labelDoorBox3.Visible = true;
                    panelYesNoBox3.Visible = true;
                    labelDoorBox4.Visible = false;
                    panelYesNoBox4.Visible = false;
                    radioButtonNoBox4.Checked = true;
                    // shelf image
                    panelShelf3.Visible = true;
                    panelShelf4.Visible = false;
                    if (count > 3)
                    {
                        // color features box 4 and box 5
                        labelColorS4.Visible = true;
                        comboBoxColorS4.Visible = true;
                        labelColorS5.Visible = false;
                        comboBoxColorS5.Visible = false;
                        // door features box 4 and box 5
                        labelDoorBox4.Visible = true;
                        panelYesNoBox4.Visible = true;
                        labelDoorBox5.Visible = false;
                        panelYesNoBox5.Visible = false;
                        radioButtonNoBox5.Checked = true;
                        // shelf image
                        panelShelf4.Visible = true;
                        panelShelf5.Visible = false;
                        if (count > 4)
                        {
                            // color features box 5 and box 6
                            labelColorS5.Visible = true;
                            comboBoxColorS5.Visible = true;
                            labelColorS6.Visible = false;
                            comboBoxColorS6.Visible = false;
                            // door features box 5 and box 6
                            labelDoorBox5.Visible = true;
                            panelYesNoBox5.Visible = true;
                            labelDoorBox6.Visible = false;
                            panelYesNoBox6.Visible = false;
                            radioButtonNoBox6.Checked = true;
                            // shelf image
                            panelShelf5.Visible = true;
                            panelShelf6.Visible = false;
                            if (count > 5)
                            {
                                // color features box 6 and box 7
                                labelColorS6.Visible = true;
                                comboBoxColorS6.Visible = true;
                                labelColorS7.Visible = false;
                                comboBoxColorS7.Visible = false;
                                // door features box 6 and box 7
                                labelDoorBox6.Visible = true;
                                panelYesNoBox6.Visible = true;
                                labelDoorBox7.Visible = false;
                                panelYesNoBox7.Visible = false;
                                radioButtonNoBox7.Checked = true;
                                // shelf image
                                panelShelf6.Visible = true;
                                panelShelf7.Visible = false;
                                if (count > 6)
                                {
                                    // color features box 7
                                    labelColorS7.Visible = true;
                                    comboBoxColorS7.Visible = true;
                                    // door features box 7
                                    labelDoorBox7.Visible = true;
                                    panelYesNoBox7.Visible = true;
                                    // shelf image
                                    panelShelf7.Visible = true;                                 
                                }
                            }
                        }
                    }
                }
            }
        }

        // function for door in case only 1 box
        private void radioButtonsYesNoIf1_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesIf1)
                {
                    panelDoorMaterial.Visible = true;
                    LoadDataWidthDoor();
                    comboBoxWidth.Text = "";
                }
                else if (((RadioButton)sender) == radioButtonNoIf1)
                {
                    panelDoorMaterial.Visible = false;
                    LoadDataWidth();
                }
            }
        }

        // function for doors in case multiple boxes
        private void radioButtonsYesNoIf2_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesIf2)
                {
                    panelDoorChoicesM.Visible = true;
                    LoadDataWidthDoor();
                    comboBoxWidth.Text = "";
                }
                else if (((RadioButton)sender) == radioButtonNoIf2)
                {
                    panelDoorChoicesM.Visible = false;
                    LoadDataWidth();
                }
            }
        }

        // function radiobuttons for door box 1
        private void radioButtonBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesBox1)
                {
                    panelDoorChoiceBox1.Visible = true;
                }
                else if (((RadioButton)sender) == radioButtonNoBox1)
                {
                    panelDoorChoiceBox1.Visible = false;
                }
            }
        }

        // function radiobuttons for door box 2
        private void radioButtonBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesBox2)
                {
                    panelDoorChoiceBox2.Visible = true;
                }
                else if (((RadioButton)sender) == radioButtonNoBox2)
                {
                    panelDoorChoiceBox2.Visible = false;
                }
            }
        }

        // function radiobuttons for door box 3
        private void radioButtonBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesBox3)
                {
                    panelDoorChoiceBox3.Visible = true;
                }
                else if (((RadioButton)sender) == radioButtonNoBox3)
                {
                    panelDoorChoiceBox3.Visible = false;
                }
            }
        }

        // function radiobuttons for door box 4
        private void radioButtonBox4_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesBox4)
                {
                    panelDoorChoiceBox4.Visible = true;
                }
                else if (((RadioButton)sender) == radioButtonNoBox4)
                {
                    panelDoorChoiceBox4.Visible = false;
                }
            }
        }

        // function radiobuttons for door box 5
        private void radioButtonBox5_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesBox5)
                {
                    panelDoorChoiceBox5.Visible = true;
                }
                else if (((RadioButton)sender) == radioButtonNoBox5)
                {
                    panelDoorChoiceBox5.Visible = false;
                }
            }
        }

        // function radiobuttons for door box 6
        private void radioButtonBox6_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesBox6)
                {
                    panelDoorChoiceBox6.Visible = true;
                }
                else if (((RadioButton)sender) == radioButtonNoBox6)
                {
                    panelDoorChoiceBox6.Visible = false;
                }
            }
        }

        // function radiobuttons for door box 7
        private void radioButtonBox7_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesBox7)
                {
                    panelDoorChoiceBox7.Visible = true;
                }
                else if (((RadioButton)sender) == radioButtonNoBox7)
                {
                    panelDoorChoiceBox7.Visible = false;
                }
            }
        }

        // general function to add color to box cabinet image
        private void AddColorToBox(ComboBox box, ComboBox door, System.Windows.Forms.Panel shelf)
        {
            string color = box.Text;
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

        private void comboBoxColorIf1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColorIf1, comboBoxDoorMatIf1, panelShelf1);
        }

        private void LoadColorAllSame()
        {
            int count = Convert.ToInt32(numericUpDownQuantity.Value);
            string color = comboBoxColorSA.Text;
            if (comboBoxDoorMatBox1.Text == "" && comboBoxDoorMatBox2.Text == "" && comboBoxDoorMatBox3.Text == "" && comboBoxDoorMatBox4.Text == "" && comboBoxDoorMatBox5.Text == "" && comboBoxDoorMatBox6.Text == "" && comboBoxDoorMatBox7.Text == "" && comboBoxColorS1.Text == "" && comboBoxColorS2.Text == "" && comboBoxColorS3.Text == "" && comboBoxColorS4.Text == "" && comboBoxColorS5.Text == "" && comboBoxColorS6.Text == "" && comboBoxColorS7.Text == "" && comboBoxColorSA.Text == "")
            {
                Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blancNoDoor.png");
                panelShelf1.BackgroundImage = myImage;
                if (count > 1)
                {
                    panelShelf2.BackgroundImage = myImage;
                    if (count > 2)
                    {
                        panelShelf3.BackgroundImage = myImage;
                        if (count > 3)
                        {
                            panelShelf4.BackgroundImage = myImage;
                            if (count > 4)
                            {
                                panelShelf5.BackgroundImage = myImage;
                                if (count > 5)
                                {
                                    panelShelf6.BackgroundImage = myImage;
                                    if (count > 6)
                                    {
                                        panelShelf7.BackgroundImage = myImage;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (comboBoxDoorMatBox1.Text == "" && comboBoxDoorMatBox2.Text == "" && comboBoxDoorMatBox3.Text == "" && comboBoxDoorMatBox4.Text == "" && comboBoxDoorMatBox5.Text == "" && comboBoxDoorMatBox6.Text == "" && comboBoxDoorMatBox7.Text == "")
            {
                Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + "NoDoor.png");
                panelShelf1.BackgroundImage = myImage;
                if (count > 1)
                {
                    panelShelf2.BackgroundImage = myImage;
                    if (count > 2)
                    {
                        panelShelf3.BackgroundImage = myImage;
                        if (count > 3)
                        {
                            panelShelf4.BackgroundImage = myImage;
                            if (count > 4)
                            {
                                panelShelf5.BackgroundImage = myImage;
                                if (count > 5)
                                {
                                    panelShelf6.BackgroundImage = myImage;
                                    if (count > 6)
                                    {
                                        panelShelf7.BackgroundImage = myImage;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                string doorMat1 = comboBoxColorS1.Text;
                if (doorMat1 == "")
                {
                    doorMat1 = "NoDoor";
                }
                Image myImage1 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat1 + ".png");
                panelShelf1.BackgroundImage = myImage1;
                if (count > 1)
                {
                    string doorMat2 = comboBoxColorS2.Text;
                    if (doorMat2 == "")
                    {
                        doorMat2 = "NoDoor";
                    }                    
                    Image myImage2 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat2 + ".png");
                    panelShelf2.BackgroundImage = myImage2;                                     
                    if (count > 2)
                    {
                        string doorMat3 = comboBoxColorS3.Text;
                        if (doorMat3 == "")
                        {
                            doorMat3 = "NoDoor";
                        }                        
                        Image myImage3 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat3 + ".png");
                        panelShelf3.BackgroundImage = myImage3;
                        if (count > 3)
                        {
                            string doorMat4 = comboBoxColorS4.Text;
                            if (doorMat4 == "")
                            {
                                doorMat4 = "NoDoor";
                            }
                            Image myImage4 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat4 + ".png");
                            panelShelf4.BackgroundImage = myImage4;
                            if (count > 4)
                            {
                                string doorMat5 = comboBoxColorS5.Text;
                                if (doorMat5 == "")
                                {
                                    doorMat5 = "NoDoor";
                                }
                                Image myImage5 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat5 + ".png");
                                panelShelf5.BackgroundImage = myImage5;
                                if (count > 5)
                                {
                                    string doorMat6 = comboBoxColorS6.Text;
                                    if (doorMat6 == "")
                                    {
                                        doorMat6 = "NoDoor";
                                    }
                                    Image myImage6 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat6 + ".png");
                                    panelShelf6.BackgroundImage = myImage6;
                                    if (count > 6)
                                    {
                                        string doorMat7 = comboBoxColorS7.Text;
                                        if (doorMat7 == "")
                                        {
                                            doorMat7 = "NoDoor";
                                        }
                                        Image myImage7 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + color + doorMat7 + ".png");
                                        panelShelf7.BackgroundImage = myImage7;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void comboBoxColorSA_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadColorAllSame();
        }

        private void comboBoxColorS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColorS1, comboBoxDoorMatBox1, panelShelf1);
        }

        private void comboBoxColorS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColorS2, comboBoxDoorMatBox2, panelShelf2);
        }

        private void comboBoxColorS3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColorS3, comboBoxDoorMatBox3, panelShelf3);
        }

        private void comboBoxColorS4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColorS4, comboBoxDoorMatBox4, panelShelf4);
        }

        private void comboBoxColorS5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColorS5, comboBoxDoorMatBox5, panelShelf5);
        }

        private void comboBoxColorS6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColorS6, comboBoxDoorMatBox6, panelShelf6);
        }

        private void comboBoxColorS7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColorToBox(comboBoxColorS7, comboBoxDoorMatBox7, panelShelf7);
        }

        // general function to add door and color door to cabinet image
        public void AddDoorToBox(ComboBox door, ComboBox box, System.Windows.Forms.Panel shelf)
        {
            string doorMat = door.Text;
            string boxSA = comboBoxColorSA.Text;
            if (box.Text == "" && boxSA == "")
            {
                if (doorMat != "")
                {
                    Image myImage = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\blanc" + doorMat + ".png");
                    shelf.BackgroundImage = myImage;
                }
            }
            else if (box.Text != "" && boxSA == "")
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
            else
            {
                string color = boxSA;
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

        private void comboBoxDoorMatBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMatBox1 , comboBoxColorS1, panelShelf1);
        }

        private void comboBoxDoorMatBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMatBox2, comboBoxColorS2, panelShelf2);
        }

        private void comboBoxDoorMatBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMatBox3, comboBoxColorS3, panelShelf3);
        }

        private void comboBoxDoorMatBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMatBox4, comboBoxColorS4, panelShelf4);
        }

        private void comboBoxDoorMatBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMatBox5, comboBoxColorS5, panelShelf5);
        }

        private void comboBoxDoorMatBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMatBox6, comboBoxColorS6, panelShelf6);
        }

        private void comboBoxDoorMatBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMatBox7, comboBoxColorS7, panelShelf7);
        }

        private void comboBoxDoorMatIf1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDoorToBox(comboBoxDoorMatIf1, comboBoxColorIf1 , panelShelf1);
        }

        //function that give the height of each box
        private int ProcessHeightForEachBox(int heightToGive, int nbrBoxToGive)
        {
            var height = heightToGive;
            var nbrBox = nbrBoxToGive;
            int boxHeight = (height - nbrBox * 4) / nbrBox;
            return boxHeight;
        }

        // function to give dimension of the boxes
        private void comboBoxHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : sth to change text next to combobox containing height of the box
            var height = Int32.Parse(comboBoxHeight.SelectedItem.ToString());
            var nbrBox = Int32.Parse(numericUpDownQuantity.Value.ToString());
            int boxHeight = ProcessHeightForEachBox(height,nbrBox);
            string dimension = nbrBox + "x" + boxHeight.ToString() + "(h)";
            labelBoxHeight.Text = dimension.ToString();
        }

        //function that add the chosen features to the cart
        private void button2_Click(object sender, EventArgs e)
        {

            //If the cart is empty, create it
            if (CartPage.Cart == null)
            {
                CartPage.Cart = new Cart();
            }

            Cabinet cabinet = new Cabinet();


            int qty = (int)numericUpDownQuantity.Value;
            int totalHeight = Int32.Parse(comboBoxHeight.SelectedItem.ToString());
            int heightForEach = ProcessHeightForEachBox(totalHeight,qty);
            int width = Int32.Parse(comboBoxWidth.SelectedItem.ToString());
            int depth = Int32.Parse(comboBoxDepth.SelectedItem.ToString());
            String angleColor = comboBoxColorAngles.SelectedItem.ToString();

            cabinet.AddAngles(angleColor);

            //Initialize colors and doors choices
            string color1 = null;
            string color2 = null;
            string color3 = null;
            string color4 = null;
            string color5 = null;
            string color6 = null;
            string color7 = null;

            string door1 = null;
            string door2 = null;
            string door3 = null;
            string door4 = null;
            string door5 = null;
            string door6 = null;
            string door7 = null;


            if (qty == 1)
            {
                color1 = comboBoxColorIf1.SelectedItem.ToString();
                if (radioButtonYesIf1.Checked == true)
                {
                    door1 = comboBoxDoorMatIf1.Text.ToString();
                }

                else
                {
                    door1 = null;
                }
            }

            else
            {
                if (checkBoxColorYes.Checked == true & radioButtonYesIf2.Checked == true)
                {
                    color1 = comboBoxColorSA.Text.ToString();
                    color2 = comboBoxColorSA.Text.ToString();
                    color3 = comboBoxColorSA.Text.ToString();
                    color4 = comboBoxColorSA.Text.ToString();
                    color5 = comboBoxColorSA.Text.ToString();
                    color6 = comboBoxColorSA.Text.ToString();
                    color7 = comboBoxColorSA.Text.ToString();

                    if (radioButtonYesBox1.Checked == true)
                    {
                        door1 = comboBoxDoorMatBox1.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox2.Checked == true)
                    {
                        door2 = comboBoxDoorMatBox2.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox3.Checked == true)
                    {
                        door3 = comboBoxDoorMatBox3.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox4.Checked == true)
                    {
                        door4 = comboBoxDoorMatBox4.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox5.Checked == true)
                    {
                        door5 = comboBoxDoorMatBox5.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox6.Checked == true)
                    {
                        door6 = comboBoxDoorMatBox6.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox7.Checked == true)
                    {
                        door7 = comboBoxDoorMatBox7.SelectedItem.ToString();
                    }
                }
                if (checkBoxColorYes.Checked == true & radioButtonYesIf2.Checked == false)
                {
                    color1 = comboBoxColorSA.Text.ToString();
                    color2 = comboBoxColorSA.Text.ToString();
                    color3 = comboBoxColorSA.Text.ToString();
                    color4 = comboBoxColorSA.Text.ToString();
                    color5 = comboBoxColorSA.Text.ToString();
                    color6 = comboBoxColorSA.Text.ToString();
                    color7 = comboBoxColorSA.Text.ToString();
                }
                if (checkBoxColorYes.Checked == false & radioButtonYesIf2.Checked == true)
                {
                    if (radioButtonYesBox1.Checked == true)
                    {
                        door1 = comboBoxDoorMatBox1.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox2.Checked == true)
                    {
                        door2 = comboBoxDoorMatBox2.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox3.Checked == true)
                    {
                        door3 = comboBoxDoorMatBox3.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox4.Checked == true)
                    {
                        door4 = comboBoxDoorMatBox4.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox5.Checked == true)
                    {
                        door5 = comboBoxDoorMatBox5.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox6.Checked == true)
                    {
                        door6 = comboBoxDoorMatBox6.SelectedItem.ToString();
                    }
                    if (radioButtonYesBox7.Checked == true)
                    {
                        door7 = comboBoxDoorMatBox7.SelectedItem.ToString();
                    }
                }
                else
                {
                    color1 = comboBoxColorS1.Text.ToString();
                    color2 = comboBoxColorS2.Text.ToString();
                    color3 = comboBoxColorS3.Text.ToString();
                    color4 = comboBoxColorS4.Text.ToString();
                    color5 = comboBoxColorS5.Text.ToString();
                    color6 = comboBoxColorS6.Text.ToString();
                    color7 = comboBoxColorS7.Text.ToString();
                }
            }


            //All the boxes we can get

            CabinetFloor box1 = new CabinetFloor(heightForEach, width, depth, door1, panelCol: color1);
            CabinetFloor box2 = new CabinetFloor(heightForEach, width, depth, door2, panelCol: color2);
            CabinetFloor box3 = new CabinetFloor(heightForEach, width, depth, door3, panelCol: color3);
            CabinetFloor box4 = new CabinetFloor(heightForEach, width, depth, door4, panelCol: color4);
            CabinetFloor box5 = new CabinetFloor(heightForEach, width, depth, door5, panelCol: color5);
            CabinetFloor box6 = new CabinetFloor(heightForEach, width, depth, door6, panelCol: color6);
            CabinetFloor box7 = new CabinetFloor(heightForEach, width, depth, door7, panelCol: color7);




            switch (qty)
            {
                case 1:
                    cabinet.AddStorageBox(box1);
                    break;
                case 2:
                    cabinet.AddStorageBox(box1);
                    cabinet.AddStorageBox(box2);
                    break;
                case 3:
                    cabinet.AddStorageBox(box1);
                    cabinet.AddStorageBox(box2);
                    cabinet.AddStorageBox(box3);
                    break;
                case 4:
                    cabinet.AddStorageBox(box1);
                    cabinet.AddStorageBox(box2);
                    cabinet.AddStorageBox(box3);
                    cabinet.AddStorageBox(box4);
                    break;
                case 5:
                    cabinet.AddStorageBox(box1);
                    cabinet.AddStorageBox(box2);
                    cabinet.AddStorageBox(box3);
                    cabinet.AddStorageBox(box4);
                    cabinet.AddStorageBox(box5);
                    break;
                case 6:
                    cabinet.AddStorageBox(box1);
                    cabinet.AddStorageBox(box2);
                    cabinet.AddStorageBox(box3);
                    cabinet.AddStorageBox(box4);
                    cabinet.AddStorageBox(box5);
                    cabinet.AddStorageBox(box6);
                    break;
                case 7:
                    cabinet.AddStorageBox(box1);
                    cabinet.AddStorageBox(box2);
                    cabinet.AddStorageBox(box3);
                    cabinet.AddStorageBox(box4);
                    cabinet.AddStorageBox(box5);
                    cabinet.AddStorageBox(box6);
                    cabinet.AddStorageBox(box7);
                    break;
            }
            CartPage.Cart.AddToCart(cabinet);

            JObject test = CartPage.Cart.ShowCart();
            MessageBox.Show("This cabinet has been added to the cart succesfully!");

        }
        
    }
}
