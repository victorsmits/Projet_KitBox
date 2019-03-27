using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
namespace KitBoxSourceCode
{
    public class Cabinet
    {
        private List<CabinetFloor> cabinetFloors;
        private int cabinetHeight;

        private double cabinetPrice = 0;

        public double GetCabinetPrice => cabinetPrice;
        public int GetCabinetHeight => cabinetHeight;

        private Angle angles;

        public Cabinet()
        {
            cabinetHeight = 0;
            cabinetFloors = new List<CabinetFloor>();
        }

        public void AddStorageBox(CabinetFloor storage)
        {
            cabinetFloors.Add(storage);
            cabinetPrice += storage.GetFloorPrice;
            cabinetHeight += storage.GetFloorHeight;
        }

        public int GetNumber()
        {
            return cabinetFloors.Count;
        }

        public void AddAngles(string color)
        {
            angles = new Angle(cabinetHeight, color, 4);
        }

        public string GetPartList()
        {
            string partList = "";
            foreach (CabinetFloor elem in cabinetFloors)
            {
                partList += "\"Floor " + cabinetFloors.IndexOf(elem) + "\":{"
                + elem.ShowPieces() + "},";
            }
            partList += angles.GetDetails() + ", \"CabinetPrice\":" + cabinetPrice + "}";

            return partList;
        }

        public void DelCabinetFloor(int floor)
        {
            cabinetFloors.RemoveAt(floor);
        }
    }
}
