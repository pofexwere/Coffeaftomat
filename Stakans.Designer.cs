namespace КофеАвтомат
{
	partial class Stakans
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
			lblStakan = new Label();
			SuspendLayout();
			// 
			// lblStakan
			// 
			lblStakan.AutoSize = true;
			lblStakan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblStakan.Location = new Point(0, 0);
			lblStakan.Name = "lblStakan";
			lblStakan.Size = new Size(79, 21);
			lblStakan.TabIndex = 0;
			lblStakan.Text = "\U0001f95b\U0001f95b\U0001f95b";
			// 
			// Stakans
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			Controls.Add(lblStakan);
			Name = "Stakans";
			Size = new Size(80, 27);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblStakan;
	}
}
