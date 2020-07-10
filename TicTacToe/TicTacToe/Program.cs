using System;
using TicTacToe.classes;

namespace TicTacToe
{
    class Program
    {/// <summary>
    /// this method calls the StartGame method, which houses all other methods called on program.cs
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            StartGame();            
        }
        /// <summary>
        /// this method starts the game and carries all subsequent method calls within it
        /// </summary>
        static void StartGame()
        {
            Console.WriteLine("Welcome to the best game in the world, Tic Tac Toe!!!");

            // get player names
            Console.WriteLine("Please enter the name of Player 1");
            string player1name = Console.ReadLine();
            Console.WriteLine("Please enter the name of Player 2");
            string player2name = Console.ReadLine();

            // initialize players
            Player player1 = new Player();
            player1.Name = player1name;
            player1.Marker = "X";
            Player player2 = new Player();
            player2.Name = player2name;
            player2.Marker = "O";

            // initialize game/board
            Board board = new Board();
            Game game = new Game(player1, player2);

            // play game
            Player newGame = game.Play();

            // determine winner or tie
            if (newGame == player1)
            {
                Console.WriteLine($"Congratulations {player1name}, you win the game!");
            }
            else if (newGame == player2)
            {
                Console.WriteLine($"Congratulations {player2name}, you win the game!");
            }
            else
            {
                Console.WriteLine("DRAW!!!!!");
            }
        }
    }
}