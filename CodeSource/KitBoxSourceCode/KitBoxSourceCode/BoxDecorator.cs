using System;
namespace KitBoxSourceCode
{
    public abstract class BoxDecorator
    {
        private StorageBox storageBox;

        StorageBox StorageBox { get; set; }

        public void AddBoxDecorator(StorageBox storageBox)
        {
            this.storageBox = storageBox;
        }

    }
}
