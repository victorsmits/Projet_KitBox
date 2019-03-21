using System;
namespace KitBoxSourceCode
{
    public class Beam : GenericCompoment
    {
        private int beamNumber;
        private static int beamNum = 0;

        public Beam(int Len, int qty) : base(Len, qty)
        {
            Lenght = Len;
            quantity = qty;
            Price = 2;
            stockNumber = "1";

            beamNum++;
            beamNumber = beamNum;

            SetPrice();
        }

        public override string GetDetails()
        {
            return "\"Beam " + beamNumber + "\" : { \"Lenght\": " + Lenght + ", \"Stockref\" : " + stockNumber;
        }

        protected override void SetPrice()
        {
            //TODO oledb requete price fct len
            Price = 2;
        }
    }
}
