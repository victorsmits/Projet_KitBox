using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace KitBoxApplication
{
    public partial class HomePage : UserControl
    {       
        public HomePage()
        {
            InitializeComponent();          
        }

        private void slidePic_Click(object sender, EventArgs e)
        {

        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
