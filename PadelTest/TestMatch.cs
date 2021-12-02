using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

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
    }
}
