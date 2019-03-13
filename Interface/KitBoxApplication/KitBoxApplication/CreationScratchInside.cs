using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBoxApplication
{
    public partial class CreationScratchInside : UserControl
    {
        public CreationScratchInside()
        {
            InitializeComponent();

            // radio buttons in same group added to same function - group : --panelYesNoIf1--
            radioButtonYes.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChanged);
            radioButtonNo.CheckedChanged += new EventHandler(radioButtonsYesNo_CheckedChanged);
        }

        private void radioButtonsYesNo_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes)
                {
                    panelDoorMaterial.Visible = true;
                }
                else if (((RadioButton)sender) == radioButtonNo)
                {
                    panelDoorMaterial.Visible = false;
                }
            }
        }

        public System.Windows.Forms.ComboBox ComboBoxDepth
        {
            get { return this.comboBoxDepth; }
            set { this.comboBoxDepth.Text = ""; }
        }
    }
}
