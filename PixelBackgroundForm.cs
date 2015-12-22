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

		private void chooseColorsButton_Click(object sender, EventArgs e)
		{
			ColorForm cf = new ColorForm(_pb);
			cf.Show();
			
			// An event to re-enable our choose colors button
			cf.FormClosed += Cf_FormClosed;
			chooseColorsButton.Enabled = false;
		}

		private void Cf_FormClosed(object sender, FormClosedEventArgs e)
		{
			chooseColorsButton.Enabled = true;
			generateButton.Enabled = (_pb.Colors.Count > 0) ? true : false;
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
