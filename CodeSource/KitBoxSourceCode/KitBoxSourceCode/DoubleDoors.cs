using System;
using System.Drawing;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class DoubleDoors : GenericStorageBox
    {
        private readonly List<Knop> knops;
        private string stockNumber;

        public string Materials { get; }
        public string DoorColor { get; }

        private StorageBox storageBox;

        StorageBox StorageBox { get; set; }

        public void AddBoxDecorator(StorageBox storageBox)
        {
            this.storageBox = storageBox;
        }

        public DoubleDoors(string color, string mat, int height, int len) : base(len, height)
        {
            DoorColor = color;
            Materials = mat;
            stockNumber = "1";

            knops = new List<Knop> {
                new Knop(),
                new Knop()
            };

            SetPrice();
        }

        protected override void SetPrice()
        {
            Price = 20;
            //TODO ole db fct color et mat
        }

        public override string GetDetails()
        {
            return "DoubleDoors -> Dimension : " + Height + " x " + Lenght
            + " | Coleur : " + DoorColor + " | Stock ref : " + stockNumber;
        }

    }
}
