using System;
namespace KitBoxSourceCode
{
    public class DoorBeam : GenericCompoment
    {
        public DoorBeam(int Len, int qty) : base(Len, qty)
        {
            SetPrice();
        }

        public override string GetDetails()
        {
            return "DoorBeam -> Dimension : " + Lenght + " | Stock ref : " + stockNumber;
        }

        protected override void SetPrice()
        {
            //TODO oledb requete price fct len
            Price = 2;
        }
    }
}
