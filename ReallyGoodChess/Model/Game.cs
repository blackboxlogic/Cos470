using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
	public class Game
	{
		public IPlayer Players1;
		public IPlayer Players2;
		public Stack<Piece[,]> History; // BoardStack
		public Color Turn;

		public Piece[][,] GetMoves()
		{
			List<Piece[,]> options = new List<Piece[,]>();
			var currentBoard = History.Peek();

			foreach (var piece in currentBoard)
			{
				if (piece?.Color == Turn)
				{
					options.AddRange(piece.GetMoves(currentBoard));
				}
			}

			return options.ToArray();
		}

		public void PlayMove(Piece[,] move)
		{
			History.Push(move);
			Turn = 1 - Turn;
		}
	}
}
