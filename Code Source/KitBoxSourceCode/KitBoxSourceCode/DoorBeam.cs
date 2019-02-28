using System;
namespace KitBoxSourceCode
{
    public class DoorBeam
    {
        private int Lenght;
        private int Price;

        public DoorBeam(int Len)
        {
            Lenght = Len;
        }

        public int GetLenght => Lenght;
        public int GetPrice => Price;
    }
}
