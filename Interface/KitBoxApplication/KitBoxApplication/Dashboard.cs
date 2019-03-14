using System;
using System.Windows.Forms;
using KitBoxSourceCode;

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

            //MessageBox.Show(creation2.Controls.GetChildIndex());
            //MessageBox.Show(creation2.Controls[0].Controls[5].Cart);
            //creation2.Controls[0].Controls[5];

            Cart cartToProcess = BoxStandard.Cart;
            MessageBox.Show(cartToProcess.ShowCart().ToString());

        }
    }
}
