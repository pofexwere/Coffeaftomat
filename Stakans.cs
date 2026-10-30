using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class Stakans : UserControl
	{
		public Stakans()
		{
			InitializeComponent();
			lblStakan.Click += (s, e) => this.OnClick(e);
		}
	}
}
