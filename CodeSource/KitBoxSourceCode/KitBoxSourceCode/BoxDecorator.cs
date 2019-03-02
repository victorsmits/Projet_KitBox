using System;
namespace KitBoxSourceCode
{
    public abstract class BoxDecorator : IStorageBox
    {
        private IStorageBox storageBox;

        IStorageBox StorageBox { get; set; }

        public void AddBoxDecorator(IStorageBox storageBox)
        {
            this.storageBox = storageBox;
        }

        public override void GetDetails()
        {
            if (storageBox != null)
            {
                storageBox.GetDetails();
            }
        }

        public override int GetHeight()
        {
            return 0;
        }

        public override int GetPrice()
        {
            return storageBox.GetPrice();
        }
    }
}
