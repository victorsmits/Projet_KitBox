//Gather all the parts from a single box

using System;
namespace KitBoxSourceCode
{
    public interface IComponent
    {
        double GetPrice();
        int GetLenght();
        string GetDetails();
    }
}
