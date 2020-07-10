using System;
using TicTacToe.classes;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();            
        }

        static void StartGame()
        {
            Console.WriteLine("Welcome to the best game in the world, Tic Tac Toe!!!");
            Console.WriteLine("Please enter the name of Player 1");
            string player1name = Console.ReadLine();
            Console.WriteLine("Please enter the name of Player 2");
            string player2name = Console.ReadLine();
            Player player1 = new Player();
            player1.Name = player1name;
            player1.Marker = "X";
            Player player2 = new Player();
            player2.Name = player2name;
            player2.Marker = "O";
            Board board = new Board();

            Game game = new Game(player1, player2);
            Player newGame = game.Play();
            
            

            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }
    }
}