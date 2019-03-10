using System;
namespace KitBoxSourceCode
{
    public abstract class StorageBox
    {
        public int total = 0;
        public abstract void GetDetails();
        public abstract int GetPrice();
        public abstract int GetHeight();
    }
}
