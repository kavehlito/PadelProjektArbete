using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    class TestPlayer
    {

        [Fact]
        public void Name_Player()
        {
            var player1 = new Player("player1");
            var player2 = new Player("player2");

            Assert.Equal("player1", player1.Name);
            Assert.Equal("player1", player2.Name);
        }
    }
}
