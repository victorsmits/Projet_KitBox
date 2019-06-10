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
using Oledb = SqlOledb.Oledb;
using System.IO;

namespace interface_Magasinier
{
    public partial class SupplierWizard : UserControl
    {
        
        public SupplierWizard()
        {
            InitializeComponent();
        }

        private void loadList(object sender, EventArgs e) //Connection to the DB and loading the data into the box
        {
            Oledb.Connection();
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
                Oledb.cmd.CommandText = q; // execution of a SQL instruction
                Oledb.cn.Open();
                Oledb.dr = Oledb.cmd.ExecuteReader();
                if (Oledb.dr.HasRows)
                {
                    while (Oledb.dr.Read())
                    {
                        IdZipList.Items.Add(Oledb.dr[0].ToString());
                        ZipList.Items.Add(Oledb.dr[1].ToString());
                        CityList.Items.Add(Oledb.dr[2].ToString());
                    }
                }
                Oledb.dr.Close();
                Oledb.cn.Close();
            }
            catch (Exception e)
            {
                Oledb.cn.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }

        

        private void listBox_Click(object sender, EventArgs e) //Connect the selection area between all the listbox
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

        private void finishButton_Click(object sender, EventArgs e) //Add a new supplier into the Db
        {
            string rsq = "INSERT INTO Fournisseur (Référence,Nom,Rue,Numero,FK_CodePostal) VALUES ('"
                                + RefTextBox.Text.ToString() + "','"
                                + NameTextBox.Text.ToString() +"','"
                                + StreetTextBox.Text.ToString() + "','"
                                + NumbertextBox.Text.ToString() + "','"
                                + ZipTextBox.Text.ToString() + "')";

            Oledb.SqlRequest(rsq);
            
            Loaddata();
            //Reset all the box
            RefTextBox.Text = "";
            NameTextBox.Text = "";
            StreetTextBox.Text = "";
            NumbertextBox.Text = "";
            ZipTextBox.Text = "";
            MessageBox.Show("Congrats! You added a new supplier");

        }

        private void addzip_Click(object sender, EventArgs e) //Add a new zip code into the DB
        {
            string rsq = "INSERT INTO CodePostal (CodePostal,Commune) VALUES ('"
                                + ZipBox.Text.ToString() + "','"
                                + CityBox.Text.ToString() + "')";

            Oledb.SqlRequest(rsq);
           
            Loaddata();
            ZipBox.Text = "";
            CityBox.Text = "";
            MessageBox.Show("Congrats! You added a new zip");

        }
    }
}
