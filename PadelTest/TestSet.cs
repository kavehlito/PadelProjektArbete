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
        public void Set_Init3_NoPoints()
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
        public void Point_In_Game()
        {
            Player player1 = new Player("player1");
            Player player2 = new Player("player2");

          //  _games.Point(player1);

        }


    }
}
