using System;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class Cabinet
    {
        private List<StorageBox> StorageBoxes;
        private int CabinetPrice = 0;


        public Cabinet()
        {
        }

        public void AddStorageBox(StorageBox storage)
        {
            StorageBoxes.Add(storage);
            CabinetPrice += storage.GetPrice();
        }

        public int GetCabinetPrice => CabinetPrice;

        public int GetNumber()
        {
            return StorageBoxes.Count;
        }



    }
}
