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
    public partial class Command : UserControl
    {
        public Command()
        {
            InitializeComponent();
        }
        OleDbDataReader dr;

        private void loadList(object sender, EventArgs e) //Connection to the DB and loading the data into the box
        {
            SqlOledb.SqlOledb.connection("C:\\Users\\Geryon\\Documents\\GitHub\\Projet_KitBox\\Database\\DB_Lespieces.accdb;");
            Loaddata();

        }


        public void Loaddata() //Loading de data into the differents listbox
        {
            IdClient.Items.Clear();
            NameList.Items.Clear();
            CityList.Items.Clear();
            IdOrderList.Items.Clear();
            IdClientList.Items.Clear();
            DateOrderClientList.Items.Clear();
            PriceOrderList.Items.Clear();
            PhoneClient.Items.Clear();
            IdOrderList2.Items.Clear();
            IdClientList2.Items.Clear();
            DateOrderClientList2.Items.Clear();
            PriceOrderList2.Items.Clear();
            DeliverDateList.Items.Clear();
            
            try
            {
                string q = "select * from ClientDetail";
                SqlOledb.SqlOledb.cmd.CommandText = q; // execution of a SQL instruction
                SqlOledb.SqlOledb.cn.Open();
                dr = SqlOledb.SqlOledb.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        IdClient.Items.Add(dr[0].ToString());
                        NameList.Items.Add(dr[1].ToString());
                        CityList.Items.Add(dr[2].ToString());
                        PhoneClient.Items.Add(dr[3].ToString());
                    }
                }
                dr.Close();
                SqlOledb.SqlOledb.cn.Close();

                q = "select * from Commande where Status='Progress'";
                SqlOledb.SqlOledb.cmd.CommandText = q; // execution of a SQL instruction
                SqlOledb.SqlOledb.cn.Open();
                dr = SqlOledb.SqlOledb.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        IdOrderList.Items.Add(dr[0].ToString());
                        IdClientList.Items.Add(dr[1].ToString());
                        DateOrderClientList.Items.Add(dr[3].ToString());
                        PriceOrderList.Items.Add(dr[5].ToString());

                    }
                }
                dr.Close();
                SqlOledb.SqlOledb.cn.Close();

                q = "select * from Commande where Status='Complete'";
                SqlOledb.SqlOledb.cmd.CommandText = q; // execution of a SQL instruction
                SqlOledb.SqlOledb.cn.Open();
                dr = SqlOledb.SqlOledb.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        IdOrderList2.Items.Add(dr[0].ToString());
                        IdClientList2.Items.Add(dr[1].ToString());
                        DateOrderClientList2.Items.Add(dr[3].ToString());
                        PriceOrderList2.Items.Add(dr[5].ToString());
                        DeliverDateList.Items.Add(dr[4].ToString());

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

        private void OrderPlistBox_Click(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                IdOrderList.SelectedIndex = l.SelectedIndex;
                IdClientList.SelectedIndex = l.SelectedIndex;
                DateOrderClientList.SelectedIndex = l.SelectedIndex;
                PriceOrderList.SelectedIndex = l.SelectedIndex;

                IdTextBox.Text = IdClientList.SelectedItem.ToString();
                IdTextBox2.Text = IdClientList.SelectedItem.ToString();
            }
        }

        private void ClientlistBox_Click(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                IdClient.SelectedIndex = l.SelectedIndex;
                NameList.SelectedIndex = l.SelectedIndex;
                CityList.SelectedIndex = l.SelectedIndex;
                PhoneClient.SelectedIndex = l.SelectedIndex;
            }
        }

        private void OrderDlistBox_Click(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {

                IdOrderList2.SelectedIndex = l.SelectedIndex;
                IdClientList2.SelectedIndex = l.SelectedIndex;
                DateOrderClientList2.SelectedIndex = l.SelectedIndex;
                PriceOrderList2.SelectedIndex = l.SelectedIndex;
                DeliverDateList.SelectedIndex = l.SelectedIndex;

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string q = "delete from Commande where PK_Commande=" + IdOrderList.SelectedItem.ToString();
            SqlOledb.SqlOledb.SqlRequest(q);
            
            Loaddata();
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (DeliverTextBox.Text != "" & IdOrderList.SelectedIndex != -1)
            {
                string q = "update Commande set Date_Livraison='" + DeliverTextBox.Text.ToString() + "', Status = 'Complete' where PK_Commande=" + IdOrderList.SelectedItem.ToString();
                SqlOledb.SqlOledb.SqlRequest(q);

                Loaddata();
                DeliverTextBox.Text = "";
            }
        }

        
    }
}
