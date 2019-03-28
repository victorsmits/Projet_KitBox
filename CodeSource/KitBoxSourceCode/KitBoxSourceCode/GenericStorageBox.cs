//Define commum methods for IStorageBox

using System;
using SqlOledb;

namespace KitBoxSourceCode
{
    public abstract class GenericStorageBox : IStorageBox
    {
        protected double price;
        protected int stock;
        protected int length;
        protected int height;
        protected string stockRef;

        protected GenericStorageBox(int len, int hei)
        {
            length = len;
            height = hei;
        }

        public abstract string GetDetails();

        protected void SetPrice()
        {
            price = Oledb.GetDBPrice(stockRef);
        }

        protected void SetStock()
        {
            stock = Oledb.GetDBStock(stockRef);
        }

        public double GetPrice() => price;
        public int GetHeight() => height;
    }
}
