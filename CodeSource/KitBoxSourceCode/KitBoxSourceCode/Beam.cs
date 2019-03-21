using System;
namespace KitBoxSourceCode
{
    public class Beam : GenericComponent
    {
        private int beamNumber;
        private static int beamNum = 0;

        public Beam(int len, int qty) : base(len, qty)
        {
            lenght = len;
            quantity = qty;
            price = 2;
            stockNumber = "1";
            if (beamNum == 2)
            {
                beamNum = 0;
            }
            beamNum++;
            beamNumber = beamNum;

            SetPrice();

            //TODO oledb stock ref fct len
            //TODO oledb book beam fct len & qty
        }

        public override string GetDetails()
        {
            return "\"Beam " + beamNumber + "\" : { \"Lenght\": " + lenght + ", \"Stockref\" : " + stockNumber;
        }

        protected override void SetPrice()
        {
            //TODO oledb requete price fct len
            price = 2;
        }
    }
}
