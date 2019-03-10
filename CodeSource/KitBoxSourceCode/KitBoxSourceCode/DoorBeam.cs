using System;
namespace KitBoxSourceCode
{
    public class DoorBeam : ICompoment
    {
        private readonly int Lenght;
        private readonly int quantity;
        private readonly int Price;
        private readonly int stockNumber;

        public DoorBeam(int Len, int qty)
        {
            Lenght = Len;
            quantity = qty;
            Price = 2;
            stockNumber = 1;
            //TODO oledb requete price fct len
        }

        public int GetLenght() => Lenght;
        public int GetPrice() => Price;
        public string GetDetails()
        {
            return "DoorBeam -> Dimension : " + Lenght + " | Stock ref : " + stockNumber;
        }
    }
}
