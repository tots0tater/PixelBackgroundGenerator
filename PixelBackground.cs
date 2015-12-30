using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PixelBackgroundGenerator
{
	public class PixelBackground
	{
		int _x, _y;
		private readonly List<Color> _colors = new List<Color>();
		private Color _borderColor = Color.Black;
		private Bitmap _background;
		int _squareSize = 1;
		int _borderSize = 1;

		/// <summary>
		/// Constructor that takes two integers as dimensions.
		/// </summary>
		/// <param name="x">The number of pixels in the x direction.</param>
		/// <param name="y">The number of pixels in the y direction.</param>
		public PixelBackground(int x, int y)
		{
			_x = x;
			_y = y;

			_background = new Bitmap(x, y);
		}

		public int X
		{
			get { return _x; }
		}
		public int Y
		{
			get { return _y; }
		}
		public int SquareSize
		{
			get { return _squareSize; }
			set { _squareSize = value; }
		}
		public int BorderSize
		{
			get { return _borderSize; }
			set { _borderSize = value; }
		}
		public Color BorderColor
		{
			get { return _borderColor; }
			set { _borderColor = value; }
		}

		// If the user for some reason wants access to our colors,
		// they shouldn't be able to directly edit it.
		public ReadOnlyCollection<Color> Colors
		{
			get { return _colors.ToList().AsReadOnly(); }
		}
		public Bitmap Background
		{
			get { return _background; }
		}

		public void AddColor(Color color)
		{
			_colors.Add(color);
		}

		public void RemoveColor(Color color)
		{
			_colors.Remove(color);
		}

		public void ResetColors()
		{
			_colors.Clear();
		}

		public void SetImageSize(int x, int y)
		{
			_x = x;
			_y = y;
			_background = new Bitmap(x, y);
		}

		/// <summary>
		/// Generates the pixel background.
		/// </summary>
		public void Generate()
		{
			Color[] colors = _colors.ToArray();
			Random r = new Random();

			// We increment our loop by square size since we're filling in our
			// picture with uniformly sized blocks
			for (int y = 0; y < _background.Height; y += _squareSize)
			{
				for (int x = 0; x < _background.Width; x += _squareSize)
				{
					Color pixelColor = colors[r.Next(colors.Length)];
					// Based off of the color, fill our image with a rectangle of size 
					using (Graphics g = Graphics.FromImage(_background))
					{
						Rectangle rectangle = new Rectangle(x, y, _squareSize, _squareSize);
						g.FillRectangle(new SolidBrush(pixelColor), rectangle);

						// Turns out if the width is set to 0, it defaults to 1.
						if (_borderSize != 0)
						{
							// Taken from stackoverflow
							Pen pen = new Pen(_borderColor, _borderSize);
							pen.Alignment = PenAlignment.Inset; //<-- this
							g.DrawRectangle(pen, rectangle);
						}
					}
				}
			}
		}
	}
}
