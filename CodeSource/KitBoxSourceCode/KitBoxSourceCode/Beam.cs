using System;
namespace KitBoxSourceCode
{
    public class Beam
    {
        private int Lenght;

        public Beam(int Len)
        {
            Lenght = Len;
        }

        public int GetLenght => Lenght;
    }
}
