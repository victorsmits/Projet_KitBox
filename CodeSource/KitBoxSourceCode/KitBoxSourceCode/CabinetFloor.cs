using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace KitBoxSourceCode
{
    public class CabinetFloor
    {
        public Dictionary<ICompoment, int> compoments;
        public readonly List<StorageBox> cabinetFloor;

        private readonly Box box;
        private readonly DoubleDoors db;

        private readonly string doorColor;
        private readonly string boxColor;

        private int floorPrice;
        private int FloorHeight;

        public int GetFloorHeight => FloorHeight;
        public int GetFloorPrice => floorPrice;

        public CabinetFloor(int height, int lenght, int depth,
            string doorCol = null, string doorMat = null, string panelCol = null)
        {
            floorPrice = 0;
            FloorHeight = 0;

            cabinetFloor = new List<StorageBox>();
            box = new Box(lenght, height, depth, panelCol);
            compoments = box.GetCompoments;
            cabinetFloor.Add(box);

            doorColor = doorCol;
            boxColor = panelCol;

            if (doorMat != null)
            {
                db = new DoubleDoors(doorCol, doorMat, height, lenght);
                db.AddBoxDecorator(box);
                cabinetFloor.Add(db);
            }

            SetFloorPrice();
            SetFloorHeight();
        }

        private void SetFloorPrice()
        {
            foreach (StorageBox elem in cabinetFloor)
            {
                floorPrice += elem.GetPrice();
            }
        }

        private void SetFloorHeight()
        {
            foreach (StorageBox elem in cabinetFloor)
            {
                FloorHeight += elem.GetHeight();
            }
        }

        public string ShowPieces()
        {
            string format = "";
            foreach (ICompoment Key in compoments.Keys)
            {
                format += Key.GetDetails() + " | Qty : " + compoments[Key] + "\n";
            }

            if (cabinetFloor.Count > 1)
            {
                format += cabinetFloor[1].GetDetails() + " | Qty : 1\n";
            }
            return format;
        }
    }
}
