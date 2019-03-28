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
		private List<string> possibleLength;

		public Angle(int len, string color, int qty)
		{
            Oledb.Connection();
            length = len;
            angleColor = color;
            //Getting the stock reference by the length and color
            stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'COR%' AND hauteur LIKE '" + length.ToString() + "' AND Couleur LIKE '" + angleColor + "'");
            quantity = qty;
            CalculPrice();

            //Updating the reservation in the data base
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
