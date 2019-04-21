using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace KitBoxApplication
{
    public partial class Dashboard : Form
    {
        private static JObject jsonCart;

        public static JObject JsonCart
        {
            get => jsonCart;
            set => jsonCart = value;
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            homePage3.Visible = true;
            creation2.Visible = false;
            cartPage1.Visible = false;
            aboutUs1.Visible = false;
        }

        private void ButtonCreation_Click(object sender, EventArgs e)
        {
            homePage3.Visible = false;
            creation2.Visible = true;
            cartPage1.Visible = false;
            aboutUs1.Visible = false;
        }

        private void ButtonCart_Click(object sender, EventArgs e)
        {
            homePage3.Visible = false;
            creation2.Visible = false;
            cartPage1.Visible = true;
            aboutUs1.Visible = false;

            cartPage1.Load_Json();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            homePage3.Visible = false;
            creation2.Visible = false;
            cartPage1.Visible = false;
            aboutUs1.Visible = true;
        }
    }
}
