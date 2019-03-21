using System;
using System.Drawing;
namespace KitBoxSourceCode
{
    public class Angle
    {
        private readonly int lenght;
        private readonly int price;
        private readonly string angleColor;

<<<<<<< HEAD
        public Angle(int len, string color)
=======
        public Angle(int Len, string color)
>>>>>>> parent of 0e30a2b... Merge branch 'master' into AddingCart-Michaël
        {
            Lenght = Len;
            angleColor = color;
<<<<<<< HEAD
            CalculPrice(len, color);
            price = 2;
=======
            CalculPrice(Len, color);
            Price = 2;
>>>>>>> parent of 0e30a2b... Merge branch 'master' into AddingCart-Michaël

        }

        public int GetLenght() => Lenght;
        public int GetPrice() => Price;

        private void CalculPrice(int len, string color)
        {
            //TODO oledb requete price fct len et color
        }
    }
}
