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
using SqlOledb;
using Oledb = SqlOledb.Oledb;
using System.IO;

namespace interface_Magasinier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) //Connection to the DB and loading the data into the box
        {
            Oledb.Connection();
            Loaddata();
        }

        public void Loaddata() //Loading the data into the differents listbox
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
                Oledb.cmd.CommandText = q;       // execution of a SQL instruction
                Oledb.cn.Open();
                Oledb.dr = Oledb.cmd.ExecuteReader();
                if (Oledb.dr.HasRows)
                {
                    while (Oledb.dr.Read())
                    {
                        IdList.Items.Add(Oledb.dr[0].ToString());
                        RefrenceList.Items.Add(Oledb.dr[1].ToString());
                        StockList.Items.Add(Oledb.dr[2].ToString());
                        PriceClientList.Items.Add(Oledb.dr[4].ToString());
                        DimensionsList.Items.Add(Oledb.dr[6].ToString());
                        TypeList.Items.Add(Oledb.dr[11].ToString());
                        ColorList.Items.Add(Oledb.dr[12].ToString());
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

        private void listBox2_Click(object sender, EventArgs e) //Connect the selection area between all the listbox
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

        private void button1_Click(object sender, EventArgs e) //Update button for the stock
        {
            if (StockTextBox.Text != "" & IdList.SelectedIndex != -1)
            {
                string q = "update Piece set Enstock='" + StockTextBox.Text.ToString() + "' where PK_Piece=" + IdList.SelectedItem.ToString();
                Oledb.SqlRequest(q);
                
                Loaddata();
                StockTextBox.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e) //Update button for the price
        {
            if (PriceClientTextBox.Text != "" & IdList.SelectedIndex != -1)
            {
                string q = "update Piece set PrixClient=" + PriceClientTextBox.Text.ToString() + " where PK_Piece=" + IdList.SelectedItem.ToString();
                Oledb.SqlRequest(q);
                
                Loaddata();
                PriceClientTextBox.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e) //Delete the object selected
        {
            string q = "delete from Piece where PK_Piece=" + IdList.SelectedItem.ToString();
            Oledb.SqlRequest(q);
            
            Loaddata();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
