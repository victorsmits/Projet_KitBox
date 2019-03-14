using System;
using System.Collections.Generic;
using System.Linq;
namespace KitBoxSourceCode
{
    public class Box : GenericStorageBox
    {
        private Dictionary<ICompoment, int> components;

        private readonly int Width;

        public Dictionary<ICompoment, int> GetCompoments => components;

        public Box(int len, int height, int width, string col) : base(len, height)
        {
            components = new Dictionary<ICompoment, int>();
            Width = width;

            AddPanel(len, height - 4, width, col);
            AddCleat(height - 4);
            AddBeam(len, width);
            AddDoorBeam(len);

            SetPrice();
        }

        protected override void SetPrice()
        {
            Price = 0;
            foreach (ICompoment Key in components.Keys)
            {
                AddPrice(Key);
            }
        }

        private void AddPrice(ICompoment elem)
        {
            Price = Price + (elem.GetPrice() * components[elem]);
        }

        public override string GetDetails()
        {
            string format = "";
            foreach (ICompoment Key in components.Keys)
            {
                format += Key.GetDetails() + ", \"Qty\": " + components[Key] + "},";

            }

            return format;
        }

        private void AddPanel(int x, int y, int z, string col)
        {
            components.Add(new Panel(x, y, col, 1), 1);

            components.Add(new Panel(z, y, col, 2), 2);

            components.Add(new Panel(z, x, col, 2), 2);
        }

        private void AddCleat(int height)
        {
            components.Add(new Cleat(height, 4), 4);
        }

        private void AddBeam(int len, int height)
        {
            components.Add(new Beam(len, 4), 4);

            components.Add(new Beam(height, 2), 2);

        }

        private void AddDoorBeam(int height)
        {
            components.Add(new DoorBeam(height, 2), 2);
        }
    }
}
