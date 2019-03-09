using System;
using System.Windows.Forms;

namespace KitBoxApplication
{
    public partial class Dashboard : Form
    {
        

        public Dashboard()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void PlaceHolderText(object sender, EventArgs e)
        {
            textBoxSubscribe.Text = " ";
        }

        private void PlaceHolderTextleaving(object sender, EventArgs e)
        {
            if (textBoxSubscribe.Text.Length == 0)
            {
                textBoxSubscribe.Text = "example@mail.com";
            }          
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            homePage3.Visible = true;
            creation2.Visible = false;
            cartPage1.Visible = false;
        }

        private void ButtonCreation_Click(object sender, EventArgs e)
        {
            homePage3.Visible = false;
            creation2.Visible = true;
            cartPage1.Visible = false;
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            homePage3.Visible = false;
            creation2.Visible = false;
            cartPage1.Visible = true;


            /*
            if cartPage is Empty {
                Look at dictionnary containing cabinets and build the differents cabinet's tabs 
            }
            else {
                if cartPage same as previously {
                    Don't do anything
                }
                else {
                    Go through the dictionnary containing cabinets and add the missing onces
                }
            }
             */
            //Checking if cartPage is Empty
            Control tabControl = cartPage1.Controls[0];
            Control tabPage1 = tabControl.Controls[0];
            if (tabPage1.Text == "Empty")
            {
                
            }
            else
            {

            }
            
        }
    }
}
