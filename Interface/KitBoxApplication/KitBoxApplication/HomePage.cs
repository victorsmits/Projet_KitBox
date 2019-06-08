using System;
using System.Windows.Forms;

namespace KitBoxApplication
{
    public partial class HomePage : UserControl
    {       
        public HomePage()
        {
            InitializeComponent();          
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void TimerSlider_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
