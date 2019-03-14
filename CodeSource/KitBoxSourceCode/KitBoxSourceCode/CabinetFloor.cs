using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace KitBoxSourceCode
{
    public class CabinetFloor
    {
        public Dictionary<ICompoment, int> components;
        public readonly List<IStorageBox> cabinetFloor;

        private readonly Box box;
        private readonly DoubleDoors db;

        private readonly string DoorMat;

        private int floorPrice;
        private readonly int FloorHeight;

        public int GetFloorHeight => FloorHeight;
        public int GetFloorPrice => floorPrice;

        public CabinetFloor(int height, int lenght, int width,
            string doorMat = null, string panelCol = null)
        {
            floorPrice = 0;
            FloorHeight = height;

            cabinetFloor = new List<IStorageBox>();
            box = new Box(lenght, height, width, panelCol);
            components = box.GetCompoments;
            cabinetFloor.Add(box);

            DoorMat = doorMat;

            if (doorMat != null)
            {
                db = new DoubleDoors(doorMat, height, lenght);
                db.AddBoxDecorator(box);
                cabinetFloor.Add(db);
            }

            SetFloorPrice();
        }

        private void SetFloorPrice()
        {
            foreach (IStorageBox elem in cabinetFloor)
            {
                floorPrice += elem.GetPrice();
            }
        }

        public string ShowPieces()
        {
            string format = "";
            int i = 0;
            foreach (ICompoment Key in components.Keys)
            {
                format += Key.GetDetails() + ", \"Qty\": " + components[Key] + "},";
                i++;
            }

            if (cabinetFloor.Count > 1)
            {
                format += cabinetFloor[1].GetDetails() + ", \"Qty\" : 1},";
            }
            return format;


        }
    }
}
