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
	public partial class ImageForm : Form
	{
		int _heightDif;

		public ImageForm(Bitmap image)
		{
			InitializeComponent();
			backgroundPictureBox.Image = image;
			UpdateScaling();

			// The picture box doesn't reach the top of the form; therefore,
			// this will make the image scaling look prettier 
			_heightDif = this.Height - backgroundPictureBox.Height;
		}

		private void backgroundPictureBox_ClientSizeChanged(object sender, EventArgs e)
		{
			UpdateScaling();
		}

		private void UpdateScaling()
		{
			if (backgroundPictureBox.Image.Size.Width < this.Width &&
				backgroundPictureBox.Image.Size.Height < this.Height - _heightDif)
			{
				backgroundPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
			}
			// We need our picture to do display scaling
			else
			{
				backgroundPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Png Image (.png)|*.png|JPEG Image (.jpeg)|*.jpeg|Gif Image (.gif)|*.gif|Bitmap Image (.bmp)|*.bmp";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				string extension = System.IO.Path.GetExtension(sfd.FileName);

				System.Drawing.Imaging.ImageFormat format;
				if (".jpg" == extension.ToLower() || ".jpeg" == extension.ToLower())
					format = System.Drawing.Imaging.ImageFormat.Jpeg;
				else if (".bmp" == extension.ToLower())
					format = System.Drawing.Imaging.ImageFormat.Bmp;
				else if (".gif" == extension.ToLower())
					format = System.Drawing.Imaging.ImageFormat.Gif;
				else if (".png" == extension.ToLower())
					format = System.Drawing.Imaging.ImageFormat.Png;
				else
					format = null;      // This shouldn't happen

				backgroundPictureBox.Image.Save(sfd.FileName, format);
			}
		}
	}
}
