using System;
namespace KitBoxSourceCode
{
	public class DoorBeam : GenericCompoment
	{
		public DoorBeam(int Len, int qty) : base(Len, qty)
		{
			SetPrice();
			stockNumber = "1";
		}

		public override string GetDetails()
		{
			return "\"DoorBeam\" : {\"Lenght\": " + Lenght + ", \"Stockref\": " + stockNumber;
		}

		protected override void SetPrice()
		{
			//TODO oledb requete price fct len
			Price = 2;
		}
	}
}
