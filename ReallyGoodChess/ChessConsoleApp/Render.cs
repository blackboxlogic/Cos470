using Model;
using System;

namespace ChessConsoleApp
{
	public static class Render
	{
		public static void ToConsole(this Piece[,] board)
		{
			for (int x = 0; x < 8; x++)
			{
				for (int y = 0; y < 8; y++)
				{
					Console.BackgroundColor = (x + y) % 2 == 0 ? ConsoleColor.DarkGray : ConsoleColor.Gray;
					var piece = board[x, y];
					if (piece != null)
					{
						Console.ForegroundColor = piece.Color == Color.White ? ConsoleColor.White : ConsoleColor.Black;
						Console.Write(piece.AsColoredChar());
						Console.Write(" ");
					}
					else
					{
						Console.Write("  ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
