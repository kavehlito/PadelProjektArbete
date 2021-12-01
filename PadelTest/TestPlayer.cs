using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class TestPlayer
    {
        [Fact]
        public void Name_Player()
        {
            var player1 = new Player("player1");
            var player2 = new Player("player2");

            Assert.Equal("player1", player1.Name);
            Assert.Equal("player2", player2.Name);
        }

        // testa vad som händer om man skriver in tom name
        // testa att score hänger med namn på player
    }
}
