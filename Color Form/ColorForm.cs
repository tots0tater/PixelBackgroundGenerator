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

		public ColorForm(PixelBackground pixelBackground)
		{
			InitializeComponent();
			_pixelBackground = pixelBackground;

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
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK)
				(sender as Button).BackColor = cd.Color;
		}

		private void submitColorsButton_Click(object sender, EventArgs e)
		{
			foreach (Control c in colorPanel.Controls)
				if (c.BackColor != Color.Transparent)
					_pixelBackground.AddColor(c.BackColor);

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
