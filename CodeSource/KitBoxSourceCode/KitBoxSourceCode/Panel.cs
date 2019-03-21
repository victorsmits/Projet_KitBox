using System;
using Oledb = SqlOledb.Oledb;
namespace KitBoxSourceCode
{
    public class Panel : GenericComponent
    {
        private readonly int height;
        private readonly string color;
        private int panelNumber;
        private static int panelNum = 0;

        public int GetHeight => height;
        public string GetBoxColor => color;

        public Panel(int len, int hei, string col, int qty) : base(len, qty)
        {
            Console.WriteLine("coucou");
            lenght = len;
            height = hei;
            color = col;
            quantity = qty;
            stockNumber = "1"; // TODO OLEDB requete piece num fct dimension & color
            //TODO oledb book fct dimension, color & qty

            panelNum++;
            panelNumber = panelNum;
            SetPrice();
        }

        protected override void SetPrice()
        {
            //TODO oledb requete price fct dim et couleur
            price = 2;

        }

        public override string GetDetails()
        {
            return "\"Panel " + panelNumber + "\" : { \"height\": " + height + ", \"Lenght\": " + lenght
            + ", \"Coleur\": \"" + color + "\", \"Stockref\": " + stockNumber;
        }
    }
}
