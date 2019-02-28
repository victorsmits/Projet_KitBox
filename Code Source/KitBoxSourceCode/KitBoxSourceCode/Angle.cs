using System;
namespace KitBoxSourceCode
{
    public class Angle : Compoment
    {
        private int Lenght;
        private int Price;

        public Angle(int Len)
        {
            Lenght = Len;
        }

        public int GetLenght() => Lenght;
        public int GetPrice() => Price;

    }
}
