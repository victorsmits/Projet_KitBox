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

        //Adding a floor and seting up the new height and price
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

        //Add an angle by standard dimension
        public void AddAngles(string color)
        {
            angles = new Angle(cabinetHeight, color, 4);
        }

        //Listing all the parts needed for the cabinet
        public string GetPartList()
        {
            string partList = "";
            foreach (CabinetFloor elem in cabinetFloors)
            {
                partList += "\"Floor " + cabinetFloors.IndexOf(elem) + "\":{"
                + elem.ShowPieces() + "},";
            }
            partList += angles.GetDetails() + "}, \"CabinetPrice\": \"" + cabinetPrice + "\"";

			foreach (var element in possibleLength) {
				int elem = int.Parse(element);
				var difference = Math.Abs((long)elem - cabinetHeight);
				if (minDifference > difference) {
					if (elem > cabinetHeight) {
						minDifference = (int)difference;
						closest = elem;
					}
				}
			}
			angles = new Angle(closest, color, 4);
		}

        //Removing a floor
        public void DelCabinetFloor(int floor)
        {
            cabinetFloors.RemoveAt(floor);
        }

        //Add an angle with non-standard dimension
        public void AddScratchAngles(string color)
        {
            List<string> possibleLength = Oledb.LoadForDistinct("SELECT DISTINCT hauteur FROM Piece WHERE Référence = 'COR%DEC'");
            var closest = int.MaxValue;
            var minDifference = int.MaxValue;

            //Finding the first dimension available above the cabinet's height
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
