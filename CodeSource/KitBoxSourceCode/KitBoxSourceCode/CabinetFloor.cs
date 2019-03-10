using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace KitBoxSourceCode
{
    public class CabinetFloor
    {
        public readonly List<StorageBox> cabinetFloor;

        private readonly Box box;
        private readonly BoxColor bc;
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
            box = new Box(lenght, height, depth);

            doorColor = doorCol;
            boxColor = panelCol;

            if (panelCol != null)
            {
                bc = new BoxColor("green");
                bc.AddBoxDecorator(box);
                cabinetFloor.Add(box);
                cabinetFloor.Add(bc);
            }

            if (doorMat != null)
            {
                db = new DoubleDoors(doorCol, doorMat);
                db.AddBoxDecorator(bc);
                cabinetFloor.Add(db);
            }

            SetFloorPrice();
            SetFloorHeight();
        }

        private void SetFloorPrice()
        {
            foreach (StorageBox elem in cabinetFloor)
            {
                //floorPrice += elem.GetPrice();
            }
        }

        private void SetFloorHeight()
        {
            foreach (StorageBox elem in cabinetFloor)
            {
                FloorHeight += elem.GetHeight();
            }
        }

        public void ShowPieces()
        {

        }
    }
}
