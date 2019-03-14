using System;
namespace KitBoxSourceCode
{
	public class Beam : GenericComponent
	{

		public Beam(int Len, int qty) : base(Len, qty)
		{
			lenght = Len;
			quantity = qty;
			price = 2;
			stockNumber = "1";
			SetPrice();
		}

		public override string GetDetails()
		{
			return "\"Beam\" : { \"Lenght\": " + Lenght + ", \"Stockref\" : " + stockNumber;
		}

		protected override void SetPrice()
		{
			//TODO oledb requete price fct len
			Price = 2;
		}
	}
}
