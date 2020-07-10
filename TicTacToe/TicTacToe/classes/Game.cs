using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.classes
{
    public class Game
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Player Winner { get; set; }
        public Board Board { get; set; }

        /// <summary>
        /// Require 2 players and a board to start a game. 
        /// </summary>
        /// <param name="p1">Player 1</param>
        /// <param name="p2">Player 2</param>
        public Game(Player p1, Player p2)
        {
            PlayerOne = p1;
            PlayerTwo = p2;
            Board = new Board();
        }

        /// <summary>
        /// Activate the Play of the game
        /// </summary>
        /// <returns>Winner</returns>
        public Player Play()
        {
            PlayerOne.IsTurn = true;
            Winner = new Player();
            int turnCounter = 0;
            //the while loop is used because a for loop would cause both players to go 9 times, hence making 18 plays on a 9 position game
            while (true)
            {
                Board.DisplayBoard();
                NextPlayer().TakeTurn(Board);
                turnCounter++;
                //this logic checks to see if player1 won or if the maximum amount of turns were reached
                if (CheckForWinner(Board))
                {
                    Winner = PlayerOne;
                    break;
                }
                else if (turnCounter == 9)
                    break;

                //this clears the terminal out so that there isn't excess data clutter
                Console.Clear();
                SwitchPlayer();
                Board.DisplayBoard();

                NextPlayer().TakeTurn(Board);
                turnCounter++;
                //this checks if player2 won
                if (CheckForWinner(Board))
                {
                    Winner = PlayerTwo;
                    break;
                }
                SwitchPlayer();
                Console.Clear();
            }

            Board.DisplayBoard();
            return Winner;
        }

        /// <summary>
        /// Check if winner exists
        /// </summary>
        /// <param name="board">current state of the board</param>
        /// <returns>if winner exists</returns>
        public bool CheckForWinner(Board board)
        {
            int[][] winners = new int[][]
            {
                new[] {1,2,3},
                new[] {4,5,6},
                new[] {7,8,9},

                new[] {1,4,7},
                new[] {2,5,8},
                new[] {3,6,9},

                new[] {1,5,9},
                new[] {3,5,7}
            };

            // Given all the winning conditions, Determine the winning logic. 
            for (int i = 0; i < winners.Length; i++)
            {
                Position p1 = Player.PositionForNumber(winners[i][0]);
                Position p2 = Player.PositionForNumber(winners[i][1]);
                Position p3 = Player.PositionForNumber(winners[i][2]);

                string a = Board.GameBoard[p1.Row, p1.Column];
                string b = Board.GameBoard[p2.Row, p2.Column];
                string c = Board.GameBoard[p3.Row, p3.Column];

                //this logic checks to see if a win condition is found
                if (a == b && b == c)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Determine next player
        /// </summary>
        /// <returns>next player</returns>
        public Player NextPlayer()
        {
            return (PlayerOne.IsTurn) ? PlayerOne : PlayerTwo;
        }

        /// <summary>
        /// End one players turn and activate the other
        /// </summary>
        public void SwitchPlayer()
        {
            if (PlayerOne.IsTurn)
            {
                PlayerOne.IsTurn = false;
                PlayerTwo.IsTurn = true;
            }
            else
            {
                PlayerOne.IsTurn = true;
                PlayerTwo.IsTurn = false;
            }
        }
    }
}
