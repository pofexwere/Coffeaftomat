namespace КофеАвтомат
{
	partial class coffeAftom
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coffeAftom));
			Cofe_Mashine = new Label();
			info = new Label();
			terminal1 = new Terminal();
			CoffePlace = new Label();
			Espresso = new CoffeName();
			Amerikano = new CoffeName();
			Kaputino = new CoffeName();
			Mokatino = new CoffeName();
			Latte = new CoffeName();
			Tea = new CoffeName();
			Raf = new CoffeName();
			Kompot = new CoffeName();
			kran = new kranik();
			potstavka1 = new Potstavka();
			infoScrean1 = new InfoScrean();
			Vanilsirop = new Sirop();
			Shokosirop = new Sirop();
			Karamsirop = new Sirop();
			sugar = new Sirop();
			trash1 = new Trash();
			stakans1 = new Stakans();
			hats1 = new Hats();
			SuspendLayout();
			// 
			// Cofe_Mashine
			// 
			Cofe_Mashine.AutoSize = true;
			Cofe_Mashine.BackColor = Color.Transparent;
			Cofe_Mashine.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			Cofe_Mashine.Location = new Point(0, 0);
			Cofe_Mashine.Name = "Cofe_Mashine";
			Cofe_Mashine.Size = new Size(707, 616);
			Cofe_Mashine.TabIndex = 21;
			Cofe_Mashine.Text = resources.GetString("Cofe_Mashine.Text");
			// 
			// info
			// 
			info.AutoSize = true;
			info.BackColor = Color.Transparent;
			info.Font = new Font("Consolas", 13F, FontStyle.Bold);
			info.Location = new Point(545, 23);
			info.Name = "info";
			info.Size = new Size(140, 110);
			info.TabIndex = 42;
			info.Text = "+----------+ \r\n| оплатите | \r\n| выберите | \r\n| заберите | \r\n+----------+ \r\n";
			// 
			// terminal1
			// 
			terminal1.BackColor = SystemColors.ControlDark;
			terminal1.Location = new Point(351, 47);
			terminal1.Name = "terminal1";
			terminal1.Size = new Size(188, 257);
			terminal1.TabIndex = 43;
			// 
			// CoffePlace
			// 
			CoffePlace.AutoSize = true;
			CoffePlace.Font = new Font("Consolas", 20F, FontStyle.Bold);
			CoffePlace.Location = new Point(335, 358);
			CoffePlace.Name = "CoffePlace";
			CoffePlace.Size = new Size(0, 32);
			CoffePlace.TabIndex = 44;
			// 
			// Espresso
			// 
			Espresso.BackColor = SystemColors.ControlDark;
			Espresso.CoffeeType = "Эспрессо";
			Espresso.Location = new Point(58, 125);
			Espresso.Name = "Espresso";
			Espresso.Size = new Size(107, 21);
			Espresso.TabIndex = 45;
			Espresso.Click += AnyCofe_Click;
			// 
			// Amerikano
			// 
			Amerikano.BackColor = SystemColors.ControlDark;
			Amerikano.CoffeeType = "Американо";
			Amerikano.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			Amerikano.Location = new Point(171, 125);
			Amerikano.Name = "Amerikano";
			Amerikano.Size = new Size(113, 21);
			Amerikano.TabIndex = 46;
			Amerikano.Click += AnyCofe_Click;
			// 
			// Kaputino
			// 
			Kaputino.BackColor = SystemColors.ControlDark;
			Kaputino.CoffeeType = "Капучино";
			Kaputino.Location = new Point(58, 169);
			Kaputino.Name = "Kaputino";
			Kaputino.Size = new Size(107, 22);
			Kaputino.TabIndex = 47;
			Kaputino.Click += AnyCofe_Click;
			// 
			// Mokatino
			// 
			Mokatino.BackColor = SystemColors.ControlDark;
			Mokatino.CoffeeType = "Мокачино";
			Mokatino.Location = new Point(171, 170);
			Mokatino.Name = "Mokatino";
			Mokatino.Size = new Size(113, 22);
			Mokatino.TabIndex = 48;
			Mokatino.Click += AnyCofe_Click;
			// 
			// Latte
			// 
			Latte.BackColor = SystemColors.ControlDark;
			Latte.CoffeeType = "Латте";
			Latte.Location = new Point(58, 217);
			Latte.Name = "Latte";
			Latte.Size = new Size(99, 22);
			Latte.TabIndex = 49;
			Latte.Click += AnyCofe_Click;
			// 
			// Tea
			// 
			Tea.BackColor = SystemColors.ControlDark;
			Tea.CoffeeType = "Чай";
			Tea.Location = new Point(171, 259);
			Tea.Name = "Tea";
			Tea.Size = new Size(113, 22);
			Tea.TabIndex = 50;
			Tea.Click += AnyCofe_Click;
			// 
			// Raf
			// 
			Raf.BackColor = SystemColors.ControlDark;
			Raf.CoffeeType = "Раф";
			Raf.Location = new Point(66, 259);
			Raf.Name = "Raf";
			Raf.Size = new Size(99, 22);
			Raf.TabIndex = 51;
			Raf.Click += AnyCofe_Click;
			// 
			// Kompot
			// 
			Kompot.BackColor = SystemColors.ControlDark;
			Kompot.CoffeeType = "Компот";
			Kompot.Location = new Point(171, 217);
			Kompot.Name = "Kompot";
			Kompot.Size = new Size(113, 22);
			Kompot.TabIndex = 52;
			Kompot.Click += AnyCofe_Click;
			// 
			// kran
			// 
			kran.BackColor = SystemColors.ControlDark;
			kran.Location = new Point(159, 333);
			kran.Name = "kran";
			kran.Size = new Size(55, 22);
			kran.TabIndex = 53;
			// 
			// potstavka1
			// 
			potstavka1.BackColor = Color.Transparent;
			potstavka1.Location = new Point(159, 358);
			potstavka1.Name = "potstavka1";
			potstavka1.Size = new Size(55, 32);
			potstavka1.TabIndex = 54;
			potstavka1.Click += Potstavka_Click;
			// 
			// infoScrean1
			// 
			infoScrean1.Location = new Point(51, 95);
			infoScrean1.Name = "infoScrean1";
			infoScrean1.Size = new Size(241, 24);
			infoScrean1.TabIndex = 55;
			// 
			// Vanilsirop
			// 
			Vanilsirop.CoffeeType = "🍦Ванильный сироп";
			Vanilsirop.Location = new Point(466, 440);
			Vanilsirop.Name = "Vanilsirop";
			Vanilsirop.Size = new Size(217, 29);
			Vanilsirop.TabIndex = 56;
			Vanilsirop.Click += Sirp_Click;
			// 
			// Shokosirop
			// 
			Shokosirop.CoffeeType = "🍫Шоколадный сироп";
			Shokosirop.Location = new Point(442, 475);
			Shokosirop.Name = "Shokosirop";
			Shokosirop.Size = new Size(241, 29);
			Shokosirop.TabIndex = 57;
			Shokosirop.Click += Sirp_Click;
			// 
			// Karamsirop
			// 
			Karamsirop.CoffeeType = "🍬Карамельный сироп";
			Karamsirop.Location = new Point(442, 510);
			Karamsirop.Name = "Karamsirop";
			Karamsirop.Size = new Size(241, 29);
			Karamsirop.TabIndex = 58;
			Karamsirop.Click += Sirp_Click;
			// 
			// sugar
			// 
			sugar.CoffeeType = "Сахар";
			sugar.Location = new Point(615, 383);
			sugar.Name = "sugar";
			sugar.Size = new Size(68, 29);
			sugar.TabIndex = 59;
			sugar.Click += Sirp_Click;
			// 
			// trash1
			// 
			trash1.BackColor = SystemColors.ControlDark;
			trash1.Location = new Point(25, 463);
			trash1.Name = "trash1";
			trash1.Size = new Size(123, 143);
			trash1.TabIndex = 60;
			trash1.Click += Trash_Click;
			// 
			// stakans1
			// 
			stakans1.BackColor = SystemColors.ControlDark;
			stakans1.Location = new Point(416, 383);
			stakans1.Name = "stakans1";
			stakans1.Size = new Size(80, 21);
			stakans1.TabIndex = 61;
			stakans1.Click += Stakan_Click;
			// 
			// hats1
			// 
			hats1.Location = new Point(515, 383);
			hats1.Name = "hats1";
			hats1.Size = new Size(88, 20);
			hats1.TabIndex = 62;
			hats1.Click += Hats_Click;
			// 
			// coffeAftom
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			Controls.Add(hats1);
			Controls.Add(stakans1);
			Controls.Add(trash1);
			Controls.Add(sugar);
			Controls.Add(Karamsirop);
			Controls.Add(Shokosirop);
			Controls.Add(Vanilsirop);
			Controls.Add(infoScrean1);
			Controls.Add(potstavka1);
			Controls.Add(kran);
			Controls.Add(Kompot);
			Controls.Add(Raf);
			Controls.Add(Tea);
			Controls.Add(Latte);
			Controls.Add(Mokatino);
			Controls.Add(Kaputino);
			Controls.Add(Amerikano);
			Controls.Add(Espresso);
			Controls.Add(CoffePlace);
			Controls.Add(terminal1);
			Controls.Add(info);
			Controls.Add(Cofe_Mashine);
			Name = "coffeAftom";
			Size = new Size(712, 619);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label Cofe_Mashine;
		private Label info;
		private Terminal terminal1;
		private Label CoffePlace;
		private CoffeName Espresso;
		private CoffeName Amerikano;
		private CoffeName Kaputino;
		private CoffeName Mokatino;
		private CoffeName Latte;
		private CoffeName Tea;
		private CoffeName Raf;
		private CoffeName Kompot;
		private kranik kran;
		private Potstavka potstavka1;
		private InfoScrean infoScrean1;
		private Sirop Vanilsirop;
		private Sirop Shokosirop;
		private Sirop Karamsirop;
		private Sirop sugar;
		private Trash trash1;
		private Stakans stakans1;
		private Hats hats1;
	}
}
