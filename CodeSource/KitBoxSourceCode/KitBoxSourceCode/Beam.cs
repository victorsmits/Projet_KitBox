using System;
namespace KitBoxSourceCode
{
    public class Beam : ICompoment
    {
        private readonly int Lenght;
        private readonly int quantity;
        private readonly int Price;
        private readonly int stockNumber;

        public Beam(int Len, int qty)
        {
            Lenght = Len;
            quantity = qty;
            Price = 2;
            stockNumber = 1;

        }

        public int GetLenght() => Lenght;
        public int GetPrice() => Price;
        public string GetDetails()
        {
            return "Beam -> Dimension : " + Lenght + " | Stock ref : " + stockNumber;
        }
    }
}
