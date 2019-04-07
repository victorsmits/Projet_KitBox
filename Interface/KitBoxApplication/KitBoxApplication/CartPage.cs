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

            // enables design of tabheader
            this.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabPageBox1_DrawItem);

            tabControl.ItemSize = new Size(70, 30);
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
                MessageBox.Show(e.ToString());
                tabControl.TabPages.Clear();
                TabPage emptyCart = new TabPage(Name = "Empty");
                emptyCart.BackColor = Color.FromArgb(41, 44, 51);
                tabControl.TabPages.Add(emptyCart);
                comfirmCartButton.Visible = false;
                costLabel.Visible = false;
                totalLabel.Visible = false;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
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
                tabControl.TabPages.Clear();
                TabPage emptyCart = new TabPage(Name = "Empty");
                emptyCart.BackColor = Color.FromArgb(41, 44, 51);
                tabControl.TabPages.Add(emptyCart);
                comfirmCartButton.Visible = false;
                costLabel.Visible = false;
                totalLabel.Visible = false;
            }
            else
            {
                tabControl.TabPages.Clear(); //Clear the tabs
                MessageBox.Show(jsonCart.ToString());

                //For every cabinet of the json
                for (int cabinetCount = 0; cabinetCount < jsonCart.Count - 1; cabinetCount++)
                {
                    Font font = new Font("Century Gothic", 9, FontStyle.Bold);

                    //Get the elements of the cabinet
                    JObject cabinetContains = jsonCart["Cabinet " + cabinetCount.ToString()].Value<JObject>();
                    MessageBox.Show(cabinetContains.ToString());
                    //Add a tab for the cabinet
                    TabPage addedCabinePage = new TabPage(Name = "Cabine " + (cabinetCount + 1).ToString());
                    addedCabinePage.BackColor = Color.FromArgb(41, 44, 51);
                    tabControl.TabPages.Add(addedCabinePage);
                    int floorCount = 0;

                    //Add a delete button
                    Button deleteButton = new Button();
                    Color DarkRed = Color.FromName("DarkRed");
                    deleteButton.BackColor = Color.FromArgb(192, 0, 0); ;
                    Color Black = Color.FromName("Black");
                    deleteButton.ForeColor = Black;
                    deleteButton.FlatStyle = FlatStyle.Flat;
                    deleteButton.Text = "Delete cabinet";
                    deleteButton.Click += DeleteButton_Clicked;
                    deleteButton.Location = new Point(901, 15);
                    deleteButton.Size = new Size(100, 60);
                    deleteButton.Font = font;
                    addedCabinePage.Controls.Add(deleteButton);

                    //Generates label for angles
                    JObject angle = cabinetContains["Angle"].Value<JObject>();
                    int angleLength = angle["Length"].Value<int>();
                    string angleColor = angle["Color"].Value<string>();
                    int angleQty = angle["Quantity"].Value<int>();

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

                    addedCabinePage.Controls.Add(angleLabel);
                    addedCabinePage.Controls.Add(angleFeatLabel);

                    int labelLength = 15;

                    for (floorCount = 0; floorCount < cabinetContains.Count - 2; floorCount++)
                    {
                        labelLength = 15;
                        JObject floor = cabinetContains["Floor " + floorCount.ToString()].Value<JObject>();
                        //MessageBox.Show(floor.ToString());

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
                            JObject doors = floor["DoubleDoors"].Value<JObject>();
                            int doorHeight = doors["Height"].Value<int>();
                            int doorLength = doors["Length"].Value<int>();
                            string doorMaterial = doors["Material"].Value<string>();
                            int doorQty = doors["Qty"].Value<int>();

                            JObject knop = doors["Knop"].Value<JObject>();
                            int knopQty = knop["Quantity"].Value<int>();

                            Label doorLabel = new Label();
                            doorLabel.AutoSize = true;
                            doorLabel.Text = String.Format("Double Doors\n\nColor (or Material) : {0}\nGot {1} knops\n", doorMaterial, knopQty.ToString());
                            doorLabel.Location = new Point(labelLength, 28);
                            int doorLabelLenght = doorLabel.Width;
                            labelLength += (doorLabelLenght);

                            floorGroup.Controls.Add(doorLabel);


                        }
                        catch
                        {

                        }

                    }
                    if (floorCount >= 4)
                    {
                        addedCabinePage.AutoScroll = true;
                        addedCabinePage.AutoScrollMargin = new Size(20, 5);
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
