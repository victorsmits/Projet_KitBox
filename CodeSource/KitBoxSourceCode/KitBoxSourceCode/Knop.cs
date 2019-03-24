using System;
using SqlOledb;

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
			//TODO requet knop stock Ref
			stockRef = Oledb.SqlRequest("SELECT Rfrence FROM Piece WHERE Rfrence LIKE COUP% ");

			//TODO requet knop price
			price = Oledb.GetDBPrice(stockRef);

			quantity = qty;
			//TODO requet book fct qty
			Oledb.UpdateReservation(quantity, stockRef);
		}

		public string GetDetails()
		{
			return ",\"Knop\":{\"StockRef\":" + stockRef + ",\"Quantity\":" + quantity + "}";
		}

	}
}
