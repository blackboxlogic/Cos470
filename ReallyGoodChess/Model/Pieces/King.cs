using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Pieces
{
    public class King : Piece
    {
		protected override char Char => '♔';

		private static Vector[] Directions = new Vector[] { //all 8 directions from current location
            new Vector(-1, -1), // bottom left diag
            new Vector(0, -1), // directly below
            new Vector(1, -1), // bottom right diag
            new Vector(-1, 0), // directly left
            new Vector(1, 0),  //directly right
            new Vector(-1, 1),  //top left diag
            new Vector(0, 1),  //directly above
            new Vector(1, 1)   //top right diag
        };

        public override Piece[][,] GetMoves(Piece[,] board)
        {
            var boards = new List<Piece[,]>();

            foreach (Vector v in Directions)  //valid moves: 1 square vertical,horizontal, or diagonal
            {
                var landed = Location + v;
                if (IsOnBoard(landed)
                    && board[landed.X, landed.Y]?.Color != Color)
                {
                    if (CloneBoardAndCheckCheck<King>(board, landed, out var newBoard))
                    {
                        boards.Add(newBoard);
                    }
                }
            }

            //castling
            if (!HasMoved && !AmInCheck(board)) //king hasn't moved nor is he in check (cant castle out of check)
            {
                Vector leftRook = new Vector(0, Location.Y);
                if (board[leftRook.X, leftRook.Y]?.HasMoved == false) //left rook on King's team has not moved
                {
                    if (NothingInBetweenLeft(board))
                    {

                    }
                }

                Vector rightRook = new Vector(7, Location.Y);
                if (board[rightRook.X, rightRook.Y]?.HasMoved == false)//right rook on King's team has not moved
                {
                    if (NothingInBetweenRight(board))
                    {

                    }
                }


            }

            return boards.ToArray();
        }


        private bool NothingInBetweenLeft(Piece[,] board)
        {
            for (int i = 1; i < Location.X; i++)
            {
                if (board[i, Location.Y] != null)
                {
                    return false;
                }
            }
            return true;
        }


        private bool NothingInBetweenRight(Piece[,] board)
        {
            for (int i = Location.X + 1; i < 7; i++)
            {
                if (board[i, Location.Y] != null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

    
