using System;
using System.Drawing;
using System.Collections.Generic;
using SqlOledb;

namespace KitBoxSourceCode
{
	public class DoubleDoors : GenericStorageBox
	{
		private readonly Knop knops;

		public string TheDoorMat { get; }

		private IStorageBox theStorageBox;

		IStorageBox GettheStorageBox { get; set; }

		public void AddBoxDecorator(IStorageBox storageBox)
		{
			this.theStorageBox = storageBox;
		}

		public DoubleDoors(string doormat, int hei, int len) : base(len, hei - 4)
		{
			TheDoorMat = doormat;
			// Getting the stock reference by dimension and color/material
			stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'POR%' AND largeur LIKE '"
			+ length.ToString() + "' AND hauteur LIKE '" + height.ToString() + "' AND Couleur LIKE '" + doormat + "'");

			knops = new Knop(2);

			price = Oledb.GetDBPrice(stockRef);
			// Update the reservation in the data base
			Oledb.UpdateReservation(2, stockRef);

			SetPrice();
			SetStock();
		}

		public override string GetDetails()
		{
			return "\"DoubleDoors\" : {\"Height\": " + height + ",\"Length\": " + length
			+ ", \"Material\": \"" + TheDoorMat + "\",\"Stockref\": \"" + stockRef
				 + "\",\"Remaining Stock\":" + stock + knops.GetDetails();
		}

	}
}
