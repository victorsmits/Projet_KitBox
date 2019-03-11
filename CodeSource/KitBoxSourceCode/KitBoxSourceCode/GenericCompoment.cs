using System;
namespace KitBoxSourceCode
{
    public abstract class GenericCompoment : ICompoment
    {
        protected int Lenght;
        protected int quantity;
        protected int Price;
        protected string stockNumber;

        protected GenericCompoment(int len, int qty)
        {
            Lenght = len;
            quantity = qty;
        }

        public abstract string GetDetails();

        protected abstract void SetPrice();

        public int GetLenght() => Lenght;

        public int GetPrice() => Price;

    }
}
