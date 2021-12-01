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
            Match match = new Match(5, player1, player2);

            Assert.Equal("Player 1", player1.Name);
            Assert.Equal("Player 2", player2.Name);
            Assert.Equal(5, match._sets.Count);
        }
    }
}
