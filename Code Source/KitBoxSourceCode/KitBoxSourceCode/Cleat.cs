using System;
namespace KitBoxSourceCode
{
	public class Cleat : Compoment
	{
		private int Lenght;
		private int Price;

		public Cleat(int Len)
		{
			Lenght = Len;
			//TODO oledb requete price fct len
		}

		public int GetLenght() => Lenght;
		public int GetPrice() => Price;
	}
}
