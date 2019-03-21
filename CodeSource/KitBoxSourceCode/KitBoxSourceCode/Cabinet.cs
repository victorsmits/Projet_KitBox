using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
namespace KitBoxSourceCode
{
    public class Cabinet
    {
        private List<CabinetFloor> storageBoxes;
        private int cabinetHeight;

        private int cabinetPrice = 0;

        public int GetCabinetPrice => cabinetPrice;
        public int GetCabinetHeight => cabinetHeight;

        private Angle angles;

        public Cabinet()
        {
            cabinetHeight = 0;
            storageBoxes = new List<CabinetFloor>();
        }

        public void AddStorageBox(CabinetFloor storage)
        {
            storageBoxes.Add(storage);
            cabinetPrice += storage.GetFloorPrice;
            cabinetHeight += storage.GetFloorHeight;
        }

        public int GetNumber()
        {
            return storageBoxes.Count;
        }

        public void AddAngles(string color)
        {
            angles = new Angle(cabinetHeight, color, 4);
        }

        public string GetPartList()
        {
            string partList = "";
            foreach (CabinetFloor elem in storageBoxes)
            {
                partList += "\"Floor " + storageBoxes.IndexOf(elem) + "\":{"
                + elem.ShowPieces();
            }
            partList += angles.GetDetails() + "},";
            return partList;
        }

    }
}
