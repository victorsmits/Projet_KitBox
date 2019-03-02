using System;
using System.Collections.Generic;
using System.Drawing;
namespace KitBoxSourceCode
{
    public class Cabinet
    {
        private List<IStorageBox> StorageBoxes;
        private int totalHeight;
        private int CabinetPrice = 0;
        private List<Angle> angles;

        public Cabinet()
        {
            totalHeight = 0;
            StorageBoxes = new List<IStorageBox>();
            angles = new List<Angle>();
        }

        public void AddStorageBox(IStorageBox storage)
        {
            StorageBoxes.Add(storage);
            CabinetPrice += storage.GetPrice();
            totalHeight += storage.GetHeight();
        }

        public int GetCabinetPrice()
        {
            return CabinetPrice;
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
                angles.Add(new Angle(totalHeight, color));
                i++;
            }
        }

        public int GetTotalHieght()
        {
            return totalHeight;
        }
    }
}
