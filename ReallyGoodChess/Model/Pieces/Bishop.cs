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

            var moveForwardRight = Location + ForwardRight;
            while (IsOnBoard(moveForwardRight) && board[moveForwardRight.X, moveForwardRight.Y]?.Color != Color)
            {
                if (TryMove<Bishop>(board, moveForwardRight, out var newBoard))
                {
                    boards.Add(newBoard);
                }
                moveForwardRight += ForwardRight;
            }

            var moveForwardLeft = Location + ForwardLeft;
            while (IsOnBoard(moveForwardLeft) && board[moveForwardLeft.X, moveForwardLeft.Y]?.Color != Color)
            {
                if (TryMove<Bishop>(board, moveForwardLeft, out var newBoard))
                {
                    boards.Add(newBoard);
                }
                moveForwardLeft += ForwardLeft;
            }

            var moveBackRight = Location + BackRight;
            while (IsOnBoard(moveBackRight) && board[moveBackRight.X, moveBackRight.Y]?.Color != Color)
            {
                if (TryMove<Bishop>(board, moveBackRight, out var newBoard))
                {
                    boards.Add(newBoard);
                }
                moveBackRight += BackRight;
            }

            var moveBackLeft = Location + BackLeft;
            while (IsOnBoard(moveBackLeft) && board[moveBackLeft.X, moveBackLeft.Y]?.Color != Color)
            {
                if (TryMove<Bishop>(board, moveBackLeft, out var newBoard))
                {
                    boards.Add(newBoard);
                }
                moveBackLeft += BackLeft;
            }

            return boards.ToArray(); ;
        }
    }
}