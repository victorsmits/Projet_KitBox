//Contains the frame and the doors of a cabinet

using System;
namespace KitBoxSourceCode
{
    public interface IStorageBox
    {
        string GetDetails();
        double GetPrice();
        int GetHeight();
    }
}
