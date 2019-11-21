using Model;
using Model.Pieces;

using System;
using System.Text;

namespace ChessConsoleApp
{
// Queen doesn't exit
// King doesn't ever get "checked"
// King can't castle
// Rook doesn't have any moves ever
// Bishup can jump opponients
// some other front end
// Make an "inteligentll" player

    class ChessConsoleApp
    {
        public Game SetUp()
        {
			var board = new Piece[8, 8];
			board[0, 1] = new Knight() { Color = Color.White, Location = new Vector(0, 1) };
            board[0, 6] = new Knight() { Color = Color.White, Location = new Vector(0, 6) };
            board[7, 1] = new Knight() { Color = Color.Black, Location = new Vector(7, 1) };
			board[7, 6] = new Knight() { Color = Color.Black, Location = new Vector(7, 6) };

            board[0, 2] = new Bishop() {Color = Color.White, Location = new Vector(0, 2) };
            board[0, 5] = new Bishop() { Color = Color.White, Location = new Vector(0, 5) };
            board[7, 2] = new Bishop() { Color = Color.Black, Location = new Vector(7, 2) };
			board[7, 5] = new Bishop() { Color = Color.Black, Location = new Vector(7, 5) };

            board[0, 0] = new Rook() { Color = Color.White, Location = new Vector(0, 0) };
            board[0, 7] = new Rook() { Color = Color.White, Location = new Vector(0, 7) };
            board[7, 0] = new Rook() { Color = Color.Black, Location = new Vector(7, 0) };
			board[7, 7] = new Rook() { Color = Color.Black, Location = new Vector(7, 7) };


			board[0, 4] = new King() { Color = Color.White, Location = new Vector(0, 4) };
			//board[0, 3] = new Queen() { Color = Color.White, Location = new Vector(0, 3) };
			board[7, 4] = new King() { Color = Color.Black, Location = new Vector(7, 4) };
			//board[7, 3] = new Queen() { Color = Color.black, Location = new Vector(7, 3) };



			for (int i = 0; i < 8; i++)
            {
				board[1, i] = new Pawn() { Color = Color.White, Location = new Vector(1, i) };
				board[6, i] = new Pawn() { Color = Color.Black, Location = new Vector(6, i) };
            }

			Game Game = new Game() { History = new System.Collections.Generic.Stack<Piece[,]>() };
			Game.History.Push(board);

			return Game;
        }

        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.Unicode;
            ChessConsoleApp app = new ChessConsoleApp();
			Game game = app.SetUp();

			Console.WriteLine("Current Board:");
			game.History.Peek().ToConsole();

			Console.WriteLine(game.Turn + " Options:");
			var moves = game.GetMoves();
			foreach (var move in moves)
			{
				move.ToConsole();
				Console.WriteLine("================");
			}

			Console.ReadKey(true);
        }
    }
}
