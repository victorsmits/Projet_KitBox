using System;
using SqlOledb;
namespace KitBoxSourceCode
{
	public abstract class GenericComponent : IComponent
	{
		protected int lenght;
		protected int quantity;
		protected double price;
		protected string stockNumber;

		protected GenericComponent(int len, int qty)
		{
			lenght = len;
			quantity = qty;
		}

		public abstract string GetDetails();

		

		public int GetLenght() => lenght;

		public double GetPrice() => price;

	}
}
