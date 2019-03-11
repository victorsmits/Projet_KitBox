using System;
using System.Drawing;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class DoubleDoors : BoxDecorator
    {
        private readonly List<Knop> knops;
        private int Price;
        private int Height;
        private int Lenght;
        private string stockNumber;

        public string Materials { get; }
        public string DoorColor { get; }

        public DoubleDoors(string color, string mat, int height, int len)
        {
            DoorColor = color;
            Price = 20;
            Materials = mat;
            Height = height;
            Lenght = len;
            stockNumber = "1";

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

        public override string GetDetails()
        {
            return "DoubleDoors -> Dimension : " + Height + " x " + Lenght
            + " | Coleur : " + DoorColor + " | Stock ref : " + stockNumber;
        }

        public override int GetPrice()
        {
            return Price;
        }

    }
}
