﻿using Padel;
using Xunit;

namespace PadelTest
{
    public class TestMatch
    {
        [Fact]
        public void Match_CreateMatch()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(5, player1, player2);
            Match match = new Match(mySet);

            Assert.NotNull(match);
            Assert.NotNull(match._Player1);
            Assert.NotNull(match._Player2);
        }

        [Fact]
        public void Match_Player1_WinMatch()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[0].Point(player1); // 15 - 0
            match[0].Point(player1); // 30 - 0
            match[0].Point(player2); // 30 - 15
            match[0].Point(player1); // 40 - 15
            match[0].Point(player1); // Player 1 vinner Gamet

            match[1].Point(player1); // 15 - 0
            match[1].Point(player1); // 30 - 0
            match[1].Point(player2); // 30 - 15
            match[1].Point(player1); // 40 - 15
            match[1].Point(player1); // Player 1 vinner Gamet

            match[2].Point(player1); // 15 - 0
            match[2].Point(player1); // 30 - 0
            match[2].Point(player2); // 30 - 15
            match[2].Point(player1); // 40 - 15
            match[2].Point(player1); // Player 1 vinner Gamet


            string expected = $"{player1.Name} wins 3-0";

            Assert.Equal(expected, match.MatchScore());
        }

        [Fact]
        public void Match_Game_Indexer()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);
            Game newGame = new Game(player1, player2);
            match[0] = newGame;
            Assert.NotNull(mySet[0]);
            Assert.Equal(newGame, match[0]);
        }
        [Fact]
        public void Match_Player2_WinsMatch()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[0].Point(player1); // 15 - 0
            match[0].Point(player2); // 15 - 15
            match[0].Point(player2); // 15 - 30
            match[0].Point(player2); // 15 - 40
            match[0].Point(player2); // Player 2 vinner Gamet

            match[1].Point(player1); // 15 - 0
            match[1].Point(player2); // 15 - 15
            match[1].Point(player2); // 15 - 30
            match[1].Point(player2); // 15 - 40
            match[1].Point(player2); // Player 2 vinner Gamet

            match[2].Point(player1); // 15 - 0
            match[2].Point(player2); // 15 - 15
            match[2].Point(player2); // 15 - 30
            match[2].Point(player2); // 15 - 40
            match[2].Point(player2); // Player 2 vinner Gamet


            string expected = $"{player2.Name} wins 0-3";

            Assert.Equal(expected, match.MatchScore());
        }
        [Fact]
        public void Match_NoWinner_MatchNotOver()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[0].Point(player1); // 15 - 0
            match[0].Point(player2); // 15 - 15
            match[0].Point(player2); // 15 - 30
            match[0].Point(player2); // 15 - 40

            string expected = $"Match is not over yet";

            Assert.Equal(expected, match.MatchScore());
        }
        [Fact]
        public void Match_TwoGames_MatchNotOver()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[0].Point(player1); // 15 - 0
            match[0].Point(player2); // 15 - 15
            match[0].Point(player2); // 15 - 30
            match[0].Point(player2); // 15 - 40
            match[0].Point(player2); // Player 2 vinner Gamet

            match[1].Point(player1); // 15 - 0
            match[1].Point(player2); // 15 - 15
            match[1].Point(player2); // 15 - 30
            match[1].Point(player2); // 15 - 40
            match[1].Point(player2); // Player 2 vinner Gamet

            match[2].Point(player1); // 15 - 0
            match[2].Point(player2); // 15 - 15
            match[2].Point(player2); // 15 - 30
            match[2].Point(player2); // 15 - 40*/
            


            string expected = $"Match is not over yet";

            Assert.Equal(expected, match.MatchScore());
        }

        [Fact]
        public void Match_NoWinner_MatchNotover()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[0].Point(player1); // 15 - 0
            match[0].Point(player2); // 15 - 15
            match[0].Point(player2); // 15 - 30
            match[0].Point(player2); // 15 - 40

            match[1].Point(player1); // 15 - 0
            match[1].Point(player2); // 15 - 15
            match[1].Point(player2); // 15 - 30
            match[1].Point(player2); // 15 - 40

            match[2].Point(player1); // 15 - 0
            match[2].Point(player2); // 15 - 15
            match[2].Point(player2); // 15 - 30
            match[2].Point(player2); // 15 - 40


            string expected = $"Match is not over yet";

            Assert.Equal(expected, match.MatchScore());
        }
    }
}
