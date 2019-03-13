using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
namespace KitBoxSourceCode
{
    public class Cabinet
    {
        private List<CabinetFloor> StorageBoxes;
        private int cabinetHeight;

        private int CabinetPrice = 0;

        public int GetCabinetPrice => CabinetPrice;
        public int GetCabinetHeight => cabinetHeight;

        private List<Angle> angles;

        public Cabinet()
        {
            cabinetHeight = 0;
            StorageBoxes = new List<CabinetFloor>();
            angles = new List<Angle>();
        }

        public void AddStorageBox(CabinetFloor storage)
        {
            StorageBoxes.Add(storage);
            CabinetPrice += storage.GetFloorPrice;
            cabinetHeight += storage.GetFloorHeight;
        }

        public int GetNumber()
        {
            return StorageBoxes.Count;
        }

        public void AddAngles(Color color)
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
            string PartList = "";
            foreach (CabinetFloor elem in StorageBoxes)
            {
                PartList += "\nFloor " + StorageBoxes.IndexOf(elem) + ":\n" + elem.ShowPieces();
            }
            return PartList;
        }
    }
}
