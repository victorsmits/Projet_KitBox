using System;
using SqlOledb;

namespace KitBoxSourceCode
{
	public abstract class GenericStorageBox : IStorageBox
	{
		protected double price;
		protected int lenght;
		protected int height;
		protected string stockNumber;

		protected GenericStorageBox(int len, int hei)
		{
			lenght = len;
			height = hei;
		}

		public abstract string GetDetails();
        
		
		public double GetPrice() => price;
		public int GetHeight() => height;
	}
}
