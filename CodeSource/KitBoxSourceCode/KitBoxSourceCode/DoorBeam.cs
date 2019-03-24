using System;
using SqlOledb;

namespace KitBoxSourceCode
{
	public class DoorBeam : GenericComponent
	{
		public DoorBeam(int len, int qty) : base(len, qty)
		{
			// oledb stock ref fct len
			stockNumber = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TRF%' AND largeur LIKE '" + len.ToString() + "'");
			// oledb book fct len et qty
			Oledb.UpdateReservation(quantity, stockNumber);
            price = Oledb.GetDBPrice(stockNumber);
        }

		public override string GetDetails()
		{
			return "\"DoorBeam\" : {\"Lenght\": " + lenght + ", \"Stockref\": \"" + stockNumber + "\"";
		}
	}
}
