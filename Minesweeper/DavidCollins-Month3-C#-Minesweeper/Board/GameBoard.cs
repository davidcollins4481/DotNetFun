using System;

namespace DavidCollinsMonth3CMinesweeper.Board
{
	public class GameBoard
	{
		SquareFactory factory = new SquareFactory();
		Square[,] squareObjs;
        private int rows;
        private int columns;

		public GameBoard (int rows, int columns, char[] squares)
		{
			// initialize this
			squareObjs = new Square[rows,columns];

            this.Rows = rows;
            this.Columns = columns;

			//char[,] board = new char[rows,columns];
			int currentSquare = 0;
			for (int row = 0; row < rows; row++) {
				for (int column = 0; column < columns; column++) {
					//board[row,column] = squares[currentSquare++];
					squareObjs[row,column] = 
						factory.makeSquare(squares[currentSquare] == '*' ? 1 : 0);
				}
			}
		}

        public int Rows {
            get { return rows; }
            set { this.rows = value; }
        }

        public int Columns {
            get { return this.columns; }
            set { this.columns = value; }
        }
	}
}

