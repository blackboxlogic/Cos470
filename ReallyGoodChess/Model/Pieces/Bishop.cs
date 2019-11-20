using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Pieces
{
    public class Bishop : Piece
    {
        private Vector ForwardRight => new Vector(1, 1);
        private Vector ForwardLeft => new Vector(-1, 1);
        private Vector BackRight => new Vector(1, -1);
        private Vector BackLeft => new Vector(-1, -1);

        protected override char Char => '♗';

        public override Piece[][,] GetMoves(Piece[,] board)
        {
            var boards = new List<Piece[,]>();

			Action<Vector> continueDirection = d =>
			{
				bool captured = false;
				while (IsOnBoard(d) && board[d.X, d.Y]?.Color != Color && !captured)
				{
					captured = board[d.X, d.Y] != null;
					if (TryMove<Bishop>(board, d, out var newBoard))
					{
						boards.Add(newBoard);
					}
					d += ForwardRight;
				}
			};

            var moveForwardRight = Location + ForwardRight;
			continueDirection(moveForwardRight);

			var moveForwardLeft = Location + ForwardLeft;
			continueDirection(moveForwardLeft);

			var moveBackRight = Location + BackRight;
			continueDirection(moveBackRight);

			var moveBackLeft = Location + BackLeft;
			continueDirection(moveBackLeft);

			return boards.ToArray(); ;
        }
    }
}