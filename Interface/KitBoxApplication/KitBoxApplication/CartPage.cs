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
            try
            {
                jsonCart = cart.ShowCart();
                Create_Layout();
            }
            catch
            {

            }

        }


        private void Create_Layout()
        {
            tabControl1.TabPages.Clear();
            MessageBox.Show(jsonCart.ToString());
            for (int cabinetCount = 0; cabinetCount < jsonCart.Count; cabinetCount++)
            {
                JObject cabinetContains = jsonCart["Cabinet " + cabinetCount.ToString()].Value<JObject>();
                MessageBox.Show(cabinetContains.ToString());

                TabPage addedCabinePage = new TabPage(Name = "Cabine " + (cabinetCount + 1).ToString());
                addedCabinePage.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
                tabControl1.TabPages.Add(addedCabinePage);
                for (int floorCount = 0; floorCount < cabinetContains.Count; floorCount++)
                {
                    JObject floor = cabinetContains["Floor " + floorCount.ToString()].Value<JObject>();
                    MessageBox.Show(floor.ToString());

                    //Creating a GroupBox for a box
                    GroupBox floorGroup = new GroupBox();
                    floorGroup.Text = "Box " + (floorCount+1).ToString();
                    floorGroup.AutoSize = true;
                    Color color = Color.White;
                    floorGroup.ForeColor = color;
                    floorGroup.Location = new Point(30, 25 + floorCount * 106);
                    addedCabinePage.Controls.Add(floorGroup);

                    //Get Panel caract
                    JObject floorPanel = floor["Panel"].Value<JObject>();

                    string floorColor = floorPanel["Coleur"].Value<string>();
                    int height = floorPanel["Height"].Value<int>();
                    int length = floorPanel["Lenght"].Value<int>();
                    int qty = floorPanel["Qty"].Value<int>();

                    Label floorColorLabel = new Label();
                    floorColorLabel.AutoSize = true;
                    floorColorLabel.Text = String.Format("Panel\n\nColor : {0}\nDimensions : {1}x{2}cm\nQuantity : {3}", floorColor.ToString(), height.ToString(), length.ToString(), qty.ToString());
                    floorColorLabel.Location = new Point(6, 28);
                    floorGroup.Controls.Add(floorColorLabel);
                }
                
            }
            

            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
