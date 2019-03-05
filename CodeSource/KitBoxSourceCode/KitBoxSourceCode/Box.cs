using System;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class Box : IStorageBox
    {
        private List<ICompoment> Compoments;
        private int Price = 0;
        private readonly int Lenght;
        private readonly int Height;
        private readonly int Depth;

        public List<ICompoment> GetCompoments => Compoments;

        public Box(int len, int height, int depth)
        {
            Compoments = new List<ICompoment>();
            Lenght = len;
            Height = height;
            Depth = depth;
            Price = 30;

            AddPanel(len, height, depth);
            AddCleat(height);
            AddBeam(len, depth);
            AddDoorBeam(len);
        }

        public override int GetPrice()
        {
            //Compoments.ForEach(AddPrice);
            return Price;
        }

        private void AddPrice(ICompoment elem)
        {
            Price = Price + elem.GetPrice();
        }

        public override int GetHeight()
        {
            //TODO calcul hauteur de la boie
            return 200;
        }

        public override void GetDetails()
        {
            Console.WriteLine("box");
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
