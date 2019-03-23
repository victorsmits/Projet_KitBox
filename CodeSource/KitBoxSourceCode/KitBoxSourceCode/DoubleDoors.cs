using System;
using System.Drawing;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class DoubleDoors : GenericStorageBox
    {
        private readonly Knop knops;
        private readonly string stockNumber;

        public string TheDoorMat { get; }

        private IStorageBox theStorageBox;

        IStorageBox GettheStorageBox { get; set; }

        public void AddBoxDecorator(IStorageBox storageBox)
        {
            this.theStorageBox = storageBox;
        }

        public DoubleDoors(string doormat, int hei, int len) : base(len, hei - 4)
        {
            TheDoorMat = doormat;
            stockNumber = "1";

            knops = new Knop(2);

            SetPrice();

            //TODO oledb stock ref fct dimension, doormat
            //TODO oledb book fct dimension & doormat
        }

        protected override void SetPrice()
        {
            price = 20;
            //TODO ole db fct color et mat
        }

        public override string GetDetails()
        {
            return "\"DoubleDoors\" : {\"height\": " + height + ",\"Lenght\": " + lenght
            + ", \"Material\": \"" + TheDoorMat + "\",\"Stockref\": " + stockNumber + knops.GetDetails();
        }

    }
}
