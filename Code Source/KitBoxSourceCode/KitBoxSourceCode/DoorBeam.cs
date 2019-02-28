using System;
namespace KitBoxSourceCode
{
    public class DoorBeam
    {
        private int Lenght;

        public DoorBeam(int Len)
        {
            Lenght = Len;
        }

        public int GetLenght => Lenght;
    }
}
