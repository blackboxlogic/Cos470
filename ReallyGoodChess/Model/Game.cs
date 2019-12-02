using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
	public class Game
	{
		public Stack<Piece[,]> History = new Stack<Piece[,]>();
		public Queue<DumbPlayer> Players = new Queue<DumbPlayer>();
		public Piece[,] CurrentBoard => History.Peek();
		public Piece[,] PreviousBoard()
		{
			if (History.Count < 2) return null;
			var current = History.Pop();
			var previous = History.Peek();
			History.Push(current);
			return previous;
		}

		public void TakeATurn()
		{
			var moves = GetMoves();
			var player = GetNextPlayer();
			int moveIndex = player.ChooseMove(moves);
			History.Push(moves[moveIndex]);
		}

		public Color Turn => Players.Peek().Color;
		private DumbPlayer GetNextPlayer()
		{
			var nextPlayer = Players.Dequeue();
			Players.Enqueue(nextPlayer);
			return nextPlayer;
		}

		private Piece[][,] GetMoves()
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

		// null means game isn't over.
		// 0 is black win, 1 is white win, .5 is draw
		public double? ChechWinner()
		{
			if (History.Count > 2000) return .5;

			foreach (Piece p in CurrentBoard)
			{
				if (p?.Color == Turn) return null;
			}

			return (int)Turn;
		}
	}
}
