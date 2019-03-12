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

        private void nextButton_Click(object sender, EventArgs e)
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

            if (refCheck & initStockCheck & minStockCheck & clientPriceCheck 
                & numberPerBoxCheck & dimensionCheck & divisionCheck & heightCheck 
                & depthCheck & widthCheck & codeCheck & colorCheck)
            {
                Control form = this.Parent;     //Chooses the container in which it is (in our case the Tab "Add a product")
                Control supplier = form.Controls[0];    //Gets the first item of the list of controler (here SupplierWizard)
                this.Visible = false;   //Makes this wizard invisible
                supplier.Visible = true;    //Makes the supplier wizard appear

                    string rsq = "INSERT INTO Piece VALUES ('TRG','82','32','52','4','62','0','62','0','0','Trav','Pasde','0')";
                                                              /*+ referenceTextBox.Text.ToString() + "','" 
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
                                                              + colorTextBox.Text.ToString() + "')";*/


                    SqlOledb.SqlOledb.SqlRequest(rsq);
                   
                MessageBox.Show("Enter all the missing information");

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
            }
            else
            {
                MessageBox.Show("Enter all the missing information");
            }
            

        }
    }
}
