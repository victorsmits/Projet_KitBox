using System;
using System.Drawing;
namespace KitBoxSourceCode
{
	public class BoxColor : BoxDecorator
	{
		private readonly Color wallColor;

		public BoxColor(Color color)
		{
			wallColor = color;
		}

		public Color GetWallColor => wallColor;
	}
}
