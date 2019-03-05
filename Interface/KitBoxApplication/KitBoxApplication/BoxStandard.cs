using System;
using System.Windows.Forms;

namespace KitBoxApplication
{
    public partial class BoxStandard : UserControl
    {
        public BoxStandard()
        {
            InitializeComponent();

            // Add a "CheckedChanged" event handler for each radio button.
            // Ensure that all radio buttons are in the same groupbox control.
            radioButton1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }

        private void checkBoxColorYes_CheckedChanged(object sender, EventArgs e)
        {
            if (panelColorChoiceAll.Visible == true)
            {
                panelColorChoiceAll.Visible = false;
            }
            else
            {
                panelColorChoiceAll.Visible = true;
                checkBoxColorNo.Checked = false;
            }
        }

        private void checkBoxColorNo_CheckedChanged(object sender, EventArgs e)
        {
            if (panelColorChoice.Visible == true)
            {
                panelColorChoice.Visible = false;
            }
            else
            {
                panelColorChoice.Visible = true;
                checkBoxColorYes.Checked = false;
            }
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDownQuantity.Value);
            if (count > 1)
            {
                panelColorBoxIfN1.Visible = true;
                panelColorBoxIf1.Visible = false;
            }
            else if (count == 1)
            {
                panelColorBoxIf1.Visible = true;
                panelColorBoxIfN1.Visible = false;
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButton1)
                {
                    panelDoorMaterial.Visible = true;
                }
                else if (((RadioButton)sender) == radioButton2)
                {
                    panelDoorMaterial.Visible = false;
                }
            }
        }
    }
}
