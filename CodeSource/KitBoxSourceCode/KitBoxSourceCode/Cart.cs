using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
namespace KitBoxSourceCode
{
    public class Cart
    {
        private List<Cabinet> cabinets;
        private readonly int orderNumber;
        private Profile clientProfile = null;
        private int cartPrice;

        public int GetOrderNumber => orderNumber;

        //TODO global increase ordernumber
        public Cart()
        {
            orderNumber = 1;
            cabinets = new List<Cabinet>();
            cartPrice = 0;
        }

        public void AddToCart(Cabinet cabinet)
        {
            cabinets.Add(cabinet);
            cartPrice += cabinet.GetCabinetPrice;
        }

        public void AddCartProfile(Profile profile)
        {
            clientProfile = profile;
        }

        public void GetProfile()
        {
            clientProfile.ShowClientInfo();
        }

        public JObject ShowCart()
        {
            JObject jsonCart = new JObject();
            string showCart = "";
            foreach (Cabinet elem in cabinets)
            {
                if (cabinets.IndexOf(elem) == 0)
                {
                    showCart += "\n{";
                }
                showCart += "\"Cabinet " + cabinets.IndexOf(elem) + "\":{"
                    + elem.GetPartList();
                if (cabinets.IndexOf(elem) == cabinets.Count - 1)
                {
                    showCart += "}}";
                }
                else
                {
                    showCart += "},";
                }
            }
            return JObject.Parse(showCart);
        }
    }
}
