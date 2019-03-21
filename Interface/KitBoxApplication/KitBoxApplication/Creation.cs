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
    public partial class Creation : UserControl
    {
        public Creation()
        {
            InitializeComponent();
        }       

        private void completeCreationAppear(object sender, EventArgs e)
        {
            if (boxCreationScratch1.Visible == true)
            {
                boxCreationScratch1.Visible = false;
                creationExplanation1.Visible = true;
            }
            else
            {
                boxCreationScratch1.Visible = true;
                standartCreation.Checked = false;
                creationExplanation1.Visible = false;
            }
        }

        private void standartCreationAppear(object sender, EventArgs e)
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
    }
}
