using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace KitBoxSourceCode
{
    public class CabinetFloor
    {
        public Dictionary<IComponent, int> components;
        public readonly List<IStorageBox> storageBoxes;

        private readonly Box box;
        private readonly DoubleDoors db;

        private readonly string theDoorMat;

        private double floorPrice;
        private readonly int floorHeight;

        public int GetFloorHeight => floorHeight;
        public double GetFloorPrice => floorPrice;

        public CabinetFloor(int height, int length, int width,
            string doorMat = null, string panelCol = null)
        {
            floorPrice = 0;
            floorHeight = height;

            storageBoxes = new List<IStorageBox>();
            box = new Box(length, height, width, panelCol);
            components = box.GetComponents;
            storageBoxes.Add(box);

            theDoorMat = doorMat;

            if (doorMat != null)
            {
                db = new DoubleDoors(doorMat, height, (length/2)+2);
                db.AddBoxDecorator(box);
                storageBoxes.Add(db);
            }

            SetFloorPrice();
        }

        private void SetFloorPrice()
        {
            foreach (IStorageBox elem in storageBoxes)
            {
                floorPrice += elem.GetPrice();
            }
        }

        public string ShowPieces()
        {
            string format = "";
            int i = 0;
            foreach (IComponent key in components.Keys)
            {
                format += key.GetDetails() + ", \"Qty\": " + components[key] + "},";
                i++;
            }

            if (storageBoxes.Count > 1)
            {
                format += storageBoxes[1].GetDetails() + ", \"Qty\" : 1},";
            }
            return format;
        }
    }
}
