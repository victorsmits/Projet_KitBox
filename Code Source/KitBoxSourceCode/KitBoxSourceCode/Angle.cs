using System;
namespace KitBoxSourceCode
{
	public class Angle
	{
		private int Lenght;
		private int Price;

		public Angle(int Len)
		{
			Lenght = Len;
			//TODO oledb requete price fct len
		}

		public int GetLenght() => Lenght;
		public int GetPrice() => Price;

	}
}
