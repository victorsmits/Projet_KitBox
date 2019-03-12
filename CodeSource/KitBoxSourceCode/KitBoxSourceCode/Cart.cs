using System;
using System.Collections.Generic;
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
    }
}
