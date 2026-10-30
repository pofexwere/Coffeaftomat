namespace КофеАвтомат
{
	partial class Terminal
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
			fon = new Label();
			label1 = new Label();
			displey = new Label();
			SuspendLayout();
			// 
			// fon
			// 
			fon.AutoSize = true;
			fon.BackColor = SystemColors.ControlDark;
			fon.Font = new Font("Consolas", 15F, FontStyle.Bold);
			fon.Location = new Point(20, 63);
			fon.Name = "fon";
			fon.Size = new Size(131, 115);
			fon.TabIndex = 0;
			fon.Text = "+---------+\r\n|         |\r\n|         |\r\n|         |\r\n+---------+";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Consolas", 15F, FontStyle.Bold);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(197, 253);
			label1.TabIndex = 1;
			label1.Text = "+--------------+ \r\n|    оплата    |\r\n|              |\r\n|              |\r\n|              |\r\n|              |\r\n|              |\r\n|              |\r\n| Приложите    |\r\n|    карту     |\r\n+--------------+";
			// 
			// displey
			// 
			displey.AutoSize = true;
			displey.BackColor = Color.Transparent;
			displey.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			displey.Location = new Point(33, 79);
			displey.Name = "displey";
			displey.Size = new Size(104, 84);
			displey.TabIndex = 2;
			displey.Text = "Нажмите\r\nдля\r\nоплаты";
			displey.Click += label2_Click;
			// 
			// Terminal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			Controls.Add(displey);
			Controls.Add(fon);
			Controls.Add(label1);
			Name = "Terminal";
			Size = new Size(187, 254);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label fon;
		private Label label1;
		private Label displey;
	}
}
