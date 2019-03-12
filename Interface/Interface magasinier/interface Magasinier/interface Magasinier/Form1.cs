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

    

        public void Loaddata() //Different Listbox containing the 2 first colomns of the db 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();

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
                        listBox1.Items.Add(dr[0].ToString());
                        listBox2.Items.Add(dr[1].ToString());
                        listBox3.Items.Add(dr[2].ToString());
                        listBox4.Items.Add(dr[4].ToString());
                        listBox5.Items.Add(dr[6].ToString());
                        listBox6.Items.Add(dr[11].ToString());
                        listBox7.Items.Add(dr[12].ToString());
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
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
                listBox6.SelectedIndex = l.SelectedIndex;
                listBox7.SelectedIndex = l.SelectedIndex;

                textBox1.Text = listBox2.SelectedItem.ToString();
                textBox3.Text = listBox2.SelectedItem.ToString();
                textBox2.Text = listBox3.SelectedItem.ToString();
                textBox4.Text = listBox4.SelectedItem.ToString();
                textBox6.Text = listBox2.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" & listBox1.SelectedIndex != -1)
            {
                string q = "update Piece set Enstock='" + textBox2.Text.ToString() + "' where PK_Piece=" + listBox1.SelectedItem.ToString();
                SqlOledb.SqlOledb.SqlRequest(q);
                MessageBox.Show(q);
                Loaddata();
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" & listBox1.SelectedIndex != -1)
            {
                string q = "update Piece set PrixClient=" + textBox4.Text.ToString() + " where PK_Piece=" + listBox1.SelectedItem.ToString();
                SqlOledb.SqlOledb.SqlRequest(q);
                MessageBox.Show(q);
                Loaddata();
                textBox4.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string q = "delete from Piece where PK_Piece=" + listBox1.SelectedItem.ToString();
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
