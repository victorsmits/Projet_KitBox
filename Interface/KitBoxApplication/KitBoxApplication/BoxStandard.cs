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
            radioButtonYesIf1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonNoif1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }

        // function to make appear color choice for all the boxes at once and door choice
        //
        private void checkBoxColorYes_CheckedChanged(object sender, EventArgs e)
        {
            if (panelColorChoiceAll.Visible == true)
            {
                panelColorChoiceAll.Visible = false;
                panelDoorChoiceMultiple.Visible = false;
            }
            else
            {
                panelColorChoiceAll.Visible = true;
                checkBoxColorNo.Checked = false;
                panelDoorChoiceMultiple.Visible = true;
            }
        }

        // function to make appear color choice for all boxes apart and door choice
        //
        private void checkBoxColorNo_CheckedChanged(object sender, EventArgs e)
        {
            if (panelColorChoice.Visible == true)
            {
                panelColorChoice.Visible = false;
                panelDoorChoiceMultiple.Visible = false;
            }
            else
            {
                panelColorChoice.Visible = true;
                checkBoxColorYes.Checked = false;
                panelDoorChoiceMultiple.Visible = true;
            }
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDownQuantity.Value);
            if (count > 1)
            {
                panelColorBoxIf1.Visible = false;
                panelColorBoxIfN1.Visible = true;
                
            }
            else if (count == 1)
            {
                panelColorBoxIf1.Visible = true;
                panelColorBoxIfN1.Visible = false;
                panelDoorChoiceMultiple.Visible = false;
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYesIf1)
                {
                    panelDoorMaterial.Visible = true;
                }
                else if (((RadioButton)sender) == radioButtonNoif1)
                {
                    panelDoorMaterial.Visible = false;
                }
            }
        }
    }
}
