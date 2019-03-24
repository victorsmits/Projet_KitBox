using System;
using SqlOledb;

namespace KitBoxSourceCode
{
	public class Cleat : GenericComponent
	{

		public Cleat(int len, int qty) : base(len, qty)
		{
			// oledb stock ref fct len
			stockNumber = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TAS%' AND hauteur LIKE '" + len.ToString() + "'");
            price = Oledb.GetDBPrice(stockNumber);
            // oledb book fct len et qty
            Oledb.UpdateReservation(quantity, stockNumber);
		}

		public override string GetDetails()
		{
			return "\"Cleat\":{ \"Lenght\": " + lenght + ", \"Stockref\" : \"" + stockNumber + "\"";
		}

	}
}
