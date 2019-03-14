using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
namespace KitBoxSourceCode
{
    public class Cabinet
    {
        private List<CabinetFloor> storageBoxes;
        private Dictionary<int, IStorageBox> cabinetPartList;
        private int cabinetHeight;

        private int cabinetPrice = 0;

        public int GetCabinetPrice => cabinetPrice;
        public int GetCabinetHeight => cabinetHeight;

        private List<Angle> angles;

        public Cabinet()
        {
            cabinetHeight = 0;
            storageBoxes = new List<CabinetFloor>();
            angles = new List<Angle>();
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
            int i = 0;
            while (i < 4)
            {
                angles.Add(new Angle(cabinetHeight, color));
                i++;
            }
        }

        public string GetPartList()
        {
            string partList = "";
            foreach (CabinetFloor elem in storageBoxes)
            {
                partList += "\"Floor " + storageBoxes.IndexOf(elem) + "\":{" + elem.ShowPieces() + "},";
            }
            return partList;
        }

    }
}
