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

            AddPanel(len, height, depth);


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
    }
}
