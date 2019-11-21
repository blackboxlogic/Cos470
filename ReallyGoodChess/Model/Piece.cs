using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
	public abstract class Piece
	{
		public bool HasMoved;
		public Color Color;
		public Vector Location;

		public abstract Piece[][,] GetMoves(Piece[,] board);
		private const char ToBlackChar = (char)('♚' - '♔');
		protected abstract char Char { get; } // ♔♕♖♗♘♙ KQRBNP

		public char AsColoredChar()
		{
			return (char)(Char + (int)Color * ToBlackChar);
		}

		protected bool IsOnBoard(Vector landed)
		{
			return landed.X >= 0 && landed.X <= 7 && landed.Y >= 0 && landed.Y <= 7;
		}

		protected Piece[,] Clone(Piece[,] board)
		{
			return (Piece[,])board.Clone(); // Shallow Copy
		}

		protected bool AmInCheck(Piece[,] board)
		{
			return false; // fix when we have kings
		}

		protected bool CloneBoardAndCheckCheck<T>(Piece[,] board, Vector landingSpot, out Piece[,] result)
			where T : Piece, new()
		{
			var newBoard = Clone(board);
			//remove from where it was
			newBoard[Location.X, Location.Y] = null;
			//put in new place
			newBoard[landingSpot.X, landingSpot.Y] =
				new T() { Color = Color, HasMoved = true, Location = landingSpot };
			if (!AmInCheck(newBoard))
			{
				result = newBoard;
				return true;
			}

			result = null;
			return false;
		}
	}
}
