using System;
using System.Drawing;
using System.Collections.Generic;
namespace KitBoxSourceCode
{
	public class DoubleDoors : BoxDecorator
	{
		private Materials materials;
		private Color doorColor;
		private readonly List<Knop> knops;

		public DoubleDoors(Color color, Materials mat)
		{
			doorColor = color;
			materials = mat;
			knops = new List<Knop> {
				new Knop(),
				new Knop()
			};
		}

		public Materials Materials => materials;
		public Color DoorColor => doorColor;
	}
}
