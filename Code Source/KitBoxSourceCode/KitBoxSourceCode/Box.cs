using System;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class Box : StorageBox
    {
        private List<Compoment> Compoments;
        private int Price = 0;

        public Box()
        {
        }

        public int GetPrice()
        {
            Compoments.ForEach(AddPrice);
            return Price;
        }

        public void GetDetails()
        {

        }

        private void AddPrice(Compoment elem)
        {
            Price += elem.GetPrice();
        }
    }
}
