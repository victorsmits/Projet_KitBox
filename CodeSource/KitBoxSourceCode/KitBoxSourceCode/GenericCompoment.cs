using System;
using SqlOledb;
namespace KitBoxSourceCode
{
	public abstract class GenericComponent : IComponent
	{
		protected int lenght;
		protected int quantity;
		protected int price;
		protected string stockNumber;

		protected GenericComponent(int len, int qty)
		{
			lenght = len;
			quantity = qty;
		}

		public abstract string GetDetails();

		protected void SetPrice()
		{
			// Oledb get price of the object
			price = Oledb.GetDBPrice(stockNumber);
		}

		public int GetLenght() => lenght;

		public int GetPrice() => price;

	}
}
