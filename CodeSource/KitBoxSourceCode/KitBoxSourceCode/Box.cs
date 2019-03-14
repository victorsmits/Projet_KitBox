using System;
using System.Collections.Generic;
using System.Linq;
namespace KitBoxSourceCode
{
    public class Box : GenericStorageBox
    {
        private Dictionary<IComponent, int> components;

        private readonly int boxWidth;

        public Dictionary<IComponent, int> GetComponents => components;

        public Box(int len, int height, int width, string col) : base(len, height)
        {
            components = new Dictionary<IComponent, int>();
            boxWidth = width;

            AddPanel(len, height - 4, width, col);
            AddCleat(height - 4);
            AddBeam(len, width);
            AddDoorBeam(len);

            SetPrice();
        }

        protected override void SetPrice()
        {
            price = 0;
            foreach (IComponent key in components.Keys)
            {
                AddPrice(key);
            }
        }

        private void AddPrice(IComponent elem)
        {
            price = price + (elem.GetPrice() * components[elem]);
        }

        public override string GetDetails()
        {
            string format = "";
            foreach (IComponent key in components.Keys)
            {
                format += key.GetDetails() + ", \"Qty\": " + components[key] + "},";

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
