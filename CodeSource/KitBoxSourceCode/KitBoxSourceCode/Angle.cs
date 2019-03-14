using System;
using System.Drawing;
namespace KitBoxSourceCode
{
    public class Angle
    {
        private readonly int lenght;
        private readonly int price;
        private readonly string angleColor;

        public Angle(int Len, string color)
        {
            Lenght = Len;
            angleColor = color;
            CalculPrice(Len, color);
            Price = 2;

        }

        public int GetLenght() => Lenght;
        public int GetPrice() => Price;

        private void CalculPrice(int len, string color)
        {
            //TODO oledb requete price fct len et color
        }
    }
}
