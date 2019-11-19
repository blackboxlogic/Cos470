using Model.Pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
	public static class Render
	{
		public static string AsAscii(this Piece[,] board)
		{
			StringBuilder words = new StringBuilder();

			for (int x = 0; x < 8; x++)
			{
				for (int y = 0; y < 8; y++)
				{
					var piece = board[x, y];
					if(piece != null)
						words.Append(piece.AsColoredChar());
				}
				words.Append(Environment.NewLine);
			}

			return words.ToString();
		}
	}
}
