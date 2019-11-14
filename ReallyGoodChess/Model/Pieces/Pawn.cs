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
				if(TryMove<Pawn>(board, forwardTwo, out var newBoard))
				{
					boards.Add(newBoard);
				}
			}
			// Can move one forward (but not capture)
			if (board[forward.X, forward.Y] == null)
			{
				
				if (!IsOnBoard(forwardTwo))// if at the end (promote)
				{
					if (TryMove<Knight>(board, forward, out var newknight))
					{
						boards.Add(newknight);
					}
					// TODO, add the other peice types
				}
				if (TryMove<Pawn>(board, forward, out var newBoard))
				{
					boards.Add(newBoard);
				}
			}
			// can capture diagonally one space left or right
			var forwardLeft = Location + Front + new Vector(-1, 0);
			if (IsOnBoard(forwardLeft)
				&& board[forwardLeft.X, forwardLeft.Y] != null
				&& board[forwardLeft.X, forwardLeft.Y].Color != Color)
			{
				if (TryMove<Pawn>(board, forwardLeft, out var newBoard))
				{
					boards.Add(newBoard);
				}
			}
			var forwardRight = Location + Front + new Vector(1, 0);
			if (IsOnBoard(forwardRight)
				&& board[forwardRight.X, forwardRight.Y] != null
				&& board[forwardRight.X, forwardRight.Y].Color != Color)
			{
				if (TryMove<Pawn>(board, forwardRight, out var newBoard))
				{
					boards.Add(newBoard);
				}
			}

			return boards.ToArray();
		}
	}
}
