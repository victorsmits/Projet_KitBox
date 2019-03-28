using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using SqlOledb;

namespace KitBoxSourceCode
{
    public class Cabinet
    {
        private List<CabinetFloor> cabinetFloors;
        private int cabinetHeight;

        private double cabinetPrice = 0;

        public double GetCabinetPrice => cabinetPrice;
        public int GetCabinetHeight => cabinetHeight;

        private Angle angles;

        public Cabinet()
        {
            cabinetHeight = 0;
            cabinetFloors = new List<CabinetFloor>();
        }

        public void AddStorageBox(CabinetFloor storage)
        {
            cabinetFloors.Add(storage);
            cabinetPrice += storage.GetFloorPrice;
            cabinetHeight += storage.GetFloorHeight;
        }

        public int GetNumber()
        {
            return cabinetFloors.Count;
        }

        public void AddAngles(string color)
        {
            angles = new Angle(cabinetHeight, color, 4);
        }

        public string GetPartList()
        {
            string partList = "";
            foreach (CabinetFloor elem in cabinetFloors)
            {
                partList += "\"Floor " + cabinetFloors.IndexOf(elem) + "\":{"
                + elem.ShowPieces() + "},";
            }
            partList += angles.GetDetails() + "}, \"CabinetPrice\": \"" + cabinetPrice + "\"";

            return partList;
        }

        public void DelCabinetFloor(int floor)
        {
            cabinetFloors.RemoveAt(floor);
        }

        public void AddScratchAngles(string color)
        {
            List<string> possibleLength = Oledb.LoadForDistinct("SELECT DISTINCT hauteur FROM Piece WHERE Référence LIKE 'COR%'");
            var closest = int.MaxValue;
            var minDifference = int.MaxValue;

            foreach (var element in possibleLength)
            {
                int elem = int.Parse(element);
                var difference = Math.Abs((long)elem - cabinetHeight);
                if (minDifference > difference)
                {
                    if (elem > cabinetHeight)
                    {
                        minDifference = (int)difference;
                        closest = elem;
                    }
                }
            }
            angles = new Angle(closest, color, 4);
        }
    }
}
