using System;
using System.Drawing;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
	public class DoubleDoors : BoxDecorator
	{
		private readonly List<Knop> knops;
		private readonly int Price;

		public int GetPrice => Price;

		public DoubleDoors(Color color, Materials mat)
		{
			DoorColor = color;
			Materials = mat;
			knops = new List<Knop> {
				new Knop(),
				new Knop()
			};

			SetPrice();
		}

		public Materials Materials { get; }
		public Color DoorColor { get; }

		private void SetPrice()
		{
			//TODO
		}
	}
}
