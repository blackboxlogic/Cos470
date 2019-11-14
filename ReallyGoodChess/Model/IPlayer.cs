using System;

namespace Model
{
	public interface IPlayer
	{
		string Name { get; }
		Color Color { get; }

		int ChooseMove(Piece[][,] options);
	}
}
