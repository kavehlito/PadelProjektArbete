using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class TestSet
    {
        [Fact]
        public void Set_Init3_ZeroPoints()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Set mySet = new Set(3, player1, player2);

            Assert.Equal(0, mySet.Points(player1));
            Assert.Equal(0, mySet.Points(player2));
        }

        [Fact]
        public void Set_Simulate3Games_Player1Wins()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Set mySet = new Set(3, player1, player2);

            mySet[0].Point(player1); // 15 - 0
            mySet[0].Point(player1); // 30 - 0
            mySet[0].Point(player2); // 30 - 15
            mySet[0].Point(player1); // 40 - 15
            mySet[0].Point(player1); // Player 1 vinner Gamet

            mySet[1].Point(player1); // 15 - 0
            mySet[1].Point(player1); // 30 - 0
            mySet[1].Point(player2); // 30 - 15
            mySet[1].Point(player1); // 40 - 15
            mySet[1].Point(player1); // Player 1 vinner Gamet

            mySet[2].Point(player1); // 15 - 0
            mySet[2].Point(player1); // 30 - 0
            mySet[2].Point(player2); // 30 - 15
            mySet[2].Point(player1); // 40 - 15
            mySet[2].Point(player1); // Player 1 vinner Gamet

            Assert.Equal(3, mySet.Points(player1));
            Assert.Equal(0, mySet.Points(player2));
        }

        [Fact]
        public void Set_Simulate5Games_Player2Wins()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Set mySet = new Set(5, player1, player2);

            mySet[0].Point(player1); 
            mySet[0].Point(player1); 
            mySet[0].Point(player2); 
            mySet[0].Point(player2); 
            mySet[0].Point(player2);
            mySet[0].Point(player2);

            mySet[1].Point(player1); 
            mySet[1].Point(player2); 
            mySet[1].Point(player2); 
            mySet[1].Point(player2); 
            mySet[1].Point(player2); 

            mySet[2].Point(player1); 
            mySet[2].Point(player2); 
            mySet[2].Point(player2); 
            mySet[2].Point(player2); 
            mySet[2].Point(player2); 

            mySet[3].Point(player1); 
            mySet[3].Point(player2); 
            mySet[3].Point(player2); 
            mySet[3].Point(player2); 
            mySet[3].Point(player2); 

            mySet[4].Point(player1); 
            mySet[4].Point(player2); 
            mySet[4].Point(player2); 
            mySet[4].Point(player2); 
            mySet[4].Point(player2); 


            Assert.Equal(0, mySet.Points(player1));
            Assert.Equal(5, mySet.Points(player2));
        }

        [Fact]
        public void Indexer_Init_ShouldBeAGame()
        {
            Player player1 = new Player("player1");
            Player player2 = new Player("player2");

            Set set1 = new Set(3, player1, player2);
            set1[0] = new Game(player1, player2);

            Assert.NotNull(set1[0]);
            Assert.Equal(player1, set1[0].Player1);
            Assert.Equal(player2, set1[0].Player2);

        }

        [Fact]
        public void Set_Simulate3GamesButLastNotFinished_CorrectPoints()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Set mySet = new Set(3, player1, player2);

            mySet[0].Point(mySet[0].Player1); // 15 - 0
            mySet[0].Point(mySet[0].Player1); // 30 - 0
            mySet[0].Point(mySet[0].Player2); // 30 - 15
            mySet[0].Point(mySet[0].Player1); // 40 - 15
            mySet[0].Point(mySet[0].Player1); // Player 1 vinner Gamet

            mySet[1].Point(mySet[1].Player1); // 15 - 0
            mySet[1].Point(mySet[1].Player1); // 30 - 0
            mySet[1].Point(mySet[1].Player2); // 30 - 15
            mySet[1].Point(mySet[1].Player1); // 40 - 15
            mySet[1].Point(mySet[1].Player1); // Player 1 vinner Gamet

            mySet[2].Point(mySet[2].Player1); // 15 - 0
            mySet[2].Point(mySet[2].Player1); // 30 - 0
            mySet[2].Point(mySet[2].Player2); // 30 - 15

            Assert.Equal(2, mySet.Points(mySet[2].Player1));
            Assert.Equal(0, mySet.Points(mySet[2].Player2));
        }

        [Fact]
        public void Set_Simulate3GamesButTwoNotFinished_CorrectPoints()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Set mySet = new Set(3, player1, player2);

            mySet[0].Point(mySet[0].Player1); // 15 - 0
            mySet[0].Point(mySet[0].Player1); // 30 - 0
            mySet[0].Point(mySet[0].Player2); // 30 - 15
            mySet[0].Point(mySet[0].Player1); // 40 - 15
            mySet[0].Point(mySet[0].Player1); // Player 1 vinner Gamet

            mySet[1].Point(mySet[1].Player1); // 15 - 0

            mySet[2].Point(mySet[2].Player1); // 15 - 0

            Assert.Equal(1, mySet.Points(mySet[2].Player1));
            Assert.Equal(0, mySet.Points(mySet[2].Player2));
            Assert.Equal(player1.Name, mySet[0].Winner.Name);
            Assert.Null(mySet[2].Winner);
            Assert.Equal(0, mySet[2].Player2.Score._Score);

        }

        [Fact]
        public void Set_Simulate3GamesButTwoNotFinished_CorrectWinners()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Set mySet = new Set(3, player1, player2);

            mySet[0].Point(mySet[0].Player1); // 15 - 0
            mySet[0].Point(mySet[0].Player1); // 30 - 0
            mySet[0].Point(mySet[0].Player2); // 30 - 15
            mySet[0].Point(mySet[0].Player1); // 40 - 15
            mySet[0].Point(mySet[0].Player1); // Player 1 vinner Gamet

            mySet[1].Point(player1); // 15 - 0

            mySet[2].Point(player1); // 15 - 0

            Assert.Equal(player1.Name, mySet[0].Winner.Name);
            Assert.Null(mySet[1].Winner);
            Assert.Null(mySet[2].Winner);
            //Assert.Equal(0, mySet[2].Player2.Score._Score);

        }
    }
}
