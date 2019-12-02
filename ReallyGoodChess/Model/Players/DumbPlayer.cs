using System;

namespace Model
{
	public class DumbPlayer : Player
	{
		private static readonly Random R = new Random();

		protected override double ScoreMove(Piece[,] options)
		{
			return R.Next(-1, 1);
		}
	}
}
