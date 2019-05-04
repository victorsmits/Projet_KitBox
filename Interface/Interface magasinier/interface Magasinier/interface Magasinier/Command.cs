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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;


namespace interface_Magasinier
{
    public partial class Command : UserControl
    {    
        //initialisation of the variable
        static private string StockRef = null;
        static private string StockRef1 = null;
        static private int Quantity = -1;
        static private int Quantity1 = -1;

        public Command()
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
                Oledb.cmd.CommandText = q; // execution of a SQL instruction
                Oledb.cn.Open();
                Oledb.dr = Oledb.cmd.ExecuteReader();
                if (Oledb.dr.HasRows)
                {
                    while (Oledb.dr.Read())
                    {
                        IdClient.Items.Add(Oledb.dr[0].ToString());
                        NameList.Items.Add(Oledb.dr[1].ToString());
                        CityList.Items.Add(Oledb.dr[2].ToString());
                        PhoneClient.Items.Add(Oledb.dr[3].ToString());
                    }
                }
                Oledb.dr.Close();
                Oledb.cn.Close();

                q = "select * from Commande where Status='Progress'";
                Oledb.cmd.CommandText = q; // execution of a SQL instruction
                Oledb.cn.Open();
                Oledb.dr = Oledb.cmd.ExecuteReader();
                if (Oledb.dr.HasRows)
                {
                    while (Oledb.dr.Read())
                    {
                        IdOrderList.Items.Add(Oledb.dr[0].ToString());
                        IdClientList.Items.Add(Oledb.dr[1].ToString());
                        DateOrderClientList.Items.Add(Oledb.dr[3].ToString());
                        PriceOrderList.Items.Add(Oledb.dr[5].ToString());

                    }
                }
                Oledb.dr.Close();
                Oledb.cn.Close();

                q = "select * from Commande where Status='Complete'";
                Oledb.cmd.CommandText = q; // execution of a SQL instruction
                Oledb.cn.Open();
                Oledb.dr = Oledb.cmd.ExecuteReader();
                if (Oledb.dr.HasRows)
                {
                    while (Oledb.dr.Read())
                    {
                        IdOrderList2.Items.Add(Oledb.dr[0].ToString());
                        IdClientList2.Items.Add(Oledb.dr[1].ToString());
                        DateOrderClientList2.Items.Add(Oledb.dr[3].ToString());
                        PriceOrderList2.Items.Add(Oledb.dr[5].ToString());
                        DeliverDateList.Items.Add(Oledb.dr[4].ToString());

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

        private void OrderPlistBox_Click(object sender, EventArgs e) //Connect the selection area between all the listbox
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                IdOrderList.SelectedIndex = l.SelectedIndex;
                IdClientList.SelectedIndex = l.SelectedIndex;
                DateOrderClientList.SelectedIndex = l.SelectedIndex;
                PriceOrderList.SelectedIndex = l.SelectedIndex;

                IdTextBox.Text = IdOrderList.SelectedItem.ToString();
                IdTextBox2.Text = IdOrderList.SelectedItem.ToString();
            }
        }

        private void ClientlistBox_Click(object sender, EventArgs e) //Connect the selection area between all the listbox
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

        private void OrderDlistBox_Click(object sender, EventArgs e) //Connect the selection area between all the listbox
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

        private void DeleteButton_Click(object sender, EventArgs e) // Delete the command from the Db
        {
            string q = "delete from Commande where PK_Commande=" + IdOrderList.SelectedItem.ToString();
            Oledb.SqlRequest(q);
            
            Loaddata();
        }
        
