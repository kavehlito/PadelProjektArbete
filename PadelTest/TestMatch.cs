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
            Player player1 = new Player("Player1");
            Player player2 = new Player("Player2");
            Match match = new Match(5, player1, player2);

            Assert.Equal("Player1", player1.Name);
            Assert.Equal("Player2", player2.Name);
            Assert.Equal(5, match._sets.Count);
        }

        [Fact]
        public void Match_Player1_WinSet()
        {
            Player player1 = new Player("Player1");
            Player player2 = new Player("Player2");
            Match match = new Match(3, player1, player2);

            match.Point(player1);
            match.Point(player1);
            match.Point(player1);
            match.Point(player2);
            match.Point(player1);

            match.Point(player1);
            match.Point(player1);
            match.Point(player1);
            match.Point(player2);
            match.Point(player1);

            match.Point(player1);
            match.Point(player1);
            match.Point(player1);
            match.Point(player2);
            match.Point(player1);

            Assert.Equal(3, player1.Points());
        }
        [Fact]
        public void Match_MatchScore_GetMatchScore()
        {

        }
    }
}
