using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
	public class DumbPlayer : IPlayer
	{
		public string Name { get; set; }
		public Color Color { get; set; }

		public int ChooseMove(Piece[][,] options)
		{
			Random r = new Random();
			return r.Next(options.Length);
		}
	}
}
