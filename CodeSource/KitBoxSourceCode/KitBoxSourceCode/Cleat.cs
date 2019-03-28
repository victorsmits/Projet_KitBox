using System;
using SqlOledb;

namespace KitBoxSourceCode
{
	public class Cleat : GenericComponent
	{

		public Cleat(int len, int qty) : base(len, qty)
		{
			// oledb stock ref fct len
			stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TAS%' AND hauteur LIKE " + len.ToString() );
			SetPrice();
			// oledb book fct len et qty
			Oledb.UpdateReservation(quantity, stockRef);
		}

		public override string GetDetails()
		{
			return "\"Cleat\":{ \"Length\": " + length + ", \"Stockref\" : \"" + stockRef + "\"";
		}

	}
}
