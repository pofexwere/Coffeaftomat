namespace КофеАвтомат
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			coffeAftom1 = new coffeAftom();
			SuspendLayout();
			// 
			// coffeAftom1
			// 
			coffeAftom1.BackColor = SystemColors.ControlDark;
			coffeAftom1.Location = new Point(0, -1);
			coffeAftom1.Name = "coffeAftom1";
			coffeAftom1.Size = new Size(708, 621);
			coffeAftom1.TabIndex = 0;
			coffeAftom1.Load += coffeAftom1_Load;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			ClientSize = new Size(705, 616);
			Controls.Add(coffeAftom1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion
		private coffeAftom coffeAftom1;
	}
}
