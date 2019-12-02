using System;

namespace Model
{
	public abstract class Player
	{
		public string Name;
		public Color Color;

		public int ChooseMove(Piece[][,] options)
		{
			int bestIndex = 0;
			double bestScore = ScoreMove(options[0]);

			for (int i = 1; i < options.Length; i++)
			{
				double score = ScoreMove(options[i]);
				if (score > bestScore)
				{
					bestIndex = i;
					bestScore = score;
				}
			}

			return bestIndex;
		}

		abstract protected double ScoreMove(Piece[,] options);
	}
}
