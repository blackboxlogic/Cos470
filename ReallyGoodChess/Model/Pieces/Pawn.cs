using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Pieces
{
	public class Pawn : Piece // Aka nobbly one down front
	{
		private Vector Front => new Vector(0, Color == Color.White ? 1 :-1);

		public override Piece[][,] GetMoves(Piece[,] board)
		{
			var boards = new List<Piece[,]>();
			// First move, can go two (bot not capture, nor jump)
			var forward = Location + Front;
			var forwardTwo = forward + Front;
			if (!HasMoved
				&& board[forward.X, forward.Y] == null
				&& board[forwardTwo.X, forwardTwo.Y] == null)
			{
				// Can jump two!
			}

			// can capture diagonally one space left or right
			// Can move one forward (but not capture)
			// "Promotion", If you get to the end, turn into any peice, except kings or pawns
			// king can't be in check after move
			return boards.ToArray();
		}
	}
}
