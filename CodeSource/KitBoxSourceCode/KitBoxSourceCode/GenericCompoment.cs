//Define commum methods for IComponents

using System;
using SqlOledb;
namespace KitBoxSourceCode
{
	public abstract class GenericComponent : IComponent
	{
		protected int length;
		protected int quantity;
		protected double price;
		protected string stockRef;

		protected GenericComponent(int len, int qty)
		{
			length = len;
			quantity = qty;
		}

		public abstract string GetDetails();
		protected void SetPrice()
		{
			price = Oledb.GetDBPrice(stockRef);
		}
		public int GetLenght() => length;

		public double GetPrice() => price;

	}
}
