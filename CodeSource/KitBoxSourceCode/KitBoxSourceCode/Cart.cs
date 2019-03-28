using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SqlOledb;

namespace KitBoxSourceCode
{
    public class Cart
    {
        private List<Cabinet> cabinets;
        private Profile clientProfile = null;
        private double cartPrice;

        public double GetCartPrice => cartPrice;

        public Cart()
        {
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
                    showCart += "},\"CartPrice\": \"" + cartPrice + "\"}";
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
