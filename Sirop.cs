using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class Sirop : UserControl
	{
		public Sirop()
		{
			InitializeComponent();
			lblName.Click += (s, e) => this.OnClick(e);
		}
		public int count { get; private set; } = 0;
		/// <summary>
		/// Тип кофе (Эспрессо, Американо, Латте и т.д.).
		/// Это то, что увидит главная форма в событии CoffeeSelected.
		/// </summary>
		[Category("Coffee")]
		[Description("Тип кофе, который будет выбран при клике")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string CoffeeType
		{
			get => lblName.Text;
			set => lblName.Text = value;
		}
		public void add()
		{
			count++;
		}
		public void reset()
		{
			count = 0;
		}
	}
}
