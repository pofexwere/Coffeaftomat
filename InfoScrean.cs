using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class InfoScrean : UserControl
	{
		public InfoScrean()
		{
			InitializeComponent();
		}
		public void Write(string text)
		{
			screan.Text = text;
		}
		public async void Cooking(string name)
		{
			screan.Text = $"Готовим {name}";
			await Task.Delay(500);
			screan.Text = $"Готовим. {name}";

			await Task.Delay(500);
			screan.Text = $"Готовим.. {name}";


			await Task.Delay(500);
			screan.Text = $"Готовим... {name}";


			await Task.Delay(500);
			screan.Text = $"{name} Готово!";

		}
	}
}
