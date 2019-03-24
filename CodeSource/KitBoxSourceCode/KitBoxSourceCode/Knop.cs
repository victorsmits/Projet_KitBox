using System;
namespace KitBoxSourceCode
{
    public class Knop
    {
        private readonly int price;
        private readonly int quantity;
        private readonly string stockRef;

        public int GetPrice => price;

        public Knop(int qty)
        {
            price = 2;
            quantity = qty;
            stockRef = "1";
            //TODO requet knop price
            //TODO requet knop stock Ref
            //TODO requet book fct qty
        }

        public string GetDetails()
        {
            return ",\"Knop\":{\"StockRef\":" + stockRef + ",\"Quantity\":" + quantity + "}";
        }
    }
}
