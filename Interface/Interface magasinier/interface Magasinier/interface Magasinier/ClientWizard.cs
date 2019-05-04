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
    public partial class ClientWizard : UserControl
    {
        public ClientWizard()
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

                 q = "select * from ClientDetail";
                Oledb.cmd.CommandText = q; 
                Oledb.cn.Open();
                Oledb.dr = Oledb.cmd.ExecuteReader();
                if (Oledb.dr.HasRows)
                {
                    while (Oledb.dr.Read())
                    {
                       IdClientList.Items.Add(Oledb.dr[0].ToString());
                       NameClientList.Items.Add(Oledb.dr[1].ToString());
                       EmailClientList.Items.Add(Oledb.dr[6].ToString());
                       StreetClientList.Items.Add(Oledb.dr[2].ToString());
                       NumberClientList.Items.Add(Oledb.dr[3].ToString());
                       PhoneClient.Items.Add(Oledb.dr[5].ToString());
                       ZipClientList.Items.Add(Oledb.dr[8].ToString());
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
  
        private void ClientlistBox_Click(object sender, EventArgs e) //Connect the selection area between all the listbox
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

        private void ziplistBox_Click(object sender, EventArgs e) //Connect the selection area between all the listbox
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

        private void finishButton_Click(object sender, EventArgs e) //Complete and reset the form for the client
        {
            string rsq = "INSERT INTO Client (Nom,Email,Rue,Numero,Telephone,FK_CodePostal) VALUES ('"
                                + NameTextBox.Text.ToString() + "','"
                                + MailTextBox.Text.ToString() + "','"
                                + StreetTextBox.Text.ToString() + "','"
                                + NumbertextBox.Text.ToString() + "','"
                                + PhoneNumberBox.Text.ToString() + "','"
                                + ZipTextBox.Text.ToString() + "')";

            Oledb.SqlRequest(rsq);
            Loaddata();
            //Reset of every box
            MailTextBox.Text = "";
            NameTextBox.Text = "";
            StreetTextBox.Text = "";
            NumbertextBox.Text = "";
            PhoneNumberBox.Text = "";
            ZipTextBox.Text = "";
            MessageBox.Show("Congrats! You added a new Client");

        }

        private void addzip_Click(object sender, EventArgs e) //Complete and reset the form for the zip code
        {
            string rsq = "INSERT INTO CodePostal (CodePostal,Commune) VALUES ('"
                                + ZipBox.Text.ToString() + "','"
                                + CityBox.Text.ToString() + "')";

            Oledb.SqlRequest(rsq);
            Loaddata();
            //Reset of every box
            ZipBox.Text = "";
            CityBox.Text = "";
            MessageBox.Show("Congrats! You added a new Zip Code");

        }

        
    }
}
