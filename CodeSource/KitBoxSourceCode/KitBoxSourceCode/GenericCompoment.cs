using System;
namespace KitBoxSourceCode
{
    public abstract class GenericComponent : IComponent
    {
        protected int lenght;
        protected int quantity;
        protected int price;
        protected string stockNumber;

        protected GenericCompoment(int len, int qty)
        {
            lenght = len;
            quantity = qty;
        }

        public abstract string GetDetails();

        protected abstract void SetPrice();

        public int GetLenght() => lenght;

        public int GetPrice() => price;

    }
}
