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
        public ProductWizard()
        {
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {

            string rsq = "INSERT INTO Req (Référence,Enstock,StockMinimum,"+
                         "PrixClient,Nb_PiecesCasier,Dimensions_cm,Division,"+
                         "hauteur,profondeur,largeur,Reservation,Code,Couleur,"+
                         "Prix,Delai,FK_Fournisseur) VALUES ('"
                            + referenceTextBox.Text.ToString() +"','" 
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
            MessageBox.Show(rsq);
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


    }
}
