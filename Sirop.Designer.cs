namespace КофеАвтомат
{
	partial class Sirop
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
			lblName = new Label();
			SuspendLayout();
			// 
			// Name
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			lblName.Location = new Point(0, 0);
			lblName.Name = "Name";
			lblName.Size = new Size(73, 28);
			lblName.TabIndex = 0;
			lblName.Text = "Сироп";

			// 
			// Sirop
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lblName);
			Name = "Sirop";
			Size = new Size(217, 29);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblName;
	}
}
