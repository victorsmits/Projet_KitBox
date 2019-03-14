using System;
using System.Drawing;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class DoubleDoors : GenericStorageBox
    {
        private readonly List<Knop> knops;
        private string stockNumber;

        public string theDoorMat { get; }

        private IStorageBox theStorageBox;

        IStorageBox theStorageBox { get; set; }

        public void AddBoxDecorator(IStorageBox storageBox)
        {
            this.theStorageBox = storageBox;
        }

        public DoubleDoors(string doormat, int hei, int len) : base(len, hei)
        {
            theDoorMat = doormat;
            stockNumber = "1";

            knops = new List<Knop> {
                new Knop(),
                new Knop()
            };

            SetPrice();
        }

        protected override void SetPrice()
        {
            price = 20;
            //TODO ole db fct color et mat
        }

        public override string GetDetails()
        {
            return "\"DoubleDoors\" : {\"height\": " + height + ",\"Lenght\": " + lenght
            + ", \"Material\": \"" + theDoorMat + "\", \"Stockref\": " + stockNumber;
        }

    }
}