        private void CompleteButton_Click(object sender, EventArgs e) // Complete an order by the update of the Reservation and the Enstock into the Db
        {
            if (DeliverTextBox.Text != "" & IdOrderList.SelectedIndex != -1)
            {
                string q = "update Commande set Date_Livraison='" + DeliverTextBox.Text.ToString() + "', Status = 'Complete' where PK_Commande=" + IdOrderList.SelectedItem.ToString();
                Oledb.SqlRequest(q);
                string j = "select ListeMateriel from Commande where PK_Commande=" + IdOrderList.SelectedItem.ToString();
                string json = Oledb.SqlRequest_load(j);

                //Regex for the reading of the Json
                Regex rgx = new Regex(@"\[StockRef,", RegexOptions.IgnoreCase);
                Regex rgx2 = new Regex(@"[A-Z]{3}[0-9]{2,}[A-Z]{0,}|COUPEL", RegexOptions.IgnoreCase);
                Regex rgx3 = new Regex(@"\[Quantity,", RegexOptions.IgnoreCase); 
                Regex rgx4 = new Regex(@"[0-9]{1,}", RegexOptions.IgnoreCase);
                Regex rgx5 = new Regex(@"\[Qty,", RegexOptions.IgnoreCase);
                Regex rgx6 = new Regex(@"\[Stockref,", RegexOptions.IgnoreCase);
    
                JObject jsonData = JObject.Parse(json);
                
                foreach( var Liste in jsonData )
                {
                    try
                    {
                        JObject Cabinet = (JObject)Liste.Value;
                        foreach (var Floor in Cabinet)
                        {
                            //Loop for the cabinet and the price
                            try
                            {
                                JObject objects = (JObject)Floor.Value;
                                foreach (var pieces in objects)
                                {
                                    //Loop for the Angles
                                    try
                                    {
                                        if (rgx.IsMatch(pieces.ToString()) && Quantity == -1 && StockRef == null) //match stockref and register the value
                                        {
                                            Match match = rgx2.Match(pieces.ToString());
                                            StockRef = match.Value;                     
                                        }
                                        if (rgx3.IsMatch(pieces.ToString()) && StockRef != null && Quantity == -1) //match qty and modify the values into the database
                                        {
                                            Match match = rgx4.Match(pieces.ToString());
                                            Quantity = int.Parse(match.Value);
                                            //Register the value of the Reservation
                                            string reservesql = "select Reservation from Piece where Référence='"+ StockRef+"'";
                                            int reserve = int.Parse(Oledb.SqlRequest_load(reservesql));
                                            //Register the value of the Enstock
                                            string stocksql = "select PK_Piece from Piece where Référence='"+ StockRef +"'";
                                            int stock = int.Parse(Oledb.SqlRequest_load(stocksql));
                                            int final_reserve = reserve - Quantity;
                                            int final_stock = stock - Quantity;
                                            // Update the Reservation and the Enstock
                                            string update_Piece = "Update Piece set Enstock='"+ final_stock.ToString() +"', Reservation='"+ final_reserve.ToString() +"' where Référence='"+StockRef+"'";
                                            Oledb.SqlRequest(update_Piece);
                                            StockRef = null;
                                            Quantity = -1;
                                        }
                                        JObject piece = (JObject)pieces.Value;
                                        foreach (var minis in piece)
                                        {
                                            //Loop for the major of the caracteristics
                                            try
                                            {
                                                if (rgx6.IsMatch(minis.ToString()) && Quantity == -1 && StockRef == null) //match stockref and register the value
                                                {
                                                    
                                                    Match match = rgx2.Match(minis.ToString());
                                                    StockRef = match.Value;
                                                }
                                                if (rgx5.IsMatch(minis.ToString()) && StockRef != null && Quantity == -1) //match qty and modify the values into the database
                                                {

                                                    Match match = rgx4.Match(minis.ToString());
                                                    Quantity = int.Parse(match.Value);
                                                    //Register the value of the Reservation
                                                    string reservesql = "select Reservation from Piece where Référence='" + StockRef + "'";
                                                    int reserve = int.Parse(Oledb.SqlRequest_load(reservesql));
                                                    //Register the value of the Enstock
                                                    string stocksql = "select Enstock from Piece where Référence='" + StockRef + "'";
                                                    int stock = int.Parse(Oledb.SqlRequest_load(stocksql));
                                                    int final_reserve = reserve - Quantity;
                                                    int final_stock = stock - Quantity;
                                                    //Update the Reservation and the Enstock
                                                    string update_Piece = "Update Piece set Enstock='" + final_stock.ToString() + "', Reservation='" + final_reserve.ToString() + "' where Référence='" + StockRef + "'";
                                                    Oledb.SqlRequest(update_Piece);
                                                    StockRef = null;
                                                    Quantity = -1;
                                                }
                                                JObject mini = (JObject)minis.Value;
                                                foreach (var coupelle in mini)
                                                {
                                                    //Loop for the Coupelle
                                                    if (rgx.IsMatch(coupelle.ToString()) && Quantity1 == -1 && StockRef1 == null) //match stockref and register the value
                                                    {
                                                        Match match = rgx2.Match(coupelle.ToString());
                                                        StockRef1 = match.Value;
                                                    }
                                                    if (rgx3.IsMatch(coupelle.ToString()) && StockRef1 != null && Quantity1 == -1)
                                                    {

                                                        Match match = rgx4.Match(coupelle.ToString());
                                                        Quantity1 = int.Parse(match.Value);
                                                        //Register the value of the Reservation
                                                        string reservesql = "select Reservation from Piece where Référence='" + StockRef1 + "'";
                                                        int reserve = int.Parse(Oledb.SqlRequest_load(reservesql));
                                                        //Register the value of the Enstock
                                                        string stocksql = "select Enstock from Piece where Référence='" + StockRef1 + "'";
                                                        int stock = int.Parse(Oledb.SqlRequest_load(stocksql));
                                                        int final_reserve = reserve - Quantity1;
                                                        int final_stock = stock - Quantity1;
                                                        // Update the Reservation and the Enstock
                                                        string update_Piece = "Update Piece set Enstock='" + final_stock.ToString() + "', Reservation='" + final_reserve.ToString() + "' where Référence='" + StockRef1 + "'";
                                                        Oledb.SqlRequest(update_Piece);

                                                        StockRef1 = null;
                                                        Quantity1 = -1;

                                                    }
                                                }
                                            }
                                            catch
                                            {

                                            }
                                        }
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    catch
                    {

                    }
                }
                
                Loaddata();
                DeliverTextBox.Text = "";
            }
        }

        
    }
}
