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
        }

        private void ButtonCreation_Click(object sender, EventArgs e)
        {
            homePage3.Visible = false;
            creation2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

<<<<<<< HEAD
        private void homePage2_Load(object sender, EventArgs e)
        {
||||||| merged common ancestors
=======
        //test

>>>>>>> b7a123e7cb02b5d0b85b3596c3da068c6151955a

        }
    }
}
