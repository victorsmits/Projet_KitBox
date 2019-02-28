using System;
namespace KitBoxSourceCode
{
	public class DoorBeam : Compoment
	{
		private int Lenght;
		private int Price;

		public DoorBeam(int Len)
		{
			Lenght = Len;
			//TODO oledb requete price fct len
		}

		public int GetLenght() => Lenght;
		public int GetPrice() => Price;
	}
}
