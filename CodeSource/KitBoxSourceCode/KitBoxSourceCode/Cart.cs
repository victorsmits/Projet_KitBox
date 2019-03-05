using System;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class Cart
    {
        private List<Cabinet> Cabinets;
        private int OrderNumber;
        private Profile ClientProfile = null;

        //TODO global increase ordernumber
        public Cart()
        {
        }

        public void AddToCart(Cabinet cabinet)
        {
            Cabinets.Add(cabinet);
        }


    }
}
