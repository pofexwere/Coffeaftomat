namespace КофеАвтомат
{
	partial class Trash
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
			lblTrash = new Label();
			SuspendLayout();
			// 
			// lblTrash
			// 
			lblTrash.AutoSize = true;
			lblTrash.BackColor = SystemColors.ControlDark;
			lblTrash.Font = new Font("Consolas", 14F, FontStyle.Bold);
			lblTrash.Location = new Point(0, 0);
			lblTrash.Name = "lblTrash";
			lblTrash.Size = new Size(120, 132);
			lblTrash.TabIndex = 0;
			lblTrash.Text = "🗑️Мусорка\r\n|         |\r\n|         |\r\n|         |\r\n|         |\r\n|_________|";
			// 
			// Trash
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			Controls.Add(lblTrash);
			Name = "Trash";
			Size = new Size(123, 143);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTrash;
	}
}
