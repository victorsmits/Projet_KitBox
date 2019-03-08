using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_Magasinier
{
    public partial class ProductWizard : UserControl
    {
        public ProductWizard()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Control form = this.Parent; //Choose the container in which it is (in our case the Tab "Add a product")
            Control test = form.GetChildAtPoint(new Point(36, 85)); //Get a child located in 36, 85
            
            
        }
    }
}
