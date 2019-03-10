using System;
namespace KitBoxSourceCode
{
    public class Cleat : ICompoment
    {
        private readonly int Lenght;
        private readonly int quantity;
        private readonly int Price;
        private readonly int stockNumber;

        public Cleat(int Len, int qty)
        {
            Lenght = Len;
            quantity = qty;
            Price = 2;
            stockNumber = 1;

            //TODO oledb requete price fct len
        }

        public int GetLenght() => Lenght;
        public string GetDetails()
        {
            return "Cleat -> Dimension : " + Lenght + " | Stock ref : " + stockNumber;
        }
        public int GetPrice() => Price;
    }
}
