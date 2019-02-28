using System;
namespace KitBoxSourceCode
{
    public class Panel : Compoment
    {
        private int Lenght;
        private int Height;
        private int Price;

        public Panel(int len, int height)
        {
            Lenght = len;
            Height = height;
        }

        public int GetLenght() => Lenght;
        public int GetHeight => Height;
        public int GetPrice() => Price;
    }
}
