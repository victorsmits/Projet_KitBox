using System;
using SqlOledb;

namespace KitBoxSourceCode
{
    public class Knop
    {
        private readonly double price;
        private readonly int stock;
        private readonly int quantity;
        private readonly string stockRef;

        public double GetPrice => price;

        public Knop(int qty)
        {
            //TODO requet knop stock Ref
            stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'COUP%' ");

            //TODO requet knop price
            price = Oledb.GetDBPrice(stockRef);

            stock = Oledb.GetDBStock(stockRef);

            quantity = qty;
            //TODO requet book fct qty
            Oledb.UpdateReservation(quantity, stockRef);
        }

        public string GetDetails()
        {
            return "\",\"Knop\":{\"StockRef\": \"" + stockRef + "\",\"Quantity\":" + quantity + "}";
        }

    }
}
