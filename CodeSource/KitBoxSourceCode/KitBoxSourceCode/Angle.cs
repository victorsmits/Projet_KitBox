using System;
using System.Drawing;
namespace KitBoxSourceCode
{
    public class Angle
    {
        private readonly int lenght;
        private readonly int price;
        private readonly string angleColor;

        public Angle(int len, string color)
        {
            lenght = len;
            angleColor = color;
            CalculPrice(len, color);
            price = 2;

        }

        public int GetLenght() => lenght;
        public int GetPrice() => price;

        private void CalculPrice(int len, string color)
        {
            //TODO oledb requete price fct len et color
        }
    }
}
