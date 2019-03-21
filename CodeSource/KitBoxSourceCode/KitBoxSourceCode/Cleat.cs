using System;
namespace KitBoxSourceCode
{
	public class Cleat : GenericComponent
	{

<<<<<<< HEAD
		public Cleat(int len, int qty) : base(len, qty)
=======
		public Cleat(int Len, int qty) : base(Len, qty)
>>>>>>> parent of 0e30a2b... Merge branch 'master' into AddingCart-Michaël
		{
			stockNumber = "1";
			SetPrice();
		}

		public override string GetDetails()
		{
			return "\"Cleat\":{ \"Lenght\": " + lenght + ", \"Stockref\" : " + stockNumber;
		}

		protected override void SetPrice()
		{
			//TODO oledb requete price fct len
			price = 2;
		}

	}
}
