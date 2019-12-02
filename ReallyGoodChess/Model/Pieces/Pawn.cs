using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Pieces
{
	public class Pawn : Piece // Aka nobbly one down front
	{
		protected override char Char => '♙';

		private Vector Front => new Vector(Color == Color.White ? 1 :-1, 0);

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
				if(CloneBoardAndCheckCheck<Pawn>(board, forwardTwo, out var newBoard))
				{
					boards.Add(newBoard);
				}
			}
			// Can move one forward (but not capture)
			if (IsOnBoard(forward) && board[forward.X, forward.Y] == null)
			{
				
				if (!IsOnBoard(forwardTwo))// if at the end (promote)
				{
					Piece[,] newPromotedBoard;
					if (CloneBoardAndCheckCheck<Knight>(board, forward, out newPromotedBoard))
					{
						boards.Add(newPromotedBoard);
					}
					if (CloneBoardAndCheckCheck<Rook>(board, forward, out newPromotedBoard))
					{
						boards.Add(newPromotedBoard);
					}
					if (CloneBoardAndCheckCheck<King>(board, forward, out newPromotedBoard))
					{
						boards.Add(newPromotedBoard);
					}
					if (CloneBoardAndCheckCheck<Bishop>(board, forward, out newPromotedBoard))
					{
						boards.Add(newPromotedBoard);
					}
				}
				if (CloneBoardAndCheckCheck<Pawn>(board, forward, out var newBoard))
				{
					boards.Add(newBoard);
				}
			}
			// can capture diagonally one space left or right
			var forwardLeft = Location + Front + new Vector(0, -1);
			if (IsOnBoard(forwardLeft)
				&& board[forwardLeft.X, forwardLeft.Y] != null
				&& board[forwardLeft.X, forwardLeft.Y].Color != Color)
			{
				if (CloneBoardAndCheckCheck<Pawn>(board, forwardLeft, out var newBoard))
				{
					boards.Add(newBoard);
				}
			}
			var forwardRight = Location + Front + new Vector(0, 1);
			if (IsOnBoard(forwardRight)
				&& board[forwardRight.X, forwardRight.Y] != null
				&& board[forwardRight.X, forwardRight.Y].Color != Color)
			{
				if (CloneBoardAndCheckCheck<Pawn>(board, forwardRight, out var newBoard))
				{
					boards.Add(newBoard);
				}
			}

			return boards.ToArray();
		}
	}
}
