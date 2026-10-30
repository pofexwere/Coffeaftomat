using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class coffeAftom : UserControl
	{
		public coffeAftom()
		{
			InitializeComponent();
		}
		private void Potstavka_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(coffe.info());

			if ((potstavka1.pos == 1) && potstavka1.IsFull)// в кофе машине
			{
				potstavka1.Location = new Point(335, 358);
				potstavka1.take();
				infoScrean1.Write("Асортимент");
			}
			else if (potstavka1.pos == 2)// "в руках"
			{
				potstavka1.Location = new Point(159, 358);
				potstavka1.remove();
			}
		}


		private void Stakan_Click(object sender, EventArgs e)
		{
			potstavka1.addStakan();
		}

		private void Trash_Click(object sender, EventArgs e)
		{
			potstavka1.remove();

			infoScrean1.Write("Асортимент");

			Shokosirop.count = 0;
			Vanilsirop.count = 0;
			Karamsirop.count = 0;
			sugar.count = 0;	
		}
		private async void Sirp_Click(object sender, EventArgs e)
		{
			if (potstavka1.InPlace)
			{
				Sirop sirp = sender as Sirop;
				sirp.count += 1;
				potstavka1.addsirp();
			}
		}




		private void Hats_Click(object sender, EventArgs e)
		{
			potstavka1.addhat();
		}
		private async void AnyCofe_Click(object sender, EventArgs e)
		{
			if (terminal1.payd)
			{
				if (potstavka1.InPlace)
				{
					if (!potstavka1.IsFull)
					{

						CoffeName Scoffe = sender as CoffeName;
						potstavka1.feal(Scoffe.CoffeeType);
						kran.Play_Animation();
						Scoffe.Selected();
						infoScrean1.Cooking(Scoffe.CoffeeType);
						terminal1.Reset();
					}
					else
					{
						infoScrean1.Write("Стакан полон");
					}
				}
				else
				{
					infoScrean1.Write("Поставьте стакан");
				}
			}
			else
			{
				infoScrean1.Write("Сначало оплатите");
			}
		}
	}
}

