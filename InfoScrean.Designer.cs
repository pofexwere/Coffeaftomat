namespace КофеАвтомат
{
	partial class InfoScrean
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
			screan = new Label();
			SuspendLayout();
			// 
			// screan
			// 
			screan.AutoSize = true;
			screan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			screan.Location = new Point(0, 0);
			screan.Name = "screan";
			screan.Size = new Size(104, 21);
			screan.TabIndex = 0;
			screan.Text = "Асортимент";
			// 
			// InfoScrean
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(screan);
			Name = "InfoScrean";
			Size = new Size(114, 24);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label screan;
	}
}
