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
			lenght = len;
			height = hei;
			color = col;
			quantity = qty;

			if (panelNum == 3) {
				panelNum = 0;
			}
			panelNum++;
			panelNumber = panelNum;

			// TODO OLEDB requete piece num fct dimension & color
			switch (panelNumber) {
				case 1:
					stockNumber = Oledb.SqlRequest("SELECT Rfrence FROM Piece WHERE Rfrence LIKE PAR% AND hauteur LIKE \""
					+ height + "\" AND largeur LIKE \"" + lenght + "\" AND couleur LIKE " + color);
					break;
				case 2:
					stockNumber = Oledb.SqlRequest("SELECT Rfrence FROM Piece WHERE Rfrence LIKE PAG% AND hauteur LIKE \""
					+ height + "\" AND profondeur LIKE \"" + lenght + "\" AND couleur LIKE " + color);
					break;
				case 3:
					stockNumber = Oledb.SqlRequest("SELECT Rfrence FROM Piece WHERE Rfrence LIKE PAH% AND profondeur LIKE \""
					+ height + "\" AND largeur LIKE \"" + lenght + "\" AND couleur LIKE " + color);
					break;
			}

			//TODO oledb book fct dimension, color & qty
			Oledb.UpdateReservation(quantity, stockNumber);

			SetPrice();
		}

		public override string GetDetails()
		{
			return "\"Panel " + panelNumber + "\" : { \"height\": " + height + ", \"Lenght\": " + lenght
			+ ", \"Coleur\": \"" + color + "\", \"Stockref\": " + stockNumber;
		}
	}
}
