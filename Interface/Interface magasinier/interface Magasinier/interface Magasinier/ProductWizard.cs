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
    public partial class ProductWizard : UserControl
    {
        OleDbDataReader dr;
        public ProductWizard()
        {
            InitializeComponent();
        }
        private void LoadList(object sender, EventArgs e) //loading data
        {
            SqlOledb.SqlOledb.connection("C:\\Users\\dtheo\\Documents\\GitHub\\Projet_KitBox\\Database\\DB_Lespieces.accdb;");
            Loaddata();
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                IdSupplier.SelectedIndex = l.SelectedIndex;
                ReferenceSupplier.SelectedIndex = l.SelectedIndex;

                SupplierBox.Text = IdSupplier.SelectedItem.ToString();
            }
        }
        public void Loaddata() //Loading de data into the differents listbox
        {
            IdSupplier.Items.Clear();
            ReferenceSupplier.Items.Clear();

            try
            {
                string q = "select * from Fournisseur";
                SqlOledb.SqlOledb.cmd.CommandText = q; // execution of a SQL instruction
                SqlOledb.SqlOledb.cn.Open();
                dr = SqlOledb.SqlOledb.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        IdSupplier.Items.Add(dr[0].ToString());
                        ReferenceSupplier.Items.Add(dr[1].ToString());
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

            private void finishButton_Click(object sender, EventArgs e)
            {

                string rsq = "INSERT INTO Req (Référence,Enstock,StockMinimum," +
                             "PrixClient,Nb_PiecesCasier,Dimensions_cm,Division," +
                             "hauteur,profondeur,largeur,Reservation,Code,Couleur," +
                             "Prix,Delai,FK_Fournisseur) VALUES ('"
                                + referenceTextBox.Text.ToString() + "','"
                                + InitialStockNum.Text.ToString() + "','"
                                + MinimumStockNum.Text.ToString() + "','"
                                + clientPriceTextBox.Text.ToString() + "','"
                                + numberPerBoxNum.Text.ToString() + "','"
                                + DimensionsTextBox.Text.ToString() + "','"
                                + divisionTextBox.Text.ToString() + "','"
                                + HeigthTextBox.Text.ToString() + "','"
                                + depthTextBox.Text.ToString() + "','"
                                + widthTextBox.Text.ToString() + "','0','"
                                + codeTextBox.Text.ToString() + "','"
                                + colorTextBox.Text.ToString() + "','"
                                + SupplierBox.Text.ToString() + "','"
                                + supplierPriceTextBox.Text.ToString() + "','"
                                + delayNum.Text.ToString() + "')";

                SqlOledb.SqlOledb.SqlRequest(rsq);
                
                MessageBox.Show("Congrats! You added a new product");

                //Reset of every box
                referenceTextBox.Text = "";
                InitialStockNum.Value = 0;
                MinimumStockNum.Value = 0;
                clientPriceTextBox.Text = "";
                numberPerBoxNum.Value = 0;
                DimensionsTextBox.Text = "";
                divisionTextBox.Text = "";
                HeigthTextBox.Text = "";
                depthTextBox.Text = "";
                widthTextBox.Text = "";
                codeTextBox.Text = "";
                colorTextBox.Text = "";
                SupplierBox.Text = "";
                supplierPriceTextBox.Text = "";
                delayNum.Value = 0;


            }


            private void checkingToEnable(object sender, EventArgs e)
            {
                //Check if every box has a piece ofinformation
                bool refCheck = referenceTextBox.Text != "";
                bool initStockCheck = InitialStockNum.Value != 0;
                bool minStockCheck = MinimumStockNum.Value != 0;
                bool clientPriceCheck = clientPriceTextBox.Text != "";
                bool numberPerBoxCheck = numberPerBoxNum.Value != 0;
                bool dimensionCheck = DimensionsTextBox.Text != "";
                bool divisionCheck = divisionTextBox.Text != "";
                bool heightCheck = HeigthTextBox.Text != "";
                bool depthCheck = depthTextBox.Text != "";
                bool widthCheck = widthTextBox.Text != "";
                bool codeCheck = codeTextBox.Text != "";
                bool colorCheck = colorTextBox.Text != "";
                bool supplierCheck = SupplierBox.Text != "";
                bool supplierPriceCheck = supplierPriceTextBox.Text != "";
                bool delayCheck = delayNum.Value != 0;

                if (refCheck & initStockCheck & minStockCheck & clientPriceCheck
                    & numberPerBoxCheck & dimensionCheck & divisionCheck & heightCheck
                    & depthCheck & widthCheck & codeCheck & colorCheck & supplierCheck & supplierPriceCheck & delayCheck)
                {
                    finishButton.Enabled = true;
                }
                else
                {
                    finishButton.Enabled = false;
                }
            }
        

        private void Refresh_Click(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
    }


        
    
