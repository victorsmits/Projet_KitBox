using System;
namespace KitBoxSourceCode
{
	public class Cleat : GenericCompoment
	{

		public Cleat(int Len, int qty) : base(Len, qty)
		{
			stockNumber = "1";
			SetPrice();
		}

		public override string GetDetails()
		{
			return "\"Cleat\":{ \"Lenght\": " + Lenght + ", \"Stockref\" : " + stockNumber;
		}

		protected override void SetPrice()
		{
			//TODO oledb requete price fct len
			Price = 2;
		}

	}
}
