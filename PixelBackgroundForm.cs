using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelBackgroundGenerator
{
	public partial class PixelBackgroundForm : Form
	{
		private Color _currentColor = new Color();
		private PixelBackground _pb = new PixelBackground(1, 1);

		public PixelBackgroundForm()
		{
			InitializeComponent();
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			_pb.SetImageSize((int)xUpDown.Value, (int)yUpDown.Value);
			_pb.SquareSize = (int)squareSizeNumericUpDown.Value;
			_pb.Generate();
			new ImageForm(_pb.Background).Show();
		}

		private void colorButton_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK)
			{
				colorButton.BackColor = cd.Color;
				_currentColor = cd.Color;

				// Only enabled after we add a color
				addColorButton.Enabled = true;
			}
		}

		private void addColorButton_Click(object sender, EventArgs e)
		{
			_pb.AddColor(_currentColor);
			generateButton.Enabled = true;
		}

		// Utility methods for highlighting the upDown objects
		private void xUpDown_Enter(object sender, EventArgs e)
		{
			xUpDown.Select(0, xUpDown.Text.Length);
		}
		private void yUpDown_Enter(object sender, EventArgs e)
		{
			yUpDown.Select(0, xUpDown.Text.Length);
		}
	}
}
