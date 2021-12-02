using System;
using Xunit;
using Padel;

namespace PadelTest
{
    public class TestGame
    {
        [Fact]
        public void Players_Init_NotNull()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Game game = new Game(player1, player2);

            Assert.NotNull(game);
            Assert.NotNull(game.Player1);
            Assert.NotNull(game.Player2);
        }

        [Fact]
        public void Game_Init_NotNull()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Game game = new Game(player1, player2);

            Assert.NotNull(game);
        }

        [Fact]
        public void Winner_Init_IsNull()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Game game = new Game(player1, player2);

            Assert.Null(game.Winner);
        }

        [Fact]
        public void Score_Init_IsZero()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Game game = new Game(player1, player2);

            Assert.Equal(0, game.Score(player1)._Score);
        }

        [Fact]
        public void ScoreAndPoint_AddAPoint_ScoreIsOne()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Game game = new Game(player1, player2);

            game.Point(player1);

            Assert.Equal(1, game.Score(player1)._Score);
        }

        [Fact]
        public void Game_RunAGame_Player1Wins()
        {
            //Exempel på användning:
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.Point(player1); // 15 - 0
            game.Point(player1); // 30 - 0
            game.Point(player2); // 30 - 15
            game.Point(player1); // 40 - 15
            game.Point(player1); // Player 1 vinner Gamet

            var result = game.ScoreString(); // Ska vara Player 1 wins Game
            string expected = "Player 1 wins";

            Assert.Equal(expected, result);
            Assert.Equal("Player 1", game.Winner.Name);
        }

        [Fact]
        public void Game_RunAGame_Player2Wins()
        {
            //Exempel på användning:
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.Point(player2); // 0 - 15
            game.Point(player2); // 0 - 30
            game.Point(player1); // 15 - 30
            game.Point(player2); // 15 - 40
            game.Point(player2); // Player 2 vinner Gamet

            var result = game.ScoreString(); // Ska vara Player 2 wins Game
            string expected = "Player 2 wins";

            Assert.Equal(expected, result);
            Assert.Equal("Player 2", game.Winner.Name);
        }

        [Fact]
        public void Game_RunAGame_GameNotFinished()
        {
            //Exempel på användning:
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.Point(player2); // 0 - 15

            var result = game.ScoreString(); // Ska vara Game is not over yet
            string expected = "Game is not over yet";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Game_BothPlayersAt40_Player1Wins()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.Point(player1); // 15 - 0
            game.Point(player1); // 30 - 0
            game.Point(player2); // 30 - 15
            game.Point(player1); // 40 - 15
            game.Point(player2); // 40 - 30
            game.Point(player2); // 40 - 40
            game.Point(player1); // Fördel Player 1
            game.Point(player1); // Player 1 Wins

            var result = game.ScoreString(); // Ska vara Player 1 wins Game
            string expected = "Player 1 wins";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Game_BothPlayersAt40_Player2Wins()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.Point(player1); // 15 - 0
            game.Point(player1); // 30 - 0
            game.Point(player2); // 30 - 15
            game.Point(player1); // 40 - 15
            game.Point(player2); // 40 - 30
            game.Point(player2); // 40 - 40
            game.Point(player2); // Fördel Player 2
            game.Point(player2); // Player 2 Wins

            var result = game.ScoreString(); // Ska vara Player 2 wins Game
            string expected = "Player 2 wins";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Game_BothPlayersAt40_GameNotOverYet()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.Point(player1); // 15 - 0
            game.Point(player1); // 30 - 0
            game.Point(player2); // 30 - 15
            game.Point(player1); // 40 - 15
            game.Point(player2); // 40 - 30
            game.Point(player2); // 40 - 40
            game.Point(player2); // Fördel Player 2

            var result = game.ScoreString(); // Ska vara Game is not over yet
            string expected = "Game is not over yet";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Game_GameJustStarted_GameNotOverYet()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);

            var result = game.ScoreString(); // Ska vara Game is not over yet
            string expected = "Game is not over yet";

            Assert.Equal(expected, result);
        }
    }
}
