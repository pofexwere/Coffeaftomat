using System;
using System.Collections.Generic;
using System.Text;

namespace КофеАвтомат
{
	internal class Coffe
	{
		public string Type;
		public int Sugar;
		public int ChokoSirp;
		public int VanilSirp;
		public int KaramSirp;
		public Coffe(string tape, int sugar, int chokoSirp, int vanilSirp, int karamSirp)
		{
			Type = tape;
			Sugar = sugar;
			ChokoSirp = chokoSirp;
			VanilSirp = vanilSirp;
			KaramSirp = karamSirp;
		}
		public Coffe() {
			Type = "стакан";
			Sugar = 0;
			ChokoSirp = 0;
			VanilSirp = 0;
			KaramSirp = 0;
		}
		public string info()
		{
			string info = $"Тип: {Type}\r\n" +
				$"сахар: {Sugar} \r\n" +
				$"шоколадный сироп: {ChokoSirp} \r\n" +
				$"ванильный сироп: {VanilSirp}  \r\n" +
				$"карамеьный сироп: {KaramSirp}  \r\n";
			return info;
		}
	}
	internal class CofeMashine
	{
		





	}
}
