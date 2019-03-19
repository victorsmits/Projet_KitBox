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

            JToken firstCabinet = jsonCart.First;
            JToken firstFloor = firstCabinet.First;
            JToken nextCabinet = firstCabinet.Next;
            JToken nextFloor = firstFloor.Next;

            MessageBox.Show(jsonCart.Count.ToString());
            MessageBox.Show(firstCabinet.ToString());
            //Generates the first cabinet tab
            TabPage cabine1Page = new TabPage(Name = "Cabine 1");
            cabine1Page.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            Label floorCab1 = new Label();
            floorCab1.Text = "floor : ";
            floorCab1.Location = new Point(29, 26);
            cabine1Page.Controls.Add(floorCab1);
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(cabine1Page);

            try
            {
                for (int cabinetNumber = 0; cabinetNumber <= jsonCart.Count; cabinetNumber++)
                {
                
                    MessageBox.Show("test longueur : " + (cabinetNumber).ToString());
                    MessageBox.Show(nextCabinet.ToString());
                    //Generates the following cabinet tabs
                    TabPage addedCabinePage = new TabPage(Name = "Cabine "+ (cabinetNumber + 2).ToString());
                    addedCabinePage.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
                    Label floor = new Label();
                    floor.Text = "floor : ";
                    floor.Location = new Point(29, 26);
                    addedCabinePage.Controls.Add(floor);
                    tabControl1.TabPages.Add(addedCabinePage);
                    nextCabinet = nextCabinet.Next; 
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("c'est tout : ");
            }

        }


    }
}
