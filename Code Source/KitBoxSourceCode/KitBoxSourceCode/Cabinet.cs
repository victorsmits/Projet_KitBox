using System;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
	public class Cabinet
	{
		private List<StorageBox> StorageBoxes;
		private int totalHeight;
		private int CabinetPrice = 0;
		private List<Angle> angles;

		public Cabinet()
		{
			totalHeight = 0;
			StorageBoxes = new List<StorageBox>();
			angles = new List<Angle>();
			AddAngles();
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

		private void AddAngles()
		{
			StorageBoxes.ForEach(TotalHeight);
			int i = 0;
			while (i < 4) {
				angles.Add(new Angle(totalHeight));
				i++;
			}
		}

		private void TotalHeight(StorageBox elem)
		{
			totalHeight += elem.GetHeight();
		}
	}
}
