using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
            homePage1.Visible = true;
            creation1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homePage1.Visible = false;
            creation1.Visible = true;
        }

        //test


    }
}
