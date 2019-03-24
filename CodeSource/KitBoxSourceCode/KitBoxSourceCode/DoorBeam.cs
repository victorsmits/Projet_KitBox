using System;
namespace KitBoxSourceCode
{
    public class DoorBeam : GenericComponent
    {
        public DoorBeam(int len, int qty) : base(len, qty)
        {
            SetPrice();
            stockNumber = "1";
            //TODO oledb stock ref fct len
            //TODO oledb book fct len et qty
        }

        public override string GetDetails()
        {
            return "\"DoorBeam\" : {\"Lenght\": " + lenght + ", \"Stockref\": " + stockNumber;
        }

        protected override void SetPrice()
        {
            //TODO oledb requete price fct len
            price = 2;
        }
    }
}
