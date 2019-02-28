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
            Compoments = new List<Compoment>();
            Lenght = len;
            Height = height;
            Depth = depth;

            AddPanel(len, height, depth);
            AddCleat(height);
            AddBeam(len, depth);
            AddDoorBeam(len);
        }

        public int GetPrice()
        {
            Compoments.ForEach(AddPrice);
            return Price;
        }

        public List<Compoment> GetCompoments => Compoments;

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

        private void AddCleat(int height)
        {
            int i = 0;
            while (i < 4)
            {
                Compoments.Add(new Cleat(height));
                i++;
            }
        }

        private void AddBeam(int len, int height)
        {
            int i = 0;
            while (i < 4)
            {
                Compoments.Add(new Beam(len));
                i++;
            }

            int j = 0;
            while (j < 2)
            {
                Compoments.Add(new Beam(height));
                j++;
            }
        }

        private void AddDoorBeam(int height)
        {
            int j = 0;
            while (j < 2)
            {
                Compoments.Add(new DoorBeam(height));
                j++;
            }
        }
    }
}
