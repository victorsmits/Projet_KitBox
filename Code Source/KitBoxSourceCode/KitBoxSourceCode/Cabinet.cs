using System;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
    public class Cabinet
    {
        private List<StorageBox> StorageBoxes;

        public Cabinet()
        {
        }

        public void AddStorageBox(StorageBox storage)
        {
            StorageBoxes.Add(storage);
        }
    }
}
