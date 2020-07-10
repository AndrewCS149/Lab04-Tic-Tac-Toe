using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using static TicTacToe.Program;
using TicTacToe.classes;

namespace TicTacToeTest
{
    public class UnitTest1
    {

        // Test for winner with X positions
        [Fact]
        public void TestForWinnerX()
        {
            // arrange
            Player p1 = new Player();
            Player p2 = new Player();

            Game game = new Game(p1, p2);
            game.Board.GameBoard[0, 0] = "X";
            game.Board.GameBoard[0, 1] = "X";
            game.Board.GameBoard[0, 2] = "X";

            // act
            bool result = game.CheckForWinner(game.Board);

            // assert
            Assert.True(result);
        }

        // Test for winner with O positions
        [Fact]
        public void TestForWinnerO()
        {
            // arrange
            Player p1 = new Player();
            Player p2 = new Player();

            Game game = new Game(p1, p2);
            game.Board.GameBoard[0, 0] = "O";
            game.Board.GameBoard[0, 1] = "O";
            game.Board.GameBoard[0, 2] = "O";

            // act
            bool result = game.CheckForWinner(game.Board);

            // assert
            Assert.True(result);
        }

        // Test that the player switches between turns
        [Fact]
        public void TestForPlayerSwitch()
        {
            // arrange
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            p1.IsTurn = true;

            // act
            game.SwitchPlayer();
            bool result = p1.IsTurn; 

            // assert
            Assert.False(result);
        }

        // Test to verify players position is the same as the correct idx of the array
        [Fact]
        public void VerifyPlayerPosition()
        {
            // arrange
            Player p1 = new Player();
            Player p2 = new Player();
            p1.Marker = "X";
            Game game = new Game(p1, p2);
            game.Board.GameBoard[0, 0] = "X";

            // act
            string boardPosition = game.Board.GameBoard[0, 0];

            // assert
            Assert.Equal(boardPosition, p1.Marker);
        }

        // Test to verify that player marker equals X
        [Fact]
        public void VerifyPlayerMarkerX()
        {
            // arrange
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            // act
            p1.Marker = "X";

            // assert
            Assert.Equal("X", p1.Marker);
        }

        // Test to verify that player marker equals O
        [Fact]
        public void VerifyPlayerMarkerO()
        {
            // arrange
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            // act
            p1.Marker = "O";

            // assert
            Assert.Equal("O", p1.Marker);
        }
    }
}
