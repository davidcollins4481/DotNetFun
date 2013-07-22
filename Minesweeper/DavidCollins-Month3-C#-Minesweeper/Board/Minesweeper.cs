using System;
using System.IO;

namespace DavidCollinsMonth3CMinesweeper.Board
{

	public class Minesweeper
	{
		GameBoard board;

		/* Maybe create a square factory here? */
		public Minesweeper (string filename)
		{
			this.createBoard(filename);
		}

    	private void createBoard (string filename)
		{
			//return new GameBoard();
			string[] lines = File.ReadAllLines (filename);
			// only read first line now
			string[] parts = lines[0].Split(';');
			string[] dimensions = parts[0].Split (',');

			char[] pieces = parts[1].ToCharArray();
			board = new GameBoard(int.Parse(dimensions[0]), int.Parse(dimensions[1]), pieces);
		}

        public void solve ()
        {
            for (int row = 0; row < this.board.Rows; row++) {
                for (int column = 0; column < this.board.Columns; columns++) {
                    
                }
            }
        }
	}
}