using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.classes
{
    class Board
    {
		
		// Tic Tac Toe Gameboard states
		
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        ///  Display board this game
        /// </summary>
        public void DisplayBoard()
		{
			// print all board elements
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
