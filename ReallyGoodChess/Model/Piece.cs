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
	}
}
