namespace КофеАвтомат
{
	partial class Hats
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
			lblHats = new Label();
			SuspendLayout();
			// 
			// lblHats
			// 
			lblHats.AutoSize = true;
			lblHats.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblHats.Location = new Point(0, 0);
			lblHats.Name = "lblHats";
			lblHats.Size = new Size(84, 21);
			lblHats.TabIndex = 0;
			lblHats.Text = "крышеки";
			// 
			// Hats
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lblHats);
			Name = "Hats";
			Size = new Size(88, 20);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHats;
	}
}
