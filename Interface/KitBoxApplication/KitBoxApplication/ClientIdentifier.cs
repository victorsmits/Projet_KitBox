using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace KitBoxApplication
{
    public partial class ClientIdentifier : UserControl
    {
        public ClientIdentifier()
        {
            InitializeComponent();
        }

        private bool TestCorrectMail(string mail)
        {
            Regex typeMail = new Regex(@"^[a-z0-9]+@[a-z]+\.{1}[a-z]+$");
            return typeMail.IsMatch(mail);
        }

        private void comfirmButton_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            if (TestCorrectMail(mail)) {
                if (checkBox1.Checked)
                {
                    //TODO request for the subscribe
                }
                //TODO request for the mail
                this.Visible = false;
                TabControl tabControl = (TabControl)this.Parent.Controls[4];
                tabControl.Visible = true;
                tabControl.TabPages.Clear();
                TabPage emptyCart = new TabPage(Name = "Empty");
                emptyCart.BackColor = Color.FromArgb(41, 44, 51);
                tabControl.TabPages.Add(emptyCart);

                JObject json = CartPage.Cart.ShowCart();
                //TODO send the json to database

                CartPage.Cart = null;

                MessageBox.Show("Your order has been registered successfuly!");
            }
            else
            {
                MessageBox.Show("Please enter a valid mail address");
                textBox1.Text = "";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TabControl tabControl = (TabControl)this.Parent.Controls[4];
            tabControl.Visible = true;
        }
    }
}
