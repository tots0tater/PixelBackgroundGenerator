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
		private PixelBackground _pixelBackground = new PixelBackground(1, 1);

		public PixelBackgroundForm()
		{
			InitializeComponent();
		}

		private void chooseColorsButton_Click(object sender, EventArgs e)
		{
			ColorForm cf = new ColorForm(_pixelBackground);
			cf.Show();
			
			// An event to re-enable our choose colors button
			cf.FormClosed += Cf_FormClosed;
			imageColorsButton.Enabled = false;
		}

		private void Cf_FormClosed(object sender, FormClosedEventArgs e)
		{
			imageColorsButton.Enabled = true;
			generateButton.Enabled = (_pixelBackground.Colors.Count > 0) ? true : false;
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			_pixelBackground.SetImageSize((int)xUpDown.Value, (int)yUpDown.Value);
			_pixelBackground.SquareSize = (int)squareSizeNumericUpDown.Value;
			_pixelBackground.BorderSize = (int)borderSizeNumericUpDown.Value;
			_pixelBackground.Generate();

			new ImageForm(_pixelBackground.Background).Show();
		}

		private void borderColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK)
			{
				borderColorButton.BackColor = cd.Color;
				_pixelBackground.BorderColor = cd.Color;
			}
		}

		// Utility method for highlighting the upDown objects
		private void borderSizeNumericUpDown_Enter(object sender, EventArgs e)
		{
			NumericUpDown upDown = sender as NumericUpDown;
			upDown.Select(0, upDown.Text.Length);
		}
	}
}
