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
	public partial class ColorForm : Form
	{
		private PixelBackground _pixelBackground;
		private ColorDialog _colorDialog;

		public ColorForm(PixelBackground pixelBackground, ColorDialog colorDialog)
		{
			InitializeComponent();
			_pixelBackground = pixelBackground;
			_colorDialog = colorDialog;

			// Setting our color box with colors we already have.
			int i = 0;
			foreach (Color c in _pixelBackground.Colors)
				colorPanel.Controls[i++].BackColor = c;

			foreach (Control c in colorPanel.Controls)
			{
				ContextMenu cm = new ContextMenu();
				cm.MenuItems.Add("Remove Color");
				c.ContextMenu = cm;

				// An event for when the user clicks the button
				c.ContextMenu.MenuItems[0].Click += (sender, e) => ColorButtonContextMenu_Click(sender, e, c as Button);
			}
		}

		private void ColorButtonContextMenu_Click(object sender, EventArgs e, Button button)
		{
			_pixelBackground.RemoveColor(button.BackColor);
			button.BackColor = Color.Transparent;
		}

		private void colorButton_Click(object sender, EventArgs e)
		{
			if (_colorDialog.ShowDialog() == DialogResult.OK)
			{
				// Removes the current color of the button. This replaces the color
				_pixelBackground.RemoveColor((sender as Button).BackColor);
				// Then we add the color
				_pixelBackground.AddColor(_colorDialog.Color);

				(sender as Button).BackColor = _colorDialog.Color;
			}
		}

		private void submitColorsButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			foreach (Control c in colorPanel.Controls)
				c.BackColor = Color.Transparent;

			_pixelBackground.ResetColors();
		}
	}
}
