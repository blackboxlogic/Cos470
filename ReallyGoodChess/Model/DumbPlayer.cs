using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
	public class DumbPlayer : IPlayer
	{
		private static readonly Random R = new Random();

		public string Name { get; set; }
		public Color Color { get; set; }

		public int ChooseMove(Piece[][,] options)
		{
			return R.Next(options.Length);
		}
	}
}
