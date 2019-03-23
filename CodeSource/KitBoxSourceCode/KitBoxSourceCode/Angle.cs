using System;
using System.Drawing;
using SqlOledb;
namespace KitBoxSourceCode
{
    public class Angle
    {
        private readonly int lenght;
        private int price;
        private readonly int quantity;
        private readonly string angleColor;
        private readonly string stockRef;

        public Angle(int len, string color, int qty)
        {
            Oledb.Connection();
            lenght = len;
            angleColor = color;
            CalculPrice();
            stockRef = Oledb.SqlRequest("SELECT Rfrence FROM Piece WHERE Rfrence LIKE COR% WHERE hauteur LIKE " + len + " WHERE Couleur LIKE " + angleColor); ;
            quantity = qty;

            //TODO oledb book 4 angles fct len & color
            //TODO oledb stock ref fct len & color
        }

        public int GetLenght() => lenght;
        public int GetPrice() => price;

        private void CalculPrice()
        {
            price = int.Parse(Oledb.SqlRequest("SELECT PrixClient FROM Piece WHERE Rfrence LIKE " + stockRef));
        }

        public string GetDetails()
        {
            return "\"Angle\":{\"Length\":" + lenght + ",\"Color\":\"" + angleColor
            + "\",\"StockRef\":\"" + stockRef + "\",\"Quantity\":" + quantity;
        }
    }
}
