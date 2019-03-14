using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitBoxSourceCode;
using Newtonsoft.Json.Linq;


namespace KitBoxApplication
{
    public partial class CartPage : UserControl
    {

        private static Cart cart;
        private JObject jsonCart;

        public static Cart Cart { get => cart; set => cart = value; }

        public CartPage()
        {
            InitializeComponent();
        }

        public void Load_Json()
        {
            jsonCart = cart.ShowCart();
            Create_Layout();

        }

        private void Create_Layout()
        {
            MessageBox.Show(jsonCart.ToString());
            JToken totalCart = jsonCart.First;
            JToken firstCabinet = totalCart.First;
            MessageBox.Show(totalCart.ToString());
            MessageBox.Show(firstCabinet.ToString());
            MessageBox.Show(jsonCart.First.First.First.Next.ToString());
        }


    }
}
