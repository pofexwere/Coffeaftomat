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
	public partial class Trash : UserControl
	{
		public Trash()
		{
			InitializeComponent();
			lblTrash.Click += (s, e) => this.OnClick(e);
		}
	}
}
