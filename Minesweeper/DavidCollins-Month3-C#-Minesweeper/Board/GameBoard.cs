using System;

namespace DavidCollinsMonth3CMinesweeper.Board
{
	public class GameBoard
	{
		SquareFactory factory = new SquareFactory();
		Square[,] squares;

		public GameBoard (int rows, int columns, char[] squares)
		{
			// initialize this
			squares = new Square[rows,columns];

			//char[,] board = new char[rows,columns];
			int currentSquare = 0;
			for (int row = 0; row < rows; row++) {
				for (int column = 0; column < columns; column++) {
					//board[row,column] = squares[currentSquare++];
					this.addSquare(
						factory.makeSquare(squares[currentSquare] == '*' ? 1 : 0)
					);
				}
			}
		}

		private void addSquare(Square s) {
			//hmm..what to do here?
		}
	}
}

