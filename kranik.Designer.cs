namespace КофеАвтомат
{
	partial class kranik
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
			kran = new Label();
			SuspendLayout();
			// 
			// kran
			// 
			kran.AutoSize = true;
			kran.BackColor = SystemColors.ControlDark;
			kran.Font = new Font("Consolas", 12F, FontStyle.Bold);
			kran.Location = new Point(0, 0);
			kran.Name = "kran";
			kran.Size = new Size(54, 19);
			kran.TabIndex = 0;
			kran.Text = "|\\ /|";
			// 
			// kranik
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			Controls.Add(kran);
			Name = "kranik";
			Size = new Size(55, 22);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label kran;
	}
}
