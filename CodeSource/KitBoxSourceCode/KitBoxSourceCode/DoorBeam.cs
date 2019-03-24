using System;
using SqlOledb;

namespace KitBoxSourceCode
{
	public class DoorBeam : GenericComponent
	{
		public DoorBeam(int len, int qty) : base(len, qty)
		{
			// oledb stock ref fct len
			stockNumber = Oledb.SqlRequest("SELECT Rfrence FROM Piece WHERE Rfrence LIKE TRF% AND largeur LIKE \"" + len + "\"");
			// oledb book fct len et qty
			Oledb.UpdateReservation(quantity, stockNumber);
			SetPrice();
		}

		public override string GetDetails()
		{
			return "\"DoorBeam\" : {\"Lenght\": " + lenght + ", \"Stockref\": " + stockNumber;
		}
	}
}
