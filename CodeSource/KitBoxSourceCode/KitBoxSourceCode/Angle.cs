using System;
using System.Drawing;
namespace KitBoxSourceCode
{
    public class Angle
    {
        private readonly int Lenght;
        private readonly int Price;
        private readonly Color angleColor;

        public Angle(int Len, Color color)
        {
            Lenght = Len;
            angleColor = color;
            CalculPrice(Len, color);
        }

        public int GetLenght() => Lenght;
        public int GetPrice() => Price;

        private void CalculPrice(int len, Color color)
        {
            //TODO oledb requete price fct len et color
        }
    }
}
