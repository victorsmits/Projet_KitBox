using System;
namespace KitBoxSourceCode
{
    public abstract class GenericStorageBox : IStorageBox
    {
        protected int price;
        protected int lenght;
        protected int height;

        protected GenericStorageBox(int len, int hei)
        {
            lenght = len;
            height = hei;
        }

        public abstract string GetDetails();
        protected abstract void SetPrice();
        public int GetPrice() => price;
        public int GetHeight() => height;
    }
}
