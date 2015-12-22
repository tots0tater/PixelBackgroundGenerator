namespace PixelBackgroundGenerator
{
	partial class PixelBackgroundForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.generateButton = new System.Windows.Forms.Button();
			this.xUpDown = new System.Windows.Forms.NumericUpDown();
			this.yUpDown = new System.Windows.Forms.NumericUpDown();
			this.xLabel = new System.Windows.Forms.Label();
			this.yLabel = new System.Windows.Forms.Label();
			this.imageColorsButton = new System.Windows.Forms.Button();
			this.squareSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.squareSizeLabel = new System.Windows.Forms.Label();
			this.borderLabel = new System.Windows.Forms.Label();
			this.borderSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.resolutionGroupBox = new System.Windows.Forms.GroupBox();
			this.imagePropertiesGroupBox = new System.Windows.Forms.GroupBox();
			this.borderColorButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.xUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.squareSizeNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.borderSizeNumericUpDown)).BeginInit();
			this.resolutionGroupBox.SuspendLayout();
			this.imagePropertiesGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// generateButton
			// 
			this.generateButton.BackColor = System.Drawing.Color.SeaGreen;
			this.generateButton.Enabled = false;
			this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.generateButton.ForeColor = System.Drawing.Color.White;
			this.generateButton.Location = new System.Drawing.Point(75, 153);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(123, 23);
			this.generateButton.TabIndex = 6;
			this.generateButton.Text = "Generate Picture";
			this.generateButton.UseVisualStyleBackColor = false;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// xUpDown
			// 
			this.xUpDown.Location = new System.Drawing.Point(24, 19);
			this.xUpDown.Maximum = new decimal(new int[] {
            7680,
            0,
            0,
            0});
			this.xUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.xUpDown.Name = "xUpDown";
			this.xUpDown.Size = new System.Drawing.Size(66, 20);
			this.xUpDown.TabIndex = 1;
			this.xUpDown.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			this.xUpDown.Enter += new System.EventHandler(this.borderSizeNumericUpDown_Enter);
			// 
			// yUpDown
			// 
			this.yUpDown.Location = new System.Drawing.Point(130, 19);
			this.yUpDown.Maximum = new decimal(new int[] {
            4320,
            0,
            0,
            0});
			this.yUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.yUpDown.Name = "yUpDown";
			this.yUpDown.Size = new System.Drawing.Size(64, 20);
			this.yUpDown.TabIndex = 2;
			this.yUpDown.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
			this.yUpDown.Enter += new System.EventHandler(this.borderSizeNumericUpDown_Enter);
			// 
			// xLabel
			// 
			this.xLabel.AutoSize = true;
			this.xLabel.Location = new System.Drawing.Point(1, 21);
			this.xLabel.Name = "xLabel";
			this.xLabel.Size = new System.Drawing.Size(17, 13);
			this.xLabel.TabIndex = 8;
			this.xLabel.Text = "X:";
			// 
			// yLabel
			// 
			this.yLabel.AutoSize = true;
			this.yLabel.Location = new System.Drawing.Point(107, 21);
			this.yLabel.Name = "yLabel";
			this.yLabel.Size = new System.Drawing.Size(17, 13);
			this.yLabel.TabIndex = 7;
			this.yLabel.Text = "Y:";
			// 
			// imageColorsButton
			// 
			this.imageColorsButton.Location = new System.Drawing.Point(9, 44);
			this.imageColorsButton.Name = "imageColorsButton";
			this.imageColorsButton.Size = new System.Drawing.Size(108, 23);
			this.imageColorsButton.TabIndex = 5;
			this.imageColorsButton.Text = "Image Colors";
			this.imageColorsButton.UseVisualStyleBackColor = true;
			this.imageColorsButton.Click += new System.EventHandler(this.chooseColorsButton_Click);
			// 
			// squareSizeNumericUpDown
			// 
			this.squareSizeNumericUpDown.Location = new System.Drawing.Point(74, 18);
			this.squareSizeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.squareSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.squareSizeNumericUpDown.Name = "squareSizeNumericUpDown";
			this.squareSizeNumericUpDown.Size = new System.Drawing.Size(43, 20);
			this.squareSizeNumericUpDown.TabIndex = 3;
			this.squareSizeNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.squareSizeNumericUpDown.Enter += new System.EventHandler(this.borderSizeNumericUpDown_Enter);
			// 
			// squareSizeLabel
			// 
			this.squareSizeLabel.AutoSize = true;
			this.squareSizeLabel.Location = new System.Drawing.Point(6, 20);
			this.squareSizeLabel.Name = "squareSizeLabel";
			this.squareSizeLabel.Size = new System.Drawing.Size(67, 13);
			this.squareSizeLabel.TabIndex = 6;
			this.squareSizeLabel.Text = "Square Size:";
			// 
			// borderLabel
			// 
			this.borderLabel.AutoSize = true;
			this.borderLabel.Location = new System.Drawing.Point(136, 20);
			this.borderLabel.Name = "borderLabel";
			this.borderLabel.Size = new System.Drawing.Size(64, 13);
			this.borderLabel.TabIndex = 5;
			this.borderLabel.Text = "Border Size:";
			// 
			// borderSizeNumericUpDown
			// 
			this.borderSizeNumericUpDown.Location = new System.Drawing.Point(206, 18);
			this.borderSizeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.borderSizeNumericUpDown.Name = "borderSizeNumericUpDown";
			this.borderSizeNumericUpDown.Size = new System.Drawing.Size(43, 20);
			this.borderSizeNumericUpDown.TabIndex = 4;
			this.borderSizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.borderSizeNumericUpDown.Enter += new System.EventHandler(this.borderSizeNumericUpDown_Enter);
			// 
			// resolutionGroupBox
			// 
			this.resolutionGroupBox.Controls.Add(this.yUpDown);
			this.resolutionGroupBox.Controls.Add(this.xUpDown);
			this.resolutionGroupBox.Controls.Add(this.xLabel);
			this.resolutionGroupBox.Controls.Add(this.yLabel);
			this.resolutionGroupBox.Location = new System.Drawing.Point(12, 12);
			this.resolutionGroupBox.Name = "resolutionGroupBox";
			this.resolutionGroupBox.Size = new System.Drawing.Size(200, 47);
			this.resolutionGroupBox.TabIndex = 9;
			this.resolutionGroupBox.TabStop = false;
			this.resolutionGroupBox.Text = "Resolution";
			// 
			// imagePropertiesGroupBox
			// 
			this.imagePropertiesGroupBox.Controls.Add(this.borderColorButton);
			this.imagePropertiesGroupBox.Controls.Add(this.label1);
			this.imagePropertiesGroupBox.Controls.Add(this.squareSizeLabel);
			this.imagePropertiesGroupBox.Controls.Add(this.squareSizeNumericUpDown);
			this.imagePropertiesGroupBox.Controls.Add(this.imageColorsButton);
			this.imagePropertiesGroupBox.Controls.Add(this.borderSizeNumericUpDown);
			this.imagePropertiesGroupBox.Controls.Add(this.borderLabel);
			this.imagePropertiesGroupBox.Location = new System.Drawing.Point(12, 66);
			this.imagePropertiesGroupBox.Name = "imagePropertiesGroupBox";
			this.imagePropertiesGroupBox.Size = new System.Drawing.Size(260, 81);
			this.imagePropertiesGroupBox.TabIndex = 10;
			this.imagePropertiesGroupBox.TabStop = false;
			this.imagePropertiesGroupBox.Text = "Image Properties";
			// 
			// borderColorButton
			// 
			this.borderColorButton.BackColor = System.Drawing.Color.Black;
			this.borderColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.borderColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.borderColorButton.Location = new System.Drawing.Point(206, 44);
			this.borderColorButton.Name = "borderColorButton";
			this.borderColorButton.Size = new System.Drawing.Size(43, 22);
			this.borderColorButton.TabIndex = 11;
			this.borderColorButton.UseVisualStyleBackColor = false;
			this.borderColorButton.Click += new System.EventHandler(this.borderColorButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(132, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Border Color:";
			// 
			// PixelBackgroundForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 181);
			this.Controls.Add(this.imagePropertiesGroupBox);
			this.Controls.Add(this.resolutionGroupBox);
			this.Controls.Add(this.generateButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "PixelBackgroundForm";
			this.Text = "Pixel Background";
			((System.ComponentModel.ISupportInitialize)(this.xUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.squareSizeNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.borderSizeNumericUpDown)).EndInit();
			this.resolutionGroupBox.ResumeLayout(false);
			this.resolutionGroupBox.PerformLayout();
			this.imagePropertiesGroupBox.ResumeLayout(false);
			this.imagePropertiesGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.NumericUpDown xUpDown;
		private System.Windows.Forms.NumericUpDown yUpDown;
		private System.Windows.Forms.Label xLabel;
		private System.Windows.Forms.Label yLabel;
		private System.Windows.Forms.Button imageColorsButton;
		private System.Windows.Forms.NumericUpDown squareSizeNumericUpDown;
		private System.Windows.Forms.Label squareSizeLabel;
		private System.Windows.Forms.Label borderLabel;
		private System.Windows.Forms.NumericUpDown borderSizeNumericUpDown;
		private System.Windows.Forms.GroupBox resolutionGroupBox;
		private System.Windows.Forms.GroupBox imagePropertiesGroupBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button borderColorButton;
	}
}

