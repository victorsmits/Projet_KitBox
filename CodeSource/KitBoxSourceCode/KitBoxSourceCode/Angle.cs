using System;
using System.Drawing;
using SqlOledb;
using System.Collections.Generic;
using System.Linq;
namespace KitBoxSourceCode
{
	public class Angle
	{
		private readonly int length;
		private double price;
		private readonly int quantity;
		private readonly string angleColor;
		private readonly string stockRef;
		private string[] possibleLength;

		public Angle(int len, string color, int qty)
		{
			Oledb.Connection();
			possibleLength = Oledb.SqlRequest("SELECT hauteur FROM Piece WHERE Référence LIKE 'COR%'").Split(' ');
			if (possibleLength.Contains(len.ToString())) {
				length = len;
			} else {
				var closest = int.MaxValue;
				var minDifference = int.MaxValue;
				foreach (var element in possibleLength) {
					int elem = int.Parse(element);
					var difference = Math.Abs((long)elem - len);
					if (minDifference > difference) {
						minDifference = (int)difference;
						closest = elem;
					}
				}
			}
			angleColor = color;
			// oledb stock ref fct len & color
			stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'COR%' AND hauteur LIKE '" + length.ToString() + "' AND Couleur LIKE '" + angleColor + "'");
			quantity = qty;
			CalculPrice();

			// oledb book 4 angles fct len & color
			Oledb.UpdateReservation(quantity, stockRef);
		}

		public int GetLenght() => length;
		public double GetPrice() => price;

		private void CalculPrice()
		{
			price = Oledb.GetDBPrice(stockRef);
		}

		public string GetDetails()
		{
			return "\"Angle\":{\"Length\":" + length + ",\"Color\":\"" + angleColor
			+ "\",\"StockRef\":\"" + stockRef + "\",\"Quantity\":" + quantity;
		}
	}
}
