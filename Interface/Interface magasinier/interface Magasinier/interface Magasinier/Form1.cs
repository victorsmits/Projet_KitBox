using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace interface_Magasinier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        OleDbDataReader dr;
        private void Form1_Load(object sender, EventArgs e) //Connection to the DB and loading the data into the box
        {
            SqlOledb.SqlOledb.connection("C:\\Users\\Geryon\\Documents\\GitHub\\Projet_KitBox\\Database\\DB_Lespieces.accdb;");
            Loaddata();
        }
        OleDbCommand cmd = new OleDbCommand(); //cmd for command
        OleDbConnection cn = new OleDbConnection();  // cn for connection

        public void Loaddata() //Loading de data into the differents listbox
        {
            IdList.Items.Clear();
            RefrenceList.Items.Clear();
            StockList.Items.Clear();
            PriceClientList.Items.Clear();
            DimensionsList.Items.Clear();
            TypeList.Items.Clear();
            ColorList.Items.Clear();

            try
            {
                string q = "select * from Piece";
                SqlOledb.SqlOledb.cmd.CommandText = q; // execution of a SQL instruction
                SqlOledb.SqlOledb.cn.Open();
                dr = SqlOledb.SqlOledb.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        IdList.Items.Add(dr[0].ToString());
                        RefrenceList.Items.Add(dr[1].ToString());
                        StockList.Items.Add(dr[2].ToString());
                        PriceClientList.Items.Add(dr[4].ToString());
                        DimensionsList.Items.Add(dr[6].ToString());
                        TypeList.Items.Add(dr[11].ToString());
                        ColorList.Items.Add(dr[12].ToString());
                    }
                }
                dr.Close();
                SqlOledb.SqlOledb.cn.Close();
            }
            catch (Exception e)
            {
                SqlOledb.SqlOledb.cn.Close();
                MessageBox.Show(e.Message.ToString());
            }

        }
        private void listBox2_Click(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                IdList.SelectedIndex = l.SelectedIndex;
                RefrenceList.SelectedIndex = l.SelectedIndex;
                StockList.SelectedIndex = l.SelectedIndex;
                PriceClientList.SelectedIndex = l.SelectedIndex;
                DimensionsList.SelectedIndex = l.SelectedIndex;
                TypeList.SelectedIndex = l.SelectedIndex;
                ColorList.SelectedIndex = l.SelectedIndex;

                RefrenceTextBox2.Text = RefrenceList.SelectedItem.ToString();
                RefrenceTextBox3.Text = RefrenceList.SelectedItem.ToString();
                StockTextBox.Text = StockList.SelectedItem.ToString();
                PriceClientTextBox.Text = PriceClientList.SelectedItem.ToString();
                RefrenceTextBox.Text = RefrenceList.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StockTextBox.Text != "" & IdList.SelectedIndex != -1)
            {
                string q = "update Piece set Enstock='" + StockTextBox.Text.ToString() + "' where PK_Piece=" + IdList.SelectedItem.ToString();
                SqlOledb.SqlOledb.SqlRequest(q);
                MessageBox.Show(q);
                Loaddata();
                StockTextBox.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PriceClientTextBox.Text != "" & IdList.SelectedIndex != -1)
            {
                string q = "update Piece set PrixClient=" + PriceClientTextBox.Text.ToString() + " where PK_Piece=" + IdList.SelectedItem.ToString();
                SqlOledb.SqlOledb.SqlRequest(q);
                MessageBox.Show(q);
                Loaddata();
                PriceClientTextBox.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string q = "delete from Piece where PK_Piece=" + IdList.SelectedItem.ToString();
            SqlOledb.SqlOledb.SqlRequest(q);
            MessageBox.Show(q);
            Loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string rsq = "INSERT INTO Req (Référence,Enstock,StockMinimum,PrixClient,Nb_PiecesCasier,Dimensions_cm,hauteur,profondeur,largeur,Reservation,Code,Couleur,Division,Prix,Delai,FK_Fournisseur) VALUES ('TRG','82','32','52','4','62','0','62','0','0','Trav','Pasde','0','1','1','1')";
            SqlOledb.SqlOledb.SqlRequest(rsq);
            MessageBox.Show(rsq);
            Loaddata();
        }


    }
}
