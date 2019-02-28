using System;
using System.Drawing;

namespace KitBoxSourceCode
{
	public class CleatColor
	{
		private readonly Color cleatColor;

		public CleatColor(Color color)
		{
			cleatColor = color;
		}

		public Color GetCleatColor => cleatColor;
	}
}
