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
			// Getting stock reference for the knop
			stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'COUP%' ");

			// Getting knop's price
			price = Oledb.GetDBPrice(stockRef);

			stock = Oledb.GetDBStock(stockRef);
			quantity = qty;

			// Update reservation in the data base
			Oledb.UpdateReservation(quantity, stockRef);
		}

		public string GetDetails()
		{
			return ",\"Knop\":{\"StockRef\": \"" + stockRef
				+ "\",\"Quantity\":" + quantity
				+ ",\"Remaining Stock\":" + stock + "}";
		}

	}
}
