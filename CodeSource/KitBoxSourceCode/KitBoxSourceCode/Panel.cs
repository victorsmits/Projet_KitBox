using System;
using Oledb = SqlOledb.Oledb;
namespace KitBoxSourceCode
{
    public class Panel : GenericCompoment
    {
        private readonly int Height;
        private readonly string Color;
        private int panelNumber;
        private static int panelNum = 0;

        public int GetHeight => Height;
        public string GetBoxColor => Color;

        public Panel(int len, int height, string color, int qty) : base(len, qty)
        {
            Console.WriteLine("coucou");
            Lenght = len;
            Height = height;
            Color = color;
            quantity = qty;
            stockNumber = "1"; // TODO OLEDB requete piece num

            panelNum++;
            panelNumber = panelNum;
            SetPrice();
        }

        protected override void SetPrice()
        {
            //TODO oledb requete price fct dim et couleur
            Price = 2;

        }

        public override string GetDetails()
        {
            return "\"Panel " + panelNumber + "\" : { \"height\": " + Height + ", \"Lenght\": " + Lenght
            + ", \"Coleur\": \"" + Color + "\", \"Stockref\": " + stockNumber;
        }
    }
}
