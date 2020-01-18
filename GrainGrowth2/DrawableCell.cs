using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrainGrowthCore;

namespace GrainGrowth2
{
	class DrawableCell : Cell
	{
		//public Point Point { get; private set; }
		public Rectangle Rectangle { get; private set; }

		private static readonly Random Random = new Random();

		public DrawableCell(int x, int y, int cellSize)
		{
			x *= cellSize;
			y *= cellSize;
			//Point = new Point(x, y);
			Rectangle = new Rectangle(x, y, cellSize, cellSize);
		}

		public DrawableCell(int x, int y, int cellSize, Grain grain) : this(x, y, cellSize)
		{
			Grain = grain;
		}

		public void Resize(int cellSize)
		{
			int roz = cellSize - Rectangle.Height;
			Rectangle = new Rectangle(Rectangle.X + roz, Rectangle.Y + roz, cellSize, cellSize);
		}

		public void Move(int x, int y)
		{
			Rectangle = new Rectangle(x, y, Rectangle.Width, Rectangle.Width);
		}


		public void Draw(Graphics graphics)
		{
			graphics.FillRectangle(new SolidBrush(GetGrainColor()), Rectangle);
		}

		public Color GetGrainColor()
		{
			if (Grain.IsEmpty())
				return Color.White;
			else if (Grain.IsInjection())
				return Color.Black;
			else
			{
				while (ColorValues.Count < Grain.Id)
					AddNewRandomColor();
				return ColorTranslator.FromHtml(ColorValues[Grain.Id - 1]);
			}
		}


		private static void AddNewRandomColor()
		{
			Color newColor;
			while (true)
			{
				newColor = Color.FromArgb(255, Random.Next(0, 255), Random.Next(0, 255), Random.Next(0, 255));
				if (!ColorValues.Contains(ColorTranslator.ToHtml(newColor)))
					break;
			}
			ColorValues.Add(ColorTranslator.ToHtml(newColor));
		}

		public static Grain GetGrain(Color color)
		{
			if (color.ToArgb() == Color.White.ToArgb())
				return Grain.EmptyGrain;
			else if (color.ToArgb() == Color.Black.ToArgb())
				return Grain.InjectionGrain;
			else
			{
				var colorHtml = ColorTranslator.ToHtml(color);
				var id = ColorValues.FindIndex(x => colorHtml == x);
				if (id == -1)
					ColorValues.Add(colorHtml);
				return new Grain(++id);
			}
		}


		private static readonly List<string> ColorValues = new List<string> {
			"#FF0000", "#00FF00", "#0000FF", "#FFFF00", "#FF00FF", "#00FFFF",
			"#800000", "#008000", "#000080", "#808000", "#800080", "#008080", "#808080",
			"#C00000", "#00C000", "#0000C0", "#C0C000", "#C000C0", "#00C0C0", "#C0C0C0",
			"#400000", "#004000", "#000040", "#404000", "#400040", "#004040", "#404040",
			"#200000", "#002000", "#000020", "#202000", "#200020", "#002020", "#202020",
			"#600000", "#006000", "#000060", "#606000", "#600060", "#006060", "#606060",
			"#A00000", "#00A000", "#0000A0", "#A0A000", "#A000A0", "#00A0A0", "#A0A0A0",
			"#E00000", "#00E000", "#0000E0", "#E0E000", "#E000E0", "#00E0E0", "#E0E0E0",
		};
	}
}
