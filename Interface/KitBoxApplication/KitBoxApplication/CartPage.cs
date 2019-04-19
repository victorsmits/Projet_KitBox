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
                if (cart != null)
                {
                    comfirmCartButton.Visible = true;
                    totalLabel.Visible = true;
                    costLabel.Visible = true;
                }
                Create_Layout();
            }
            catch(Newtonsoft.Json.JsonReaderException e)
            {
                tabControl1.TabPages.Clear();
                TabPage emptyCart = new TabPage(Name = "Empty");
                emptyCart.BackColor = Color.FromArgb(41, 44, 51);
                tabControl1.TabPages.Add(emptyCart);
                comfirmCartButton.Visible = false;
                costLabel.Visible = false;
                totalLabel.Visible = false;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void  deleteButton_Clicked(object sender, EventArgs e)
        {
            //Get the index of the cabinet from parent of the button
            Control button = (Control)sender;
            Control tabPage = button.Parent;
            string tabName = tabPage.Text;
            string[] list = tabName.Split(' ');
            int index = (int.Parse(list[1])-1);
            cart.DelCabinet(index);
            MessageBox.Show("L'armoire a été supprimé");
            Load_Json();
        }

        private void Create_Layout()
        {
            
            if (jsonCart.ToString() == "{}")
            {
                tabControl1.TabPages.Clear();
                TabPage emptyCart = new TabPage(Name = "Empty");
                emptyCart.BackColor = Color.FromArgb(41, 44, 51);
                tabControl1.TabPages.Add(emptyCart);
                comfirmCartButton.Visible = false;
                costLabel.Visible = false;
                totalLabel.Visible = false;
            }
            else
            {
                tabControl1.TabPages.Clear(); //Clear the tabs

                //For every cabinet of the json
                for (int cabinetCount = 0; cabinetCount < jsonCart.Count - 1; cabinetCount++)
                {
                    bool availability = false;

                    //Get the elements of the cabinet
                    JObject cabinetContains = jsonCart["Cabinet " + cabinetCount.ToString()].Value<JObject>();
                    //Add a tab for the cabinet
                    TabPage addedCabinePage = new TabPage(Name = "Cabine " + (cabinetCount + 1).ToString());
                    addedCabinePage.BackColor = Color.FromArgb(41, 44, 51);
                    tabControl1.TabPages.Add(addedCabinePage);
                    int floorCount = 0;

                    //Add a delete button
                    Button deleteButton = new Button();
                    Image Beating_Cabinet = new Bitmap(@"\images\Beating_Cabinet.png");
                    deleteButton.BackgroundImage = Beating_Cabinet;
                    deleteButton.Click += deleteButton_Clicked;
                    deleteButton.Location = new Point(981, 15);
                    deleteButton.Size = new Size(75, 61);
                    addedCabinePage.Controls.Add(deleteButton);


                    //Generates label for angles
                    JObject angle = cabinetContains["Angle"].Value<JObject>();
                    int angleLength = angle["Length"].Value<int>();
                    string angleColor = angle["Color"].Value<string>();
                    int angleQty = angle["Quantity"].Value<int>();

                    Label angleLabel = new Label();
                    angleLabel.AutoSize = true;
                    angleLabel.Text = String.Format("\nAngle\n\nLength: {0}cm\nColor : {1}\nQuantity: {2}\n", angleLength.ToString(), angleColor, angleQty.ToString());
                    angleLabel.Location = new Point(30, 5);
                    int angleLabelLenght = angleLabel.Width;

                    addedCabinePage.Controls.Add(angleLabel);

                    int labelLength = 15;

                    for (floorCount = 0; floorCount < cabinetContains.Count - 2; floorCount++)
                    {
                        labelLength = 15;
                        JObject floor = cabinetContains["Floor " + floorCount.ToString()].Value<JObject>();
                        //Check if parts are available
                        JObject panel1 = floor["Panel 1"].Value<JObject>();
                        JObject panel2 = floor["Panel 2"].Value<JObject>();
                        JObject panel3 = floor["Panel 3"].Value<JObject>();
                        JObject cleat = floor["Cleat"].Value<JObject>();
                        JObject beam1 = floor["Beam 1"].Value<JObject>();
                        JObject beam2 = floor["Beam 2"].Value<JObject>();
                        JObject doorBeam = floor["DoorBeam"].Value<JObject>();
                        
                        int panel1Qty = panel1["Qty"].Value<int>();
                        int panel2Qty = panel2["Qty"].Value<int>();
                        int panel3Qty = panel3["Qty"].Value<int>();
                        int cleatQty = cleat["Qty"].Value<int>();
                        int beam1Qty = beam1["Qty"].Value<int>();
                        int beam2Qty = beam2["Qty"].Value<int>();
                        int doorBeamQty = doorBeam["Qty"].Value<int>();

                        int panel1Stk = panel1["Remaining Stock"].Value<int>();
                        int panel2Stk = panel2["Remaining Stock"].Value<int>();
                        int panel3Stk = panel3["Remaining Stock"].Value<int>();
                        int cleatStk = cleat["Remaining Stock"].Value<int>();
                        int beam1Stk = beam1["Remaining Stock"].Value<int>();
                        int beam2Stk = beam2["Remaining Stock"].Value<int>();
                        int doorBeamStk = doorBeam["Remaining Stock"].Value<int>();
                        
                        bool panel1Avail = panel1Stk >= panel1Qty;
                        bool panel2Avail = panel2Stk >= panel2Qty;
                        bool panel3Avail = panel3Stk >= panel3Qty;
                        bool cleatAvail = cleatStk >= cleatQty;
                        bool beam1Avail = beam1Stk >= beam1Qty;
                        bool beam2Avail = beam2Stk >= beam2Qty;
                        bool doorBeamAvail = doorBeamStk >= doorBeamQty;
                        

                        if (panel1Avail && panel2Avail && panel3Avail && cleatAvail && beam1Avail && beam2Avail && doorBeamAvail)
                        {
                            availability = true;
                        }
                        
                        //Creating a GroupBox for a box
                        GroupBox floorGroup = new GroupBox();
                        floorGroup.Text = "Box " + (floorCount + 1).ToString();
                        floorGroup.AutoSize = true;
                        Color color = Color.White;
                        floorGroup.ForeColor = color;
                        floorGroup.Location = new Point(30, 100 + floorCount * 110);
                        addedCabinePage.Controls.Add(floorGroup);

                        //Generates label for dimension
                        string floorColor = "";
                        int HEIGHT = 4;
                        int LENGTH = 0;
                        int DEPTH = 0;
                        Label boxDimension = new Label();
                        Label boxColor = new Label();
                        boxDimension.AutoSize = true;
                        boxColor.AutoSize = true;

                        for (int numberOfLabel = 0; numberOfLabel < 3; numberOfLabel++)
                        {
                            JObject floorPanel = floor["Panel " + (numberOfLabel + 1).ToString()].Value<JObject>();
                            floorColor = floorPanel["Coleur"].Value<string>();
                            int height = floorPanel["Height"].Value<int>();
                            int length = floorPanel["Length"].Value<int>();
                            int panelQty = floorPanel["Qty"].Value<int>();
                            
                            if (numberOfLabel == 0)
                            {
                                HEIGHT += height;
                                LENGTH += length;
                            }
                            if (numberOfLabel == 1)
                            {
                                DEPTH += length;
                            }
                            if (numberOfLabel == 2)
                            {
                                boxColor.Text = String.Format("Color\n\n{0}", floorColor);
                            }
                        }

                        boxDimension.Text = String.Format("Dimensions\n\nHeight : {0}cm\nWidth : {1}cm\nDepth : {2}cm", HEIGHT.ToString(), LENGTH.ToString(), DEPTH.ToString());
                        boxDimension.Location = new Point(labelLength, 28);
                        int panelLabelLength = boxDimension.Width;
                        labelLength += (panelLabelLength);
                        floorGroup.Controls.Add(boxDimension);

                        //Generates label for color
                        boxColor.Location = new Point(labelLength, 28);
                        labelLength += (panelLabelLength - 30);
                        floorGroup.Controls.Add(boxColor);

                        costLabel.Text = jsonCart["CartPrice"] + "€";

                        //Generates label for Double doors
                        try
                        {
                            JObject door = floor["DoubleDoors"].Value<JObject>();
                            int doorHeight = door["Height"].Value<int>();
                            int doorLength = door["Length"].Value<int>();
                            string doorMaterial = door["Material"].Value<string>();
                            int doorQty = door["Qty"].Value<int>();
                            int doorStk = door["Remaining Stock"].Value<int>() * 2;
                            bool doorAvail = doorStk >= doorQty;

                            JObject knop = door["Knop"].Value<JObject>();
                            int knopQty = knop["Quantity"].Value<int>();
                            int knopStk = knop["Remaining Stock"].Value<int>();
                            bool knopAvail = knopStk >= knopQty;

                            Label doorLabel = new Label();
                            doorLabel.AutoSize = true;
                            doorLabel.Text = String.Format("Double Doors\n\nColor (or Material) : {0}\nGot {1} knops\n", doorMaterial, knopQty.ToString());
                            doorLabel.Location = new Point(labelLength, 28);
                            int doorLabelLenght = doorLabel.Width;
                            labelLength += (doorLabelLenght);

                            floorGroup.Controls.Add(doorLabel);
                            
                            if (doorAvail && knopAvail)
                            {
                                availability = true;
                            }
                        }
                        catch
                        {

                        }

                        //Generate label if material available 
                        Label availableMaterial = new Label();
                        availableMaterial.AutoSize = true;
                        availableMaterial.Location = new Point(floorGroup.Width + 35, 120 + floorCount * 110);
                        //TODO : modify availability in function of the different parts
                        if (availability)
                        {
                            Color Green = Color.FromName("Green");
                            availableMaterial.ForeColor = Green;
                            availableMaterial.Text = "All the parts are available";
                        }
                        else
                        {
                            Color Red = Color.FromName("Red");
                            availableMaterial.ForeColor = Red;
                            availableMaterial.Text = "Not all the parts are available";
                        }
                        addedCabinePage.Controls.Add(availableMaterial);

                    }
                    if (floorCount >= 4)
                    {
                        addedCabinePage.AutoScroll = true;
                        addedCabinePage.AutoScrollMargin = new Size(20, 5);
                    }

                }
            }
        }

        private void comfirmCartButton_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            totalLabel.Visible = false;
            comfirmCartButton.Visible = false;
            costLabel.Visible = false;
            clientIdentifier1.Visible = true;
        }
    }
}
