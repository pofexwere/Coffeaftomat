using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class kranik : UserControl
	{
		public kranik()
		{
			InitializeComponent();
		}
		public async void Play_Animation()
		{
			kran.Text = "|\\{/|";
			await Task.Delay(500);

			kran.Text = "|\\}/|";
			await Task.Delay(500);

			kran.Text = "|\\{/|";
			await Task.Delay(500);

			kran.Text = "|\\}/|";

			await Task.Delay(500);
			kran.Text = "|\\ /|";
		}
	}
}
