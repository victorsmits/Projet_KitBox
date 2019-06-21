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
using System.IO;
using SqlOledb;

namespace KitBoxApplication
{
    public partial class CartPage : UserControl
    {

        private static Cart cart;
        private JObject jsonCart;

        public static Cart Cart { get => cart; set => cart = value; }
        bool globalAvail = true;

        public CartPage()
        {
            InitializeComponent();

            // enables design of tabheader
            this.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabPageBox1_DrawItem);

            tabControl.ItemSize = new Size(70, 30);
        }

        //Look if the cart is empty. If it is, it will display an empty panel. Otherwise, display the cart
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
                tabControl.TabPages.Clear();
                TabPage emptyCart = new TabPage(Name = "Empty");
                emptyCart.BackColor = Color.FromArgb(41, 44, 51);
                tabControl.TabPages.Add(emptyCart);
                comfirmCartButton.Visible = false;
                costLabel.Visible = false;
                totalLabel.Visible = false;
            }
            catch (NullReferenceException NUL)
            {

            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            //Get the index of the cabinet from parent of the button (which is the tab of the cabinet to delete)
            Control button = (Control)sender;
            Control tabPage = button.Parent;
            string tabName = tabPage.Text;
            string[] list = tabName.Split(' ');
            int index = (int.Parse(list[1])-1);
            cart.DelCabinet(index);
            RemoveReservation(index);
            MessageBox.Show("The cabinet has been deleted succesfully");
            //Reload the cart
            Load_Json();
        }

        //Remove the reservation of every part of the concerned cabinet
        private void RemoveReservation(int cabinetRemoved)
        {
            JObject cabinetContains = jsonCart["Cabinet " + cabinetRemoved.ToString()].Value<JObject>();
            JObject angle = cabinetContains["Angle"].Value<JObject>();
            int angleQty = angle["Quantity"].Value<int>();
            string angleRef = angle["StockRef"].Value<string>();
            for (int floorCount = 0; floorCount < cabinetContains.Count - 2; floorCount++)
            {
                JObject floor = cabinetContains["Floor " + floorCount.ToString()].Value<JObject>();
                JObject panel1 = floor["Panel 1"].Value<JObject>();
                JObject panel2 = floor["Panel 2"].Value<JObject>();
                JObject panel3 = floor["Panel 3"].Value<JObject>();
                JObject cleat = floor["Cleat"].Value<JObject>();
                JObject beam1 = floor["Beam 1"].Value<JObject>();
                JObject beam2 = floor["Beam 2"].Value<JObject>();
                JObject doorBeam = floor["DoorBeam"].Value<JObject>();
                List<string> Ref = new List<string> {
                    panel1["Stockref"].Value<string>(),
                    panel2["Stockref"].Value<string>(),
                    panel3["Stockref"].Value<string>(),
                    cleat["Stockref"].Value<string>(),
                    beam1["Stockref"].Value<string>(),
                    beam2["Stockref"].Value<string>(),
                    doorBeam["Stockref"].Value<string>()
                };
                List<int> Qty = new List<int>
                {
                    panel1["Qty"].Value<int>(),
                    panel2["Qty"].Value<int>(),
                    panel3["Qty"].Value<int>(),
                    cleat["Qty"].Value<int>(),
                    beam1["Qty"].Value<int>(),
                    beam2["Qty"].Value<int>(),
                    doorBeam["Qty"].Value<int>(),
                };

                try
                {
                    JObject door = floor["DoubleDoors"].Value<JObject>();
                    JObject knop = door["Knop"].Value<JObject>();
                    Ref.Add(door["Stockref"].Value<string>());
                    Ref.Add(knop["StockRef"].Value<string>());
                    Qty.Add(door["Qty"].Value<int>()+1);
                    Qty.Add(knop["Quantity"].Value<int>());
                }
                catch
                {

                }

                for (int i = 0; i <= Ref.Count-1; i++)
                {
                    string reference = Ref[i];
                    int qty = Qty[i];
                    Oledb.UndoReservation(qty, reference);
                }
            }
            Oledb.UndoReservation(angleQty, angleRef);
        }

        // function to get relative path to a file
        private string GetRelativePath(string directory)
        {
            char[] test1 = "\\".ToCharArray();
            string[] test = directory.Split(test1);
            string root = test[0];
            string user = test[1];
            string namePC = test[2];
            string dir = root + "\\" + user + "\\" + namePC + "\\";
            return dir;
        }

        private void AddPanelImage(Image imagePanel, System.Windows.Forms.Panel formerPanel, System.Windows.Forms.Panel newPanel)
        {
            newPanel.BackgroundImage = imagePanel;
            newPanel.BackColor = Color.Transparent;
            newPanel.BackgroundImageLayout = ImageLayout.Stretch;
            newPanel.Size = new System.Drawing.Size(300, 600);
            newPanel.Location = new Point(0, -76);
            formerPanel.Controls.Add(newPanel);
        }

        //Create the whole layout of the cart
        private void Create_Layout()
        {
            Color Green = Color.FromName("Green");
            Color Red = Color.FromName("Red");

            if (jsonCart.ToString() == "{}")
            {
                tabControl.TabPages.Clear();   //Clear the tabs
                TabPage emptyCart = new TabPage(Name = "Empty");
                emptyCart.BackColor = Color.FromArgb(41, 44, 51);
                tabControl.TabPages.Add(emptyCart);
                comfirmCartButton.Visible = false;
                costLabel.Visible = false;
                totalLabel.Visible = false;
            }
            else
            {
                tabControl.TabPages.Clear(); 

                //For every cabinet of the json
                for (int cabinetCount = 0; cabinetCount < jsonCart.Count - 1; cabinetCount++)
                {
                    bool availability = false;

                    Font font = new Font("Century Gothic", 9, FontStyle.Bold);
                    //Get the elements of the cabinet
                    JObject cabinetContains = jsonCart["Cabinet " + cabinetCount.ToString()].Value<JObject>();
                    //Add a tab for the cabinet
                    TabPage addedCabinePage = new TabPage(Name = "Cabinet " + (cabinetCount + 1).ToString());
                    addedCabinePage.BackColor = Color.FromArgb(41, 44, 51);
                    tabControl.TabPages.Add(addedCabinePage);
                    int floorCount = 0;

                    //Add a delete button
                    Button deleteButton = new Button();
                    Image Beating_Cabinet = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\images\Beating_Cabinet.png");
                    deleteButton.ImageAlign = ContentAlignment.MiddleCenter;
                    deleteButton.BackgroundImageLayout = ImageLayout.Center;
                    deleteButton.BackgroundImage = Beating_Cabinet;
                    deleteButton.Click += DeleteButton_Clicked;
                    deleteButton.Location = new Point(940, 15);
                    deleteButton.Size = new Size(75, 61);
                    addedCabinePage.Controls.Add(deleteButton);

                    // Create the ToolTip and associate with the Form container.
                    ToolTip toolTip1 = new ToolTip();

                    // Set up the delays for the ToolTip.
                    toolTip1.AutoPopDelay = 5000;
                    toolTip1.InitialDelay = 100;
                    toolTip1.ReshowDelay = 500;
                    // Force the ToolTip text to be displayed whether or not the form is active.
                    toolTip1.ShowAlways = true;

                    // Set up the ToolTip text for the Button and Checkbox.
                    toolTip1.SetToolTip(deleteButton, "Delete Cabinet");


                    //Generates label for angles
                    JObject angle = cabinetContains["Angle"].Value<JObject>();
                    int angleLength = angle["Length"].Value<int>();
                    string angleColor = angle["Color"].Value<string>();
                    int angleQty = angle["Quantity"].Value<int>();
                    int angleStk = angle["Remaining Stock"].Value<int>();
                    bool angleAvail = angleQty <= angleStk;

                    Label angleLabel = new Label();
                    angleLabel.AutoSize = true;
                    angleLabel.Text = "\nAngle : ";
                    angleLabel.Location = new Point(30, 5);

                    Label angleFeatLabel = new Label();
                    angleFeatLabel.AutoSize = true;
                    angleFeatLabel.Text = String.Format("\nLength: {0}cm\nColor : {1}\nQuantity: {2}\n", angleLength.ToString(), angleColor, angleQty.ToString());
                    angleFeatLabel.Location = new Point(110, 5);

                    angleLabel.Font = font;
                    angleFeatLabel.Font = font;
                    int angleLabelLength = angleLabel.Width;

                    //Generates the availability label for the angles
                    Label angleDisponibilityLabel = new Label();
                    angleDisponibilityLabel.AutoSize = true;
                    if (angleAvail)
                    {
                        angleDisponibilityLabel.ForeColor = Green;
                        angleDisponibilityLabel.Text = "Available";
                    }
                    else
                    {
                        angleDisponibilityLabel.ForeColor = Red;
                        angleDisponibilityLabel.Text = "Not available";
                        globalAvail = false;
                    }
                    angleDisponibilityLabel.Location = new Point(220, 30);

                    addedCabinePage.Controls.Add(angleLabel);
                    addedCabinePage.Controls.Add(angleFeatLabel);
                    addedCabinePage.Controls.Add(angleDisponibilityLabel);

                    //Label for the price by cabinet
                    string price = cabinetContains["CabinetPrice"].Value<string>();

                    Label priceLabel = new Label();
                    priceLabel.AutoSize = true;
                    priceLabel.Text = "\nUnit Price :";
                    priceLabel.Location = new Point(400, 5);

                    Label unitPriceLabel = new Label();
                    unitPriceLabel.AutoSize = true;
                    unitPriceLabel.Text = "\n" + price.ToString()+" €";
                    unitPriceLabel.Location = new Point(400, 30);

                    priceLabel.Font = font;
                    unitPriceLabel.Font = font;

                    addedCabinePage.Controls.Add(priceLabel);
                    addedCabinePage.Controls.Add(unitPriceLabel);

                    int labelLength = 15;

                    string floorColor1 = "blanc";
                    string floorColor2 = "blanc";
                    string floorColor3 = "blanc";
                    string floorColor4 = "blanc";
                    string floorColor5 = "blanc";
                    string floorColor6 = "blanc";
                    string floorColor7 = "blanc";
                    string doorMaterial1 = "NoDoor";
                    string doorMaterial2 = "NoDoor";
                    string doorMaterial3 = "NoDoor";
                    string doorMaterial4 = "NoDoor";
                    string doorMaterial5 = "NoDoor";
                    string doorMaterial6 = "NoDoor";
                    string doorMaterial7 = "NoDoor";

                    //For every floor
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
                        
                        List<bool> availabilityList = new List<bool>
                        {
                            panel1["Remaining Stock"].Value<int>() >= panel1["Qty"].Value<int>(),
                            panel2["Remaining Stock"].Value<int>() >= panel2["Qty"].Value<int>(),
                            panel3["Remaining Stock"].Value<int>() >= panel3["Qty"].Value<int>(),
                            cleat["Remaining Stock"].Value<int>() >= cleat["Qty"].Value<int>(),
                            beam1["Remaining Stock"].Value<int>() >= beam1["Qty"].Value<int>(),
                            beam2["Remaining Stock"].Value<int>() >= beam2["Qty"].Value<int>(),
                            doorBeam["Remaining Stock"].Value<int>() >= doorBeam["Remaining Stock"].Value<int>()
                        };

                        if (availabilityList.All(a=>a))
                        {
                            availability = true;
                        }
                        else
                        {
                            availability = false;
                            globalAvail = false;
                        }

                        //Creating a GroupBox for a box
                        GroupBox floorGroup = new GroupBox();
                        floorGroup.Text = "Box " + (floorCount + 1).ToString();
                        floorGroup.AutoSize = true;
                        floorGroup.Font = font;
                        Color color = Color.White;
                        floorGroup.ForeColor = color;
                        floorGroup.Location = new Point(30, 80 + floorCount * 130);
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

                            switch (floorCount)
                            {
                                case 0:
                                    floorColor1 = floorPanel["Coleur"].Value<string>();
                                    break;
                                case 1:
                                    floorColor2 = floorPanel["Coleur"].Value<string>();
                                    break;
                                case 2:
                                    floorColor3 = floorPanel["Coleur"].Value<string>();
                                    break;
                                case 3:
                                    floorColor4 = floorPanel["Coleur"].Value<string>();
                                    break;
                                case 4:
                                    floorColor5 = floorPanel["Coleur"].Value<string>();
                                    break;
                                case 5:
                                    floorColor6 = floorPanel["Coleur"].Value<string>();
                                    break;
                                case 6:
                                    floorColor7 = floorPanel["Coleur"].Value<string>();
                                    break;
                            }

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

                            switch (floorCount)
                            {
                                case 0:
                                    doorMaterial1 = door["Material"].Value<string>();
                                    break;
                                case 1:
                                    doorMaterial2 = door["Material"].Value<string>();
                                    break;
                                case 2:
                                    doorMaterial3 = door["Material"].Value<string>();
                                    break;
                                case 3:
                                    doorMaterial4 = door["Material"].Value<string>();
                                    break;
                                case 4:
                                    doorMaterial5 = door["Material"].Value<string>();
                                    break;
                                case 5:
                                    doorMaterial6 = door["Material"].Value<string>();
                                    break;
                                case 6:
                                    doorMaterial7 = door["Material"].Value<string>();
                                    break;
                            }

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
                            else
                            {
                                globalAvail = false;
                            }
                        }
                        catch
                        {

                        }

                        //Generate label if material available
                        Label availableMaterial = new Label();
                        availableMaterial.AutoSize = true;
                        availableMaterial.Location = new Point(floorGroup.Width + 35, 100 + floorCount * 130);

                        if (availability)
                        {
                            availableMaterial.ForeColor = Green;
                            availableMaterial.Text = "All the parts are available";
                        }
                        else
                        {
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

                    System.Windows.Forms.Panel panelShelf1 = new System.Windows.Forms.Panel();
                    System.Windows.Forms.Panel panelShelf2 = new System.Windows.Forms.Panel();
                    System.Windows.Forms.Panel panelShelf3 = new System.Windows.Forms.Panel();
                    System.Windows.Forms.Panel panelShelf4 = new System.Windows.Forms.Panel();
                    System.Windows.Forms.Panel panelShelf5 = new System.Windows.Forms.Panel();
                    System.Windows.Forms.Panel panelShelf6 = new System.Windows.Forms.Panel();
                    System.Windows.Forms.Panel panelShelf7 = new System.Windows.Forms.Panel();

                    if (cabinetContains.Count - 2 > 0)
                    {
                        Image myImage1 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + floorColor1 + doorMaterial1 + ".png");
                        panelShelf1.BackgroundImage = myImage1;
                        panelShelf1.BackColor = Color.Transparent;
                        panelShelf1.BackgroundImageLayout = ImageLayout.Stretch;
                        panelShelf1.Size = new System.Drawing.Size(300, 600);
                        panelShelf1.Location = new Point(600, (-200 + floorCount * 76/5*2));

                        if (cabinetContains.Count - 2 > 1)
                        {
                            Image myImage2 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + floorColor2 + doorMaterial2 + ".png");
                            AddPanelImage(myImage2,panelShelf1,panelShelf2);
                            if (cabinetContains.Count - 2 > 2)
                            {
                                Image myImage3 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + floorColor3 + doorMaterial3 + ".png");
                                AddPanelImage(myImage3, panelShelf2, panelShelf3);

                                if (cabinetContains.Count - 2 > 3)
                                {
                                    Image myImage4 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + floorColor4 + doorMaterial4 + ".png");
                                    AddPanelImage(myImage4, panelShelf3, panelShelf4);

                                    if (cabinetContains.Count - 2 > 4)
                                    {
                                        Image myImage5 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + floorColor5 + doorMaterial5 + ".png");
                                        AddPanelImage(myImage5, panelShelf4, panelShelf5);

                                        if (cabinetContains.Count - 2 > 5)
                                        {
                                            Image myImage6 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + floorColor6 + doorMaterial6 + ".png");
                                            AddPanelImage(myImage6, panelShelf5, panelShelf6);

                                            if (cabinetContains.Count - 2 > 6)
                                            {
                                                Image myImage7 = new Bitmap(GetRelativePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + @"Documents\GitHub\Projet_KitBox\Interface\KitBoxApplication\KitBoxApplication\Resources\" + floorColor7 + doorMaterial7 + ".png");
                                                AddPanelImage(myImage7, panelShelf6, panelShelf7);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    addedCabinePage.Controls.Add(panelShelf1);
                    if (!globalAvail)
                    {
                        MessageBox.Show("Due to a shortage in our stock, we can't provide you the cabinet(s) right away. " +
                                "If you still want to go ahead with your order, you will have to pay an advance and wait " +
                                "the time our suppliers deliver those parts");
                    }
                    
                }
            }
        }

        private void ConfirmCartButton_Click(object sender, EventArgs e)
        {
            tabControl.Visible = false;
            totalLabel.Visible = false;
            comfirmCartButton.Visible = false;
            costLabel.Visible = false;
            clientIdentifier1.Visible = true;
        }

        // -- Method to design tabheader
        private void TabPageBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl.TabPages[e.Index];
            Color col = Color.FromArgb(27, 29, 33);

            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            Font font = new Font("Century Gothic", 8, FontStyle.Bold);

            Color myColor = Color.FromArgb(60, 120, 138);
            SolidBrush myBrush = new SolidBrush(myColor);

            SizeF sz = e.Graphics.MeasureString(tabControl.TabPages[e.Index].Text, font);

            // changes color of text when tab is selected
            if (tabControl.SelectedIndex == e.Index)
            {
                myColor = Color.FromArgb(230, 232, 237);
                myBrush = new SolidBrush(myColor);
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font, myBrush, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 4 + 1);
            }
            e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font, myBrush, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 4 + 1);

            Rectangle rect = e.Bounds;
            rect.Offset(0, -2);
            rect.Inflate(0, -2);
            e.Graphics.DrawRectangle(Pens.Transparent, rect);
            e.DrawFocusRectangle();
        }
    }
}
