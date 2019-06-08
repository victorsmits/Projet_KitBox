using System;
using System.Windows.Forms;

namespace KitBoxApplication
{
    public partial class Creation : UserControl
    {
        public Creation()
        {
            InitializeComponent();
        }       

        private void CompleteCreationAppear(object sender, EventArgs e)
        {
            if (boxCreationScratch1.Visible == true)
            {
                boxCreationScratch1.Visible = false;
                creationExplanation1.Visible = true;
            }
            else
            {
                boxCreationScratch1.Visible = true;
                standardCreation.Checked = false;
                creationExplanation1.Visible = false;
            }
        }

        private void StandardCreationAppear(object sender, EventArgs e)
        {
            if (boxStandard2.Visible == true)
            {
                boxStandard2.Visible = false;
                creationExplanation1.Visible = true;
            }
            else
            {
                boxStandard2.Visible = true;
                completeCreation.Checked = false;
                creationExplanation1.Visible = false; 
            }
        }

        private void boxCreationScratch1_Load(object sender, EventArgs e)
        {

        }
    }
}
