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
    public partial class CreationScratchInside : UserControl
    {
        

        public CreationScratchInside()
        {
            InitializeComponent();
            
            // radio buttons in same group added to same function - group : --panelYesNoIf1--
            radioButtonYes.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChanged);
            radioButtonNo.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChanged);
        }

        OleDbCommand cmd = new OleDbCommand(); //cmd for command
        OleDbConnection cn = new OleDbConnection();  // cn for connection
        OleDbDataReader dr;

        private void CreationScratchInside_Load(object sender, EventArgs e)
        {
            BoxCreationScratch boxCreationScratch = new BoxCreationScratch();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Database\DB_Lespieces.accdb;";
            cmd.Connection = cn;
            LoadDataWidth();
            LoadDataDepth();
            LoadDataBoxHeight();
            LoadDataDoor();
            LoadDataBoxColor();
            //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources.phWpbBprWdlGdrG);
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
            System.Windows.Forms.ComboBox[] list = { comboBoxDepth };
            LoadDataGeneral(list, "SELECT DISTINCT profondeur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAR%' ");
        }

        // Loading Height data from data base
        private void LoadDataBoxHeight()
        {
            System.Windows.Forms.ComboBox[] list = { comboBoxColor };
            LoadDataGeneral(list, "SELECT DISTINCT hauteur FROM Piece WHERE référence LIKE 'PA%' AND référence NOT LIKE 'PAH%' ");
        }

        // Loading Box Color data from data base
        private void LoadDataBoxColor()
        {
            System.Windows.Forms.ComboBox[] list = {comboBoxColor};
            LoadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'PA%' ");
        }

        // Loading Door Material data from data base
        private void LoadDataDoor()
        {
            System.Windows.Forms.ComboBox[] list = {comboBoxDoorMat};
            LoadDataGeneral(list, "SELECT DISTINCT couleur FROM Piece WHERE référence LIKE 'POR%' ");
        }

        private void radioButtonsYesNo_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes)
                {
                    panelDoorMaterial.Visible = true;
                    LoadDataWidthDoor();
                    comboBoxWidth.Text = "";
                }
                else if (((RadioButton)sender) == radioButtonNo)
                {
                    panelDoorMaterial.Visible = false;
                    LoadDataWidth();
                }
            }
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxCreationScratch boxCreationScratch = new BoxCreationScratch();
            string color = comboBoxColor.Text;
            if (comboBoxDoorMat.Text == "")
            {
                //Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\Resources\" + color + "NoDoor.png");
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\Resources\brunbrun.png");
                //boxCreationScratch.PanelShelf1 = myImage;
                //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources.phWpbBprWdlGdrG);
                //boxCreationScratch.ColorAngles = "hello";


            }
            else
            {
                string doorMat = comboBoxDoorMat.Text;
                Image myImage = new Bitmap(@"C:\Users\Harold\Documents\GitHub\Projet_kitBox_final\Projet_KitBox\Interface\KitBoxApplication\Resources\" + color + doorMat + ".png");
                //boxCreationScratch.PanelShelf1 = myImage;
            }
            
            //boxCreationScratch.PanelShelf1 = (Image)(Properties.Resources.phWpbBprWdlGdrG);
        }

        private void comboBoxDoorMat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
