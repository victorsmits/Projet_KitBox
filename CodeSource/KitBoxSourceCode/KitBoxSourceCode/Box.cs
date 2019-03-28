using System;
using System.Collections.Generic;
using System.Linq;
namespace KitBoxSourceCode
{
	public class Box : GenericStorageBox
	{
		private Dictionary<IComponent, int> components;

		private readonly int boxWidth;

		public Dictionary<IComponent, int> GetComponents => components;

		public Box(int len, int height, int width, string col) : base(len, height)
		{
			components = new Dictionary<IComponent, int>();
			boxWidth = width;

            // Add all box's parts
            // Removing 4 cm from the upward and downward beams
			AddPanel(len, height - 4, width, col);
			AddCleat(height - 4);
			AddBeam(len, width);
			AddDoorBeam(len);

			SetPrice();
		}

		protected void SetPrice()
		{
			price = 0;
			foreach (IComponent key in components.Keys) {
				AddPrice(key);
			}
		}

		private void AddPrice(IComponent elem)
		{
			price = price + (elem.GetPrice() * components[elem]);
		}

		public override string GetDetails()
		{
			string format = "";
			foreach (IComponent key in components.Keys) {
				format += key.GetDetails() + ", \"Qty\": " + components[key] + "},";

			}

			return format;
		}

		private void AddPanel(int x, int y, int z, string col)
		{
			//Adding the back panel
			components.Add(new Panel(x, y, col, 1), 1);

			//Adding the 2 side panels
			components.Add(new Panel(z, y, col, 2), 2);

			//Adding the upward and downward panels
			components.Add(new Panel(z, x, col, 2), 2);
		}

        //Adding the 4 cleats
		private void AddCleat(int height)
		{
			components.Add(new Cleat(height, 4), 4);
		}

        private void AddBeam(int len, int width)
		{
			//Addind the two backward beams
            components.Add(new Beam(len, 2), 2);

            //Adding the four side beams
            components.Add(new Beam(width, 4), 4);

		}

		private void AddDoorBeam(int len)
		{
			//Adding the two front beams

            components.Add(new DoorBeam(len, 2), 2);
		}
	}
}
