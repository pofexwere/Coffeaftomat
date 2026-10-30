namespace КофеАвтомат
{
	partial class Potstavka
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			Place = new Label();
			SuspendLayout();
			// 
			// Place
			// 
			Place.AutoSize = true;
			Place.BackColor = Color.Transparent;
			Place.Font = new Font("Consolas", 20F, FontStyle.Bold);
			Place.Location = new Point(4, 3);
			Place.Name = "Place";
			Place.Size = new Size(0, 32);
			Place.TabIndex = 0;
			// 
			// Potstavka
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			Controls.Add(Place);
			Name = "Potstavka";
			Size = new Size(56, 37);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label Place;
	}
}
