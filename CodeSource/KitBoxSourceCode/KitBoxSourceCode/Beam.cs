using System;
namespace KitBoxSourceCode
{
    public class Beam : ICompoment
    {
        private readonly int Lenght;
        private readonly int Price;

        public Beam(int Len)
        {
            Lenght = Len;
        }

        public int GetLenght() => Lenght;
        public int GetPrice() => Price;
    }
}
