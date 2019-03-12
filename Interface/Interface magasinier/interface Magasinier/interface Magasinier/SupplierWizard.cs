using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_Magasinier
{
    public partial class SupplierWizard : UserControl
    {
        public SupplierWizard()
        {
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            //Check if every box has a piece of information
            bool supplierCheck = SupplierList.Text != "";
            bool supplierPriceCheck = supplierPriceTextBox.Text != "";
            bool delayCheck = delayNum.Value != 0;

            if (supplierCheck & supplierPriceCheck & delayCheck)
            {
                Control form = this.Parent;     //Chooses the container in which it is (in our case the Tab "Add a product")
                Control product = form.Controls[1];    //Gets the first item of the list of controler (here ProductWizard)
                this.Visible = false;   //Makes this wizard invisible
                product.Visible = true;    //Makes the product wizard appear
                MessageBox.Show("Congrats! You added a new product");

                //Reset of every box
                SupplierList.Text = "";
                supplierPriceTextBox.Text = "";
                delayNum.Value = 0;

                
            }
            else
            {
                MessageBox.Show("Enter all the missing information");
            }

        }
    }
}
