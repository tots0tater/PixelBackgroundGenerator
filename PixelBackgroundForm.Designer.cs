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
			this.chooseColorsButton = new System.Windows.Forms.Button();
			this.squareSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.squareSizeLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.xUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.squareSizeNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// generateButton
			// 
			this.generateButton.Enabled = false;
			this.generateButton.Location = new System.Drawing.Point(80, 115);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(130, 23);
			this.generateButton.TabIndex = 0;
			this.generateButton.Text = "Generate Picture";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// xUpDown
			// 
			this.xUpDown.Location = new System.Drawing.Point(59, 12);
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
			this.xUpDown.Enter += new System.EventHandler(this.xUpDown_Enter);
			// 
			// yUpDown
			// 
			this.yUpDown.Location = new System.Drawing.Point(165, 12);
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
			this.yUpDown.Enter += new System.EventHandler(this.yUpDown_Enter);
			// 
			// xLabel
			// 
			this.xLabel.AutoSize = true;
			this.xLabel.Location = new System.Drawing.Point(36, 14);
			this.xLabel.Name = "xLabel";
			this.xLabel.Size = new System.Drawing.Size(17, 13);
			this.xLabel.TabIndex = 3;
			this.xLabel.Text = "X:";
			// 
			// yLabel
			// 
			this.yLabel.AutoSize = true;
			this.yLabel.Location = new System.Drawing.Point(142, 14);
			this.yLabel.Name = "yLabel";
			this.yLabel.Size = new System.Drawing.Size(17, 13);
			this.yLabel.TabIndex = 4;
			this.yLabel.Text = "Y:";
			// 
			// chooseColorsButton
			// 
			this.chooseColorsButton.Location = new System.Drawing.Point(80, 86);
			this.chooseColorsButton.Name = "chooseColorsButton";
			this.chooseColorsButton.Size = new System.Drawing.Size(130, 23);
			this.chooseColorsButton.TabIndex = 5;
			this.chooseColorsButton.Text = "Choose Colors";
			this.chooseColorsButton.UseVisualStyleBackColor = true;
			this.chooseColorsButton.Click += new System.EventHandler(this.chooseColorsButton_Click);
			// 
			// squareSizeNumericUpDown
			// 
			this.squareSizeNumericUpDown.Location = new System.Drawing.Point(150, 38);
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
			this.squareSizeNumericUpDown.Size = new System.Drawing.Size(60, 20);
			this.squareSizeNumericUpDown.TabIndex = 7;
			this.squareSizeNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// squareSizeLabel
			// 
			this.squareSizeLabel.AutoSize = true;
			this.squareSizeLabel.Location = new System.Drawing.Point(82, 40);
			this.squareSizeLabel.Name = "squareSizeLabel";
			this.squareSizeLabel.Size = new System.Drawing.Size(67, 13);
			this.squareSizeLabel.TabIndex = 8;
			this.squareSizeLabel.Text = "Square Size:";
			// 
			// PixelBackgroundForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 150);
			this.Controls.Add(this.squareSizeLabel);
			this.Controls.Add(this.squareSizeNumericUpDown);
			this.Controls.Add(this.chooseColorsButton);
			this.Controls.Add(this.yLabel);
			this.Controls.Add(this.xLabel);
			this.Controls.Add(this.yUpDown);
			this.Controls.Add(this.xUpDown);
			this.Controls.Add(this.generateButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "PixelBackgroundForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.xUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.squareSizeNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.NumericUpDown xUpDown;
		private System.Windows.Forms.NumericUpDown yUpDown;
		private System.Windows.Forms.Label xLabel;
		private System.Windows.Forms.Label yLabel;
		private System.Windows.Forms.Button chooseColorsButton;
		private System.Windows.Forms.NumericUpDown squareSizeNumericUpDown;
		private System.Windows.Forms.Label squareSizeLabel;
	}
}

