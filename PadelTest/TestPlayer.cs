using Padel;
using System;
using Xunit;

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

        [Fact]  // testa att score hänger med namn på player
        public void Player_ScoreFollow_PlayerName()
        {
            Player player1 = new Player("player1");
            Player player2 = new Player("player2");

            player1.Score.Increase();
            player2.Score.Increase();

            Assert.Equal(1, player1.Score._Score);
            Assert.Equal(1, player2.Score._Score);
        }

        [Fact]
        public void Player_Name_IsNull()
        {
            Action act = () => new Player(" "); 
            Assert.Throws<ArgumentException>(act);


            Action act1 = () => new Player(null); 
            Assert.Throws<ArgumentException>(act1);
            
        }
    }
}
