using System;
using Oledb = SqlOledb.Oledb;
namespace KitBoxSourceCode
{
	public class Panel : GenericComponent
	{
		private readonly int height;
		private readonly string color;

		private int panelNumber;
		private static int panelNum = 0;

		public int GetHeight => height;
		public string GetBoxColor => color;

		public Panel(int len, int hei, string col, int qty) : base(len, qty)
		{
			length = len;
			height = hei;
			color = col;
			quantity = qty;

			if (panelNum == 3) {
				panelNum = 0;
			}
			panelNum++;
			panelNumber = panelNum;

			// Getting stock reference for the 3 panels:
			// 1 = backward, 2 = side and 3 = upward/downward
			switch (panelNumber) {
				case 1:
					stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'PAR%' AND hauteur = '"
					+ (double)height + "' AND largeur = '" + (double)length + "' AND Couleur = '" + color + "'");
					break;
				case 2:
					stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'PAG%' AND hauteur = '"
					+ (double)height + "' AND profondeur = '" + (double)length + "' AND Couleur = '" + color + "'");
					break;
				case 3:
					stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'PAH%' AND largeur = '"
					+ (double)height + "' AND profondeur = '" + (double)length + "' AND Couleur = '" + color + "'");
					break;
			}

			// Update reservation in the data base
			Oledb.UpdateReservation(quantity, stockRef);

			SetPrice();
			SetStock();
		}

		public override string GetDetails()
		{
			return "\"Panel " + panelNumber + "\" : { \"Height\": " + height
			+ ", \"Length\": " + length + ", \"Coleur\": \"" + color
				+ "\", \"Stockref\": \"" + stockRef + "\",\"Remaining Stock\":" + stock;
		}
	}
}
