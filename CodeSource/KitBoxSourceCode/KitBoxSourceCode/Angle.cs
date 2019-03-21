using System;
using System.Drawing;
namespace KitBoxSourceCode
{
    public class Angle
    {
        private readonly int lenght;
        private readonly int price;
        private readonly int quantity;
        private readonly string angleColor;
        private readonly string stockRef;

        public Angle(int len, string color, int qty)
        {
            lenght = len;
            angleColor = color;
            CalculPrice(len, color);
            price = 2;
            stockRef = "1";
            quantity = qty;


            //TODO oledb book 4 angles fct len & color
            //TODO oledb stock ref fct len & color
        }

        public int GetLenght() => lenght;
        public int GetPrice() => price;

        private void CalculPrice(int len, string color)
        {
            //TODO oledb requete price fct len et color
        }

        public string GetDetails()
        {
            return "\"Angle\":{\"Length\":" + lenght + ",\"Color\":\"" + angleColor
            + "\",\"StockRef\":\"" + stockRef + "\",\"Quantity\":" + quantity + "}";
        }
    }
}
