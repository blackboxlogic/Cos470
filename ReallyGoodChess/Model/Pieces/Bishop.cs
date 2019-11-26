using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Pieces
{
    public class Bishop : Piece
    {
        private Vector[] directions = { new Vector(1, 1),
            new Vector(-1, 1),
            new Vector(1, -1),
            new Vector(-1, -1)
        };
 

        protected override char Char => '♗';

        public override Piece[][,] GetMoves(Piece[,] board)
        {
            var boards = new List<Piece[,]>();

			Action<Vector> continueDirection = d =>
			{
				bool captured = false;
                var looking = Location + d;
				while (IsOnBoard(looking) && board[looking.X, looking.Y]?.Color != Color && !captured)
				{
					captured = board[looking.X, looking.Y] != null;
					if (CloneBoardAndCheckCheck<Bishop>(board, looking, out var newBoard))
					{
						boards.Add(newBoard);
					}
                    looking += d;
				}
			};

            foreach(Vector d in directions)
            {
                continueDirection(d);
            }

			return boards.ToArray(); 
        }
    }
}