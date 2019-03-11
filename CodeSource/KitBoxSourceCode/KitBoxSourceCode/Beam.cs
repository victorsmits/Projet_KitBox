using System;
namespace KitBoxSourceCode
{
    public class Beam : GenericCompoment
    {

        public Beam(int Len, int qty) : base(Len, qty)
        {
            Lenght = Len;
            quantity = qty;
            Price = 2;
            stockNumber = "1";
            SetPrice();
        }

        public override string GetDetails()
        {
            return "Beam -> Dimension : " + Lenght + " | Stock ref : " + stockNumber;
        }

        protected override void SetPrice()
        {
            //TODO oledb requete price fct len
            Price = 2;
        }
    }
}
