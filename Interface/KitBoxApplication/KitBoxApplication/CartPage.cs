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
            tabControl1.TabPages.Clear(); //Clear the tabs
            MessageBox.Show(jsonCart.ToString());
            //For every cabinet of the json
            for (int cabinetCount = 0; cabinetCount < jsonCart.Count; cabinetCount++)
            {
                //Get the elements of the cabinet
                JObject cabinetContains = jsonCart["Cabinet " + cabinetCount.ToString()].Value<JObject>();
                MessageBox.Show(cabinetContains.ToString());
                //Add a tab for the cabinet
                TabPage addedCabinePage = new TabPage(Name = "Cabine " + (cabinetCount + 1).ToString());
                addedCabinePage.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
                tabControl1.TabPages.Add(addedCabinePage);
                int floorCount = 0;

                for (floorCount = 0; floorCount < cabinetContains.Count-1; floorCount++)
                {
                    JObject floor = cabinetContains["Floor " + floorCount.ToString()].Value<JObject>();
                    MessageBox.Show(floor.ToString());

                    //Creating a GroupBox for a box
                    GroupBox floorGroup = new GroupBox();
                    floorGroup.Text = "Box " + (floorCount+1).ToString();
                    floorGroup.AutoSize = true;
                    Color color = Color.White;
                    floorGroup.ForeColor = color;
                    floorGroup.Location = new Point(30, 15 + floorCount * 110);
                    addedCabinePage.Controls.Add(floorGroup);
                    int numberOfLabel = 0;
                    int labelLength = 6;

                    //Generates label for every pannel
                    for (numberOfLabel = 0; numberOfLabel < 3; numberOfLabel++)
                    {
                        JObject floorPanel = floor["Panel " + (numberOfLabel+1).ToString()].Value<JObject>();
                        string floorColor = floorPanel["Coleur"].Value<string>();
                        int height = floorPanel["height"].Value<int>();
                        int length = floorPanel["Lenght"].Value<int>();
                        int panelQty = floorPanel["Qty"].Value<int>();
                        string panelPosition = null;

                        Label panelLabel = new Label();
                        panelLabel.AutoSize = true;
                        if (numberOfLabel == 0)
                        {
                            panelPosition = "Back Panel";
                        }
                        if (numberOfLabel == 1)
                        {
                            panelPosition = "Side Panel";
                        }
                        if (numberOfLabel == 2)
                        {
                            panelPosition = "Top or bottom Panel";
                        }
                        panelLabel.Text = String.Format("\n{0}\n\nColor : {1}\nDimensions : {2}x{3}cm\nQuantity : {4}", panelPosition, floorColor.ToString(), height.ToString(), length.ToString(), panelQty.ToString());
                        panelLabel.Location = new Point(labelLength, 28);
                        int panelLabelLength = panelLabel.Width;
                        labelLength += (panelLabelLength+15);
                        floorGroup.Controls.Add(panelLabel);
                    }

                    //Generates label for side Beam
                    JObject sideBeam = floor["Beam 1"].Value<JObject>();
                    int sideBeamLength = sideBeam["Lenght"].Value<int>();
                    int sideBeamQty = sideBeam["Qty"].Value<int>();
                    
                    Label sideBeamLabel = new Label();
                    sideBeamLabel.AutoSize = true;
                    sideBeamLabel.Text = String.Format("\nSide Beam\n\nLength : {0}cm\nQuantity : {1}\n", sideBeamLength.ToString(), sideBeamQty.ToString());
                    sideBeamLabel.Location = new Point(labelLength, 28);
                    int sideBeamLabelLength = sideBeamLabel.Width;
                    labelLength += (sideBeamLabelLength - 20);

                    //Generates label for back Beam
                    JObject backBeam = floor["Beam 2"].Value<JObject>();
                    int backBeamLength = backBeam["Lenght"].Value<int>();
                    int backBeamQty = backBeam["Qty"].Value<int>();

                    Label backBeamLabel = new Label();
                    backBeamLabel.AutoSize = true;
                    backBeamLabel.Text = String.Format("\nBack Beam\n\nLength: {0}cm\nQuantity: {1}\n", backBeamLength.ToString(), backBeamQty.ToString());
                    backBeamLabel.Location = new Point(labelLength, 28);
                    int backBeamLabelLength = backBeamLabel.Width;
                    labelLength += (backBeamLabelLength - 20);

                    //Generates label for front Beam
                    JObject frontBeam = floor["DoorBeam"].Value<JObject>();
                    int frontBeamLength = frontBeam["Lenght"].Value<int>();
                    int frontBeamQty = frontBeam["Qty"].Value<int>();

                    Label frontBeamLabel = new Label();
                    frontBeamLabel.AutoSize = true;
                    frontBeamLabel.Text = String.Format("\nFront Beam\n\nLength: {0}cm\nQuantity: {1}\n", frontBeamLength.ToString(), frontBeamQty.ToString());
                    frontBeamLabel.Location = new Point(labelLength, 28);
                    int frontBeamLabelLength = frontBeamLabel.Width;
                    labelLength += (frontBeamLabelLength - 20);

                    floorGroup.Controls.Add(sideBeamLabel);
                    floorGroup.Controls.Add(backBeamLabel);
                    floorGroup.Controls.Add(frontBeamLabel);

                    //Generates label for cleat
                    JObject cleat = floor["Cleat"].Value<JObject>();
                    int cleatLength = cleat["Lenght"].Value<int>();
                    int cleatQty = cleat["Qty"].Value<int>();

                    Label cleatLabel = new Label();
                    cleatLabel.AutoSize = true;
                    cleatLabel.Text = String.Format("\nCleat\n\nLength: {0}cm\nQuantity: {1}\n", cleatLength.ToString(), cleatQty.ToString());
                    cleatLabel.Location = new Point(labelLength, 28);
                    int cleatLabelLenght = cleatLabel.Width;
                    labelLength += (cleatLabelLenght - 20);

                    floorGroup.Controls.Add(cleatLabel);

                    //Generates label for angles
                    JObject angle = cabinetContains["Angle"].Value<JObject>();
                    int angleLength = angle["Length"].Value<int>();
                    string angleColor = angle["Color"].Value<string>();
                    int angleQty = angle["Quantity"].Value<int>();

                    Label angleLabel = new Label();
                    angleLabel.AutoSize = true;
                    angleLabel.Text = String.Format("\nAngle\n\nLength: {0}cm\nColor : {1}\nQuantity: {2}\n", angleLength.ToString(), angleColor, angleQty.ToString());
                    angleLabel.Location = new Point(labelLength, 28);
                    int angleLabelLenght = angleLabel.Width;
                    labelLength += (angleLabelLenght - 20);

                    floorGroup.Controls.Add(angleLabel);

                    //Generates label for the doors
                    try
                    {
                        JObject doors = floor["DoubleDoors"].Value<JObject>();
                        int doorHeight = doors["height"].Value<int>();
                        int doorLength = doors["Lenght"].Value<int>();
                        string doorMaterial = doors["Material"].Value<string>();
                        int doorQty = doors["Qty"].Value<int>();

                        JObject knop = doors["Knop"].Value<JObject>();
                        int knopQty = knop["Quantity"].Value<int>();

                        Label doorLabel = new Label();
                        doorLabel.AutoSize = true;
                        doorLabel.Text = String.Format("Double Doors\n\nHeight : {0}cm\nLength : {1}cm\nColor (or Material) : {2}\nGot {3} knops\nQuantity : {4}", doorHeight.ToString(), doorLength.ToString(), doorMaterial, knopQty.ToString(), doorQty.ToString());
                        doorLabel.Location = new Point(labelLength, 28);
                        int doorLabelLenght = doorLabel.Width;
                        labelLength += (doorLabelLenght);

                        floorGroup.Controls.Add(doorLabel);
                    }
                    catch
                    {
                        
                    }

                }
                if (floorCount >= 7)
                {
                    addedCabinePage.AutoScroll = true;
                    addedCabinePage.AutoScrollMargin = new Size(20,5);
                }
                
            }
            

            
        }


    }
}
