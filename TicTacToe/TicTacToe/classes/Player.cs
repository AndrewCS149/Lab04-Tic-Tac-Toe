using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.classes
{
    class Player
    {
		// name of player
		public string Name { get; set; }
		// P1 is X and P2 will be O
		public string Marker { get; set; }

		// Flag to determine if it is the user's turn
		public bool IsTurn { get; set; }

		/// Get position of board
		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;

		}

		/// <summary>	  
		///Position for numbers 
		/// </summary>
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); // Top Left
				case 2: return new Position(0, 1); // Top Middle
				case 3: return new Position(0, 2); // Top Right
				case 4: return new Position(1, 0); // Middle Left
				case 5: return new Position(1, 1); // Middle Middle
				case 6: return new Position(1, 2); // Middle Right
				case 7: return new Position(2, 0); // Bottom Left
				case 8: return new Position(2, 1); // Bottom Middle 
				case 9: return new Position(2, 2); // Bottom Right

				default: return null;
			}
		}

		/// <summary>
		/// Take turn of players
		/// </summary>
		public void TakeTurn(Board board)
		{
            IsTurn = true;
            Console.WriteLine($"{Name} it is your turn");
            Position position = GetPosition(board);

			// if player chooses position that has already been chosen
            while (!Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
            {
				Console.WriteLine("This space is already occupied");
                position = GetPosition(board);
            }

			board.GameBoard[position.Row, position.Column] = Marker;
		}
	}
}
