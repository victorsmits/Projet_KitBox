using System;
namespace KitBoxSourceCode
{
    public abstract class BoxDecorator : StorageBox
    {
        private StorageBox storageBox;

        StorageBox StorageBox { get; set; }

        public void AddBoxDecorator(StorageBox storageBox)
        {
            this.storageBox = storageBox;
        }

        public override string GetDetails()
        {
            return storageBox.GetDetails();
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
