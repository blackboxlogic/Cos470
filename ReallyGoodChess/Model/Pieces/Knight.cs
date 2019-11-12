using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Pieces
{
	public class Knight : Piece // Aka Horsey, can jump, captures where it lands
	{
		private static Vector[] Directions = new Vector[] {
			new Vector(-2, -1),
			new Vector(-2, 1),
			new Vector(2, -1),
			new Vector(2, 1),
			new Vector(-1, 2),
			new Vector(-1, -2),
			new Vector(1, 2),
			new Vector(1, -2)
		};

		public override Piece[][,] GetMoves(Piece[,] board)
		{
			// make an array size 8
			var boards = new List<Piece[,]>();

			// add things to it
			foreach (var direction in Directions)
			{
				var landed = Location + direction;

				if (IsOnBoard(landed)
					&& board[landed.X, landed.Y]?.Color != Color) {
					var newBoard = Clone(board);
					//remove from where it was
					newBoard[Location.X, Location.Y] = null;
					//put in new place
					newBoard[landed.X, landed.Y] = new Knight() { Color = Color, HasMoved = true, Location = landed } ;
					if (!AmInCheck(newBoard))
					{
						boards.Add(newBoard);
					}
				}
			}

			return boards.ToArray();
		}
	}
}
