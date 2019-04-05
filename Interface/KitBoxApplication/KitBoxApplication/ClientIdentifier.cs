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
            Regex typeMail = new Regex(@"^[a-z0-9]+@[a-z]+\.{1}[a-z]+$");
            return typeMail.IsMatch(mail);
        }

        private void comfirmButton_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            JObject json = CartPage.Cart.ShowCart();
            if (TestCorrectMail(mail)) {
                if (checkBox1.Checked)
                {
                    string rqst = "INSERT INTO ComClient (Status,Date_Commande,Prix,ListeMateriel,Email,Newsletter) VALUES ('Progress','02','20','"+ json.ToString() +"','" + mail + "','Yes')";
                    SqlOledb.Oledb.SqlRequest(rqst);
                }
                else
                {
                    string rqst = "INSERT INTO ComClientS (Status,Date_Commande,Prix,ListeMateriel,Email,Newsletter) VALUES ('Progress','02','20','" + json.ToString() + "','" + mail + "','No')";
                    SqlOledb.Oledb.SqlRequest(rqst);
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
