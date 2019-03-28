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
using System.IO;



namespace interface_Magasinier
{
    public partial class ClientWizard : UserControl
    {
        public ClientWizard()
        {
            InitializeComponent();
        }
        OleDbDataReader dr;

        private void loadList(object sender, EventArgs e) //Connection to the DB and loading the data into the box
        {
            SqlOledb.SqlOledb.connection(Form1.GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Database\DB_Lespieces.accdb;");
            Loaddata();
            
        }


        public void Loaddata() //Loading de data into the differents listbox
        {
            IdZipList.Items.Clear();
            ZipList.Items.Clear();
            CityList.Items.Clear();
            IdClientList.Items.Clear();
            NameClientList.Items.Clear();
            EmailClientList.Items.Clear();
            StreetClientList.Items.Clear();
            NumberClientList.Items.Clear();
            PhoneClient.Items.Clear();
            ZipClientList.Items.Clear();


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

                 q = "select * from ClientDetail";
                SqlOledb.SqlOledb.cmd.CommandText = q; // execution of a SQL instruction
                SqlOledb.SqlOledb.cn.Open();
                dr = SqlOledb.SqlOledb.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       IdClientList.Items.Add(dr[0].ToString());
                       NameClientList.Items.Add(dr[1].ToString());
                       EmailClientList.Items.Add(dr[6].ToString());
                       StreetClientList.Items.Add(dr[2].ToString());
                       NumberClientList.Items.Add(dr[3].ToString());
                       PhoneClient.Items.Add(dr[5].ToString());
                       ZipClientList.Items.Add(dr[8].ToString());
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
  
        private void ClientlistBox_Click(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                IdClientList.SelectedIndex = l.SelectedIndex;
                NameClientList.SelectedIndex = l.SelectedIndex;
                EmailClientList.SelectedIndex = l.SelectedIndex;
                StreetClientList.SelectedIndex = l.SelectedIndex;
                NumberClientList.SelectedIndex = l.SelectedIndex;
                ZipClientList.SelectedIndex = l.SelectedIndex;
                PhoneClient.SelectedIndex = l.SelectedIndex;

            }
        }

        private void ziplistBox_Click(object sender, EventArgs e)
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
            string rsq = "INSERT INTO Client (Nom,Email,Rue,Numero,Telephone,FK_CodePostal) VALUES ('"
                                + NameTextBox.Text.ToString() + "','"
                                + MailTextBox.Text.ToString() + "','"
                                + StreetTextBox.Text.ToString() + "','"
                                + NumbertextBox.Text.ToString() + "','"
                                + PhoneNumberBox.Text.ToString() + "','"
                                + ZipTextBox.Text.ToString() + "')";

            SqlOledb.SqlOledb.SqlRequest(rsq);
            Loaddata();
            MailTextBox.Text = "";
            NameTextBox.Text = "";
            StreetTextBox.Text = "";
            NumbertextBox.Text = "";
            PhoneNumberBox.Text = "";
            ZipTextBox.Text = "";
            MessageBox.Show("Congrats! You added a new Zip Code");

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
            MessageBox.Show("Congrats! You added a new Client");

        }

        
    }
}
