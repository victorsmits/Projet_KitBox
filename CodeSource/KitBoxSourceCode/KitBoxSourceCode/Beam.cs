using System;
using SqlOledb;

namespace KitBoxSourceCode
{
	public class Beam : GenericComponent
	{
		private int beamNumber;
		private static int beamNum = 0;

		public Beam(int len, int qty) : base(len, qty)
		{
			lenght = len;
			quantity = qty;

			// oledb stock ref fct len

			switch (qty) {
				case 2:
					stockNumber = Oledb.SqlRequest("SELECT Rfrence FROM Piece WHERE Rfrence LIKE TRR% AND largeur LIKE \"" + len + "\"");
					break;
				case 4:
					stockNumber = Oledb.SqlRequest("SELECT Rfrence FROM Piece WHERE Rfrence LIKE TRG% AND profondeur LIKE \"" + len + "\"");
					break;
			}

			beamNum++;
			beamNumber = beamNum;

			// oledb book beam fct len & qty
			Oledb.UpdateReservation(quantity, stockNumber);

			SetPrice();
		}

		public override string GetDetails()
		{
			return "\"Beam " + beamNumber + "\" : { \"Lenght\": " + lenght + ", \"Stockref\" : " + stockNumber;
		}
	}
}
