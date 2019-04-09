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
using SqlOledb;

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
            Regex typeMail = new Regex(@"^[a-zA-Z0-9]+@[a-z]+\.{1}[a-z]+$");
            return typeMail.IsMatch(mail);
        }

        private void comfirmClientButton_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            JObject json = CartPage.Cart.ShowCart();
            JToken cartPrice = json["CartPrice"];
            if (TestCorrectMail(mail)) {
                if (checkBox1.Checked)
                {
                    string rqst = "INSERT INTO ComClient (Status,Date_Commande,Prix,ListeMateriel,Email,Newsletter) VALUES ('Progress','02','"+ cartPrice.ToString() +"','"+ json.ToString() +"','" + mail + "','Yes')";
                    SqlOledb.Oledb.SqlRequestInsert(rqst);
                }
                else
                {
                    string rqst = "INSERT INTO ComClient (Status,Date_Commande,Prix,ListeMateriel,Email,Newsletter) VALUES ('Progress','02','" + cartPrice.ToString() + "','" + json.ToString() + "','" + mail + "','No')";
                    SqlOledb.Oledb.SqlRequestInsert(rqst);
                }

                this.Visible = false;
                TabControl tabControl = (TabControl)this.Parent.Controls[4];
                tabControl.Visible = true;
                tabControl.TabPages.Clear();
                TabPage emptyCart = new TabPage(Name = "Empty");
                emptyCart.BackColor = Color.FromArgb(41, 44, 51);
                tabControl.TabPages.Add(emptyCart);

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
