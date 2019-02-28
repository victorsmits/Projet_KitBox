using System;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class Box : StorageBox
    {
        private List<Compoment> Compoments;
        private int Price = 0;
        private int Lenght;
        private int Height;
        private int Depth;

        public Box(int len, int height, int depth)
        {
            Lenght = len;
            Height = height;
            Depth = depth;

            AddAngle(height);
            AddBeam(len);
            AddBeam(height);
        }

        public int GetPrice()
        {
            Compoments.ForEach(AddPrice);
            return Price;
        }

        public void GetDetails()
        {

        }

        private void AddPrice(Compoment elem)
        {
            Price += elem.GetPrice();
        }

        private void AddPanel(int x, int y, int z)
        {
            Compoments.Add(new Panel(x, y));

            Compoments.Add(new Panel(z, y));
            Compoments.Add(new Panel(z, y));

            Compoments.Add(new Panel(z, x));
            Compoments.Add(new Panel(z, x));
        }

        private void AddAngle(int height)
        {
            int i = 0;
            while (i < 4)
            {
                Compoments.Add(new Angle(height));
            }
        }

        private void AddBeam(int len)
        {
            int i = 0;
            while (i < 4)
            {
                Compoments.Add(new Beam(len));
            }
        }
    }
}
