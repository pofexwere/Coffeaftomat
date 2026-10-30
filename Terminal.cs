using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class Terminal : UserControl
	{
		public Terminal()
		{
			InitializeComponent();
		}
		public bool payd { get; private set; } = false;
		private bool firstTap = true;
		public void Reset() { payd = false; }
		private async void label2_Click(object sender, EventArgs e)
		{
			if (!payd)
			{
				if (firstTap)
				{
					displey.Text = "\r100 руб.";
					firstTap = false;
				}
				else
				{
					displey.Text = "\rОплачено";
					await Task.Delay(500);
					displey.Text = "Теперь\r\nвыберите\r\nнапиток";
					await Task.Delay(500);
					displey.Text = "Нажмите\r\nдля\r\nоплаты";
					payd = true;
				}
			}
			else
			{
				displey.Text = "Выберите\r\nнапиток";
				await Task.Delay(1500);
				displey.Text = "Нажмите\r\nдля\r\nоплаты";
			}
		}
	}
}
