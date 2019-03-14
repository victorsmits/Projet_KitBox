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

        BoxCreationScratch creation = new BoxCreationScratch();

        private void radioButtonsYesNo_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButtonYes)
                {
                    panelDoorMaterial.Visible = true;
                    creation.LoadDataWidth();
                }
                else if (((RadioButton)sender) == radioButtonNo)
                {
                    panelDoorMaterial.Visible = false;
                    creation.LoadDataWidth();
                }
            }
        }

        public System.Windows.Forms.ComboBox ComboBoxDepth
        {
            get { return this.comboBoxDepth; }
            set { this.comboBoxDepth = value; }
        }

        public System.Windows.Forms.ComboBox ComboBoxHeight
        {
            get { return this.comboBoxHeight; }
            set { this.comboBoxHeight = value; }
        }

        public System.Windows.Forms.ComboBox ComboBoxWidth
        {
            get { return this.comboBoxWidth; }
            set { this.comboBoxWidth = value; }
        }

        public System.Windows.Forms.ComboBox ComboBoxColor
        {
            get { return this.comboBoxColor; }
            set { this.comboBoxColor = value; }
        }

        public System.Windows.Forms.ComboBox ComboBoxDoorMat
        {
            get { return this.comboBoxDoorMat; }
            set { this.comboBoxDoorMat = value; }
        }

        public bool DoorNo
        {
            get { return this.radioButtonNo.Checked; }
            set { }
        }

        public System.Windows.Forms.RadioButton DoorNochange
        {
            get { return this.radioButtonNo; }
            set { }
        }
    }
}
