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
using SqlOledb;

namespace interface_Magasinier
{
    public partial class SupplierWizard : UserControl
    {
        OleDbDataReader dr;
        public SupplierWizard()
        {
            InitializeComponent();
        }

        private void loadList(object sender, EventArgs e) //Connection to the DB and loading the data into the box
        {
            SqlOledb.SqlOledb.connection("C:\\Users\\dtheo\\Documents\\GitHub\\Projet_KitBox\\Database\\DB_Lespieces.accdb;");
            Loaddata();
        }


        public void Loaddata() //Loading de data into the differents listbox
        {
            IdZipList.Items.Clear();
            ZipList.Items.Clear();
            CityList.Items.Clear();

            try
            {
                string q = "select * from CodePostal";
                SqlOledb.SqlOledb.cmd.CommandText = q; // execution of a SQL instruction
                SqlOledb.SqlOledb.cn.Open();
                dr = SqlOledb.SqlOledb.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        IdZipList.Items.Add(dr[0].ToString());
                        ZipList.Items.Add(dr[1].ToString());
                        CityList.Items.Add(dr[2].ToString());
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

        

        private void listBox_Click(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                IdZipList.SelectedIndex = l.SelectedIndex;
                ZipList.SelectedIndex = l.SelectedIndex;
                CityList.SelectedIndex = l.SelectedIndex;

                ZipTextBox.Text = IdZipList.SelectedItem.ToString();
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            string rsq = "INSERT INTO Fournisseur (Référence,Nom,Rue,Numero,FK_CodePostal) VALUES ('"
                                + RefTextBox.Text.ToString() + "','"
                                + NameTextBox.Text.ToString() +"','"
                                + StreetTextBox.Text.ToString() + "','"
                                + NumbertextBox.Text.ToString() + "','"
                                + ZipTextBox.Text.ToString() + "')";

            SqlOledb.SqlOledb.SqlRequest(rsq);
 
            Loaddata();
            RefTextBox.Text = "";
            NameTextBox.Text = "";
            StreetTextBox.Text = "";
            NumbertextBox.Text = "";
            ZipTextBox.Text = "";
            MessageBox.Show("Congrats! You added a new supplier");

        }

        private void addzip_Click(object sender, EventArgs e)
        {
            string rsq = "INSERT INTO CodePostal (CodePostal,Commune) VALUES ('"
                                + ZipBox.Text.ToString() + "','"
                                + CityBox.Text.ToString() + "')";

            SqlOledb.SqlOledb.SqlRequest(rsq);
           
            Loaddata();
            ZipBox.Text = "";
            CityBox.Text = "";
            MessageBox.Show("Congrats! You added a new zip");

        }
    }
}
