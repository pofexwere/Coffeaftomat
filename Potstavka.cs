using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class Potstavka : UserControl
	{
		public Potstavka()
		{
			InitializeComponent();
			Place.Click += (s, e) => this.OnClick(e);
		}
		public bool hat { get; private set; } = false;
		public bool InPlace { get; private set; } = false;
		public bool IsFull { get; private set; } = false;
		public int pos { get; private set; } = 0;
		public string InStakan { get; private set; } = "nothing";
		public async void addsirp()
		{
			if (hat)
			{
				Place.Text = "💧";
				await Task.Delay(500);

				Place.Text = "🥤";
			}
			else
			{
				Place.Text = "💧";
				await Task.Delay(500);

				Place.Text = "\U0001f95b";
			}
		}
		public void addhat()
		{
			if (InPlace && IsFull && !hat)
			{
				hat = true;
				Place.Text = "🥤";
			}
		}
		public void remove()
		{
			Place.Text = "";
			hat = false;
			InPlace = false;
			IsFull = false;
			pos = 0;

		}
		public void addStakan()
		{
			Place.Text = "🥛";
			InPlace = true;
			pos = 1;
		}

		public void take()
		{
			InPlace = false;
			IsFull = false;
			pos = 2;
		}
		public void feal(string coffe)
		{
			if (InPlace)
			{
				if (!IsFull)
				{
					IsFull = true;
					InStakan = coffe;
				}
			}

		}
	}
}
