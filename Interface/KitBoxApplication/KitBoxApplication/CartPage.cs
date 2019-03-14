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

        public CartPage()
        {
            InitializeComponent();
        }

        public static Cart Cart { get => cart; set => cart = value; }


        JObject jsonCart = cart.ShowCart();
        
        
        //MessageBox.Show(jsonCart.ToString());
        //MessageBox.Show(jsonCart.First.ToString());

    }
}
