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
			// oledb stock ref fct dimension, doormat
			stockNumber = Oledb.SqlRequest("SELECT Rfrence FROM Piece WHERE Rfrence LIKE POR% AND largeur LIKE \""
			+ lenght + "\" AND hauteur LIKE \"" + height + "\" AND couleur LIKE" + doormat + "\"");

			knops = new Knop(2);

			SetPrice();
			// oledb book double door
			Oledb.UpdateReservation(2, stockNumber);

		}

		public override string GetDetails()
		{
			return "\"DoubleDoors\" : {\"height\": " + height + ",\"Lenght\": " + lenght
			+ ", \"Material\": \"" + TheDoorMat + "\",\"Stockref\": " + stockNumber + knops.GetDetails();
		}

	}
}
