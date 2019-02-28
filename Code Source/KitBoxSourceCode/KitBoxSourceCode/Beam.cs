using System;
namespace KitBoxSourceCode
{
    public class Beam
    {
        private int Lenght;
        private int Price;

        public Beam(int Len)
        {
            Lenght = Len;
        }

        public int GetLenght => Lenght;
        public int GetPrice => Price;
    }
}
