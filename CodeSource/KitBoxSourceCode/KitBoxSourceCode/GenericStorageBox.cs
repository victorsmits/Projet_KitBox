using System;
using SqlOledb;

namespace KitBoxSourceCode
{
	public abstract class GenericStorageBox : IStorageBox
	{
		protected int price;
		protected int lenght;
		protected int height;
		protected string stockNumber;

		protected GenericStorageBox(int len, int hei)
		{
			lenght = len;
			height = hei;
		}

		public abstract string GetDetails();
		protected void SetPrice()
		{
			// Oledb get price of the object
			price = Oledb.GetDBPrice(stockNumber);
		}
		public int GetPrice() => price;
		public int GetHeight() => height;
	}
}
