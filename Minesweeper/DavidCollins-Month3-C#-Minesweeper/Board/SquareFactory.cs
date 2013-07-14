using System;

namespace DavidCollinsMonth3CMinesweeper.Board
{
	public class SquareFactory
	{
		// enum type?
		// 0 = empty, 1 = Mine
		public Square makeSquare(int squareType) {
			if (squareType == 0) {
				return new Empty();
			} else {
				return new Mine();
			}
		}
	}
}

