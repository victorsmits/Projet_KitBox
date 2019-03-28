using System;
using SqlOledb;

namespace KitBoxSourceCode
{
	public class Cleat : GenericComponent
	{

		public Cleat(int len, int qty) : base(len, qty)
		{
            //Getting the stock reference by the length
			stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TAS%' AND hauteur LIKE '" + len.ToString() + "'");
			SetPrice();
			//Updating the reservation in the data base
			Oledb.UpdateReservation(quantity, stockRef);
		}

		public override string GetDetails()
		{
			return "\"Cleat\":{ \"Length\": " + length + ", \"Stockref\" : \"" + stockRef + "\"";
		}

	}
}
