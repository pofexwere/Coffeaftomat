using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class CoffeName : UserControl
	{
		public CoffeName()
		{
			InitializeComponent();
			lbldisplay.Click += (s, e) => this.OnClick(e);

		}
		public bool selected = false;
		/// <summary>
		/// Тип кофе (Эспрессо, Американо, Латте и т.д.).
		/// Это то, что увидит главная форма в событии CoffeeSelected.
		/// </summary>
		[Category("Coffee")]
		[Description("Тип кофе, который будет выбран при клике")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string CoffeeType {
			get => lbldisplay.Text;
			set => lbldisplay.Text = value;
		} 
		public  async void Selected()
		{
			string t = lbldisplay.Text;
			lbldisplay.Text += "💡" ;
			await Task.Delay(2000);
			lbldisplay.Text = t;
		}
	}
}

