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
					stockNumber = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TRR%' AND largeur LIKE '" + len.ToString() + "'");
					break;
				case 4:
					stockNumber = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TRG%' AND profondeur LIKE '" + len.ToString() + "'");
					break;
			}

			beamNum++;
			beamNumber = beamNum;

			// oledb book beam fct len & qty
			Oledb.UpdateReservation(quantity, stockNumber);
            price = Oledb.GetDBPrice(stockNumber);
			
		}

		public override string GetDetails()
		{
			return "\"Beam " + beamNumber + "\" : { \"Lenght\": " + lenght + ", \"Stockref\" : \"" + stockNumber + "\"";
		}
	}
}
