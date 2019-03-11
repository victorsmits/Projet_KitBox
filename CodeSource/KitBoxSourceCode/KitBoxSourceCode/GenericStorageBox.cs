using System;
namespace KitBoxSourceCode
{
    public abstract class GenericStorageBox : StorageBox
    {
        protected int Price;
        protected int Lenght;
        protected int Height;

        protected GenericStorageBox(int len, int height)
        {
            Lenght = len;
            Height = height;
        }

        public abstract string GetDetails();
        protected abstract void SetPrice();
        public int GetPrice() => Price;
        public int GetHeight() => Height;
    }
}
