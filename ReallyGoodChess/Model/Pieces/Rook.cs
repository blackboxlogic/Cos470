using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    class Rook : Piece
    {

        private static Vector[] DirectionsAllWays = new Vector[] {
            new Vector(0, 1),
            new Vector(0, 2),
            new Vector(0, 3),
            new Vector(0, 4),
            new Vector(0, 5),
            new Vector(0, 6),
            new Vector(0, 7)
        };



        private static Vector[] DirectionsForward = new Vector[] {
            new Vector(0, 1),
            new Vector(0, 2),
            new Vector(0, 3),
            new Vector(0, 4),
            new Vector(0, 5),
            new Vector(0, 6),
            new Vector(0, 7)
        };

        private static Vector[] DirectionsBack = new Vector[] {
            new Vector(0, -1),
            new Vector(0, -2),
            new Vector(0, -3),
            new Vector(0, -4),
            new Vector(0, -5),
            new Vector(0, -6),
            new Vector(0, -7)
        };

        private static Vector[] DirectionsRight = new Vector[]
            {
            new Vector(1, 0),
            new Vector(2, 0),
            new Vector(3, 0),
            new Vector(4, 0),
            new Vector(5, 0),
            new Vector(6, 0),
            new Vector(7, 0)
            };

        private static Vector[] DirectionsLeft = new Vector[]
        {
            new Vector(-1, 0),
            new Vector(-2, 0),
            new Vector(-3, 0),
            new Vector(-4, 0),
            new Vector(-5, 0),
            new Vector(-6, 0),
            new Vector(-7, 0)
        };

        //I think this is done but check my work.****************
        public override Piece[][,] GetMoves(Piece[,] board)
        {
            //New list to store potential moves
            var boards = new List<Piece[,]>();

            foreach (var directions in new [] { DirectionsForward, DirectionsBack, DirectionsLeft, DirectionsRight })
            {
                foreach (var direction in directions)
                {
                    var landed = Location + direction;
                    if (IsOnBoard(landed))
                    {
                        if (board[landed.X, landed.Y] == null)
                        {
                            TryMove<Rook>(board, landed, out var newBoard);
                        }
                        //if there's a piece to capture add the move then break
                        if (board[landed.X, landed.Y].Color != Color)
                        {
                            TryMove<Rook>(board, landed, out var newBoard);
                            break;
                        }
                        //if we get here it there is a piece of the same color so no more moves get added
                        break;
                    }
                    break;
                }
            }
            return boards.ToArray();

        }
    }
}
