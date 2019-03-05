using System;
using System.Drawing;
namespace KitBoxSourceCode
{
    public class BoxColor : BoxDecorator
    {
        private readonly string wallColor;
        private int Price;

        public BoxColor(string color)
        {
            wallColor = color;
            Price = 12;
            //SetPrice();
        }

        public string GetWallColor => wallColor;

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("red");
        }


        public override int GetPrice()
        {
            //base.GetPrice();
            return Price;
        }

        private void SetPrice()
        {
            Price = 12;
            //TODO ole db fct color
        }
    }
}
