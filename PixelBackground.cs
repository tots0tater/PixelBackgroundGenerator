using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace PixelBackgroundGenerator
{
	public class PixelBackground
	{
		int _x = 0;
		int _y = 0;
		private readonly HashSet<Color> _colors = new HashSet<Color>();
		private Bitmap _background;
		int _squareSize = 1;

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
						g.FillRectangle(new SolidBrush(pixelColor), new Rectangle(x, y, _squareSize, _squareSize));
				}
			}
		}
	}
}
