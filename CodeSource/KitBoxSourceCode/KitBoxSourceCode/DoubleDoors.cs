using System;
using System.Drawing;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class DoubleDoors : BoxDecorator
    {
        private readonly List<Knop> knops;
        private int Price;

        public string Materials { get; }
        public string DoorColor { get; }

        public DoubleDoors(string color, string mat)
        {
            DoorColor = color;
            Price = 20;
            Materials = mat;
            knops = new List<Knop> {
                new Knop(),
                new Knop()
            };

            //SetPrice();
        }

        private void SetPrice()
        {
            Price = 20;
            //TODO ole db fct color et mat
        }

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Materials");
        }

        public override int GetPrice()
        {
            //base.GetPrice();
            return Price;
        }

    }
}
