namespace КофеАвтомат
{
	partial class CoffeName
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
			lbldisplay = new Label();
			SuspendLayout();
			// 
			// lbldisplay
			// 
			lbldisplay.AutoSize = true;
			lbldisplay.BackColor = SystemColors.ControlDark;
			lbldisplay.Font = new Font("Consolas", 13F, FontStyle.Bold);
			lbldisplay.Location = new Point(0, 0);
			lbldisplay.Name = "lbldisplay";
			lbldisplay.Size = new Size(50, 22);
			lbldisplay.TabIndex = 0;
			lbldisplay.Text = "КОФЕ";
			lbldisplay.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// CoffeName
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			Controls.Add(lbldisplay);
			Name = "CoffeName";
			Size = new Size(64, 22);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbldisplay;
	}
}
