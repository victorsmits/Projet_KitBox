using System;
namespace KitBoxSourceCode
{
    public class Panel : ICompoment
    {
        private readonly int Lenght;
        private readonly int Height;
        private readonly string Color;
        private int Price;
        private readonly int quantity;
        private readonly int stockNumber;

        public int GetLenght() => Lenght;
        public int GetHeight => Height;
        public string GetBoxColor => Color;
        public int GetPrice() => Price;

        public Panel(int len, int height, string color, int qty)
        {
            Lenght = len;
            Height = height;
            Color = color;
            quantity = qty;
            //stockNumber = 1; // TODO OLEDB requete piece num
            SetPrice();
        }

        private void SetPrice()
        {
            //TODO oledb requete price fct dim et couleur
            Price = 2;
        }

        public string GetDetails()
        {
            return "Panel -> Dimension : " + Height + " x " + Lenght
            + " | Coleur : " + Color + " | Stock ref : " + stockNumber;
        }
    }
}
