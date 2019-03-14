using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
namespace KitBoxSourceCode
{
    public class Cart
    {
        private List<Cabinet> Cabinets;
        private readonly int OrderNumber;
        private Profile ClientProfile = null;
        private int cartPrice;

        public int GetOrderNumber => OrderNumber;

        //TODO global increase ordernumber
        public Cart()
        {
            OrderNumber = 1;
            Cabinets = new List<Cabinet>();
            cartPrice = 0;
        }

        public void AddToCart(Cabinet cabinet)
        {
            Cabinets.Add(cabinet);
            cartPrice += cabinet.GetCabinetPrice;
        }

        public void AddCartProfile(Profile profile)
        {
            ClientProfile = profile;
        }

        public void GetProfile()
        {
            ClientProfile.ShowClientInfo();
        }

        public JObject ShowCart()
        {
            JObject JsonCart = new JObject();
            string ShowCart = "";
            foreach (Cabinet elem in Cabinets)
            {
                if (Cabinets.IndexOf(elem) == 0)
                {
                    ShowCart += "\n{";
                }
                ShowCart += "\"Cabinet " + Cabinets.IndexOf(elem) + "\":{"
                    + elem.GetPartList();
                if (Cabinets.IndexOf(elem) == Cabinets.Count - 1)
                {
                    ShowCart += "}}";
                }
                else
                {
                    ShowCart += "},";
                }
            }
            return JObject.Parse(ShowCart);
        }
    }
}
