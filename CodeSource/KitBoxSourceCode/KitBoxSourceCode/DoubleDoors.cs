using System;
using System.Drawing;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
	public class DoubleDoors : GenericStorageBox
	{
		private readonly List<Knop> knops;
		private string stockNumber;

		public string DoorMat { get; }

		private IStorageBox storageBox;

		IStorageBox StorageBox { get; set; }

		public void AddBoxDecorator(IStorageBox storageBox)
		{
			this.storageBox = storageBox;
		}

		public DoubleDoors(string doormat, int height, int len) : base(len, height)
		{
			DoorMat = doormat;
			stockNumber = "1";

			knops = new List<Knop> {
				new Knop(),
				new Knop()
			};

			SetPrice();
		}

		protected override void SetPrice()
		{
			Price = 20;
			//TODO ole db fct color et mat
		}

		public override string GetDetails()
		{
			return "\"DoubleDoors\" : {\"Height\": " + Height + ",\"Lenght\": " + Lenght
			+ ", \"Material\": \"" + DoorMat + "\", \"Stockref\": " + stockNumber;
		}

	}
}
