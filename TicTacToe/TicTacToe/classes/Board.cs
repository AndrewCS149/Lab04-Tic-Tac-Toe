using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{

			//TODO: Output the board to the console

			for(int i = 0; i < 3; i++)
            {
				for(int k = 0; k < 3; k++)
                {
                    Console.Write(GameBoard[i, k]);
                }
                Console.WriteLine(); 
            }
		}
	}
}
