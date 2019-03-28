using System;
using SqlOledb;

namespace KitBoxSourceCode
{
	public class DoorBeam : GenericComponent
	{
		public DoorBeam(int len, int qty) : base(len, qty)
		{
            //Getting the stock reference by the length
			stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TRF%' AND largeur LIKE '" + len.ToString() + "'");
			//Updating the reservation in the data base
			Oledb.UpdateReservation(quantity, stockRef);
			SetPrice();
		}

		public override string GetDetails()
		{
			return "\"DoorBeam\" : {\"Length\": " + length + ", \"Stockref\": \"" + stockRef + "\"";
		}
	}
}
