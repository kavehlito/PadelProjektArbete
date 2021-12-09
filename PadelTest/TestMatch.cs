using Padel;
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
        public void Match_Init_IndexerNotNull()
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
        public void Match_Player1WinsMatch()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[0].Point(match[0].Player1); // 15 - 0
            match[0].Point(match[0].Player1); // 30 - 0
            match[0].Point(match[0].Player2); // 30 - 15
            match[0].Point(match[0].Player1); // 40 - 15
            match[0].Point(match[0].Player1); // Player 1 vinner Gamet

            match[1].Point(match[1].Player1); // 15 - 0
            match[1].Point(match[1].Player1); // 30 - 0
            match[1].Point(match[1].Player2); // 30 - 15
            match[1].Point(match[1].Player1); // 40 - 15
            match[1].Point(match[1].Player1); // Player 1 vinner Gamet

            match[2].Point(match[2].Player1); // 15 - 0
            match[2].Point(match[2].Player1); // 30 - 0
            match[2].Point(match[2].Player2); // 30 - 15
            match[2].Point(match[2].Player1); // 40 - 15
            match[2].Point(match[2].Player1); // Player 1 vinner Gamet


            string expected = $"{player1.Name} wins 3-0";

            Assert.Equal(expected, match.MatchScore());
        }


        [Fact]
        public void Match_Player2WinsMatch()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[0].Point(match[0].Player1); // 15 - 0
            match[0].Point(match[0].Player2); // 15 - 15
            match[0].Point(match[0].Player2); // 15 - 30
            match[0].Point(match[0].Player2); // 15 - 40
            match[0].Point(match[0].Player2); // Player 2 vinner Gamet

            match[1].Point(match[1].Player1); // 15 - 0
            match[1].Point(match[1].Player2); // 15 - 15
            match[1].Point(match[1].Player2); // 15 - 30
            match[1].Point(match[1].Player2); // 15 - 40
            match[1].Point(match[1].Player2); // Player 2 vinner Gamet

            match[2].Point(match[2].Player1); // 15 - 0
            match[2].Point(match[2].Player2); // 15 - 15
            match[2].Point(match[2].Player2); // 15 - 30
            match[2].Point(match[2].Player2); // 15 - 40
            match[2].Point(match[2].Player2); // Player 2 vinner Gamet


            string expected = $"{player2.Name} wins 0-3";

            Assert.Equal(expected, match.MatchScore());
        }
        [Fact]
        public void Match_FirstSetUnfinished_MatchNotOver()
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
        public void Match_ThirdMatchNotOver_MatchNotOver()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[0].Point(match[0].Player1); // 15 - 0
            match[0].Point(match[0].Player2); // 15 - 15
            match[0].Point(match[0].Player2); // 15 - 30
            match[0].Point(match[0].Player2); // 15 - 40
            match[0].Point(match[0].Player2); // Player 2 vinner Gamet

            match[1].Point(match[1].Player1); // 15 - 0
            match[1].Point(match[1].Player2); // 15 - 15
            match[1].Point(match[1].Player2); // 15 - 30
            match[1].Point(match[1].Player2); // 15 - 40
            match[1].Point(match[1].Player2); // Player 2 vinner Gamet

            match[2].Point(match[2].Player1); // 15 - 0
            match[2].Point(match[2].Player2); // 15 - 15
            match[2].Point(match[2].Player2); // 15 - 30


            string expected = $"Match is not over yet";

            Assert.Equal(expected, match.MatchScore());
        }
        [Fact]
        public void Match_MultipleUnfinishedSets_MatchNotover()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[0].Point(match[0].Player1); // 15 - 0
            match[0].Point(match[0].Player2); // 15 - 15
            match[0].Point(match[0].Player2); // 15 - 30
            match[0].Point(match[0].Player2); // 15 - 40

            match[1].Point(match[1].Player1); // 15 - 0
            match[1].Point(match[1].Player2); // 15 - 15
            match[1].Point(match[1].Player2); // 15 - 30
            match[1].Point(match[1].Player2); // 15 - 40

            match[2].Point(match[2].Player1); // 15 - 0
            match[2].Point(match[2].Player2); // 15 - 15
            match[2].Point(match[2].Player2); // 15 - 30
            match[2].Point(match[2].Player2); // 15 - 40


            string expected = $"Match is not over yet";

            Assert.Equal(expected, match.MatchScore());
        }

        //This test would originally fail, and we had a hard time fixing the code to make it pass.
        [Fact]
        public void Match_SkippedFirstMatch_NoWinner()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[1].Point(match[1].Player1); // 15 - 0
            match[1].Point(match[1].Player2); // 15 - 15
            match[1].Point(match[1].Player2); // 15 - 30
            match[1].Point(match[1].Player2); // 15 - 40
            match[1].Point(match[1].Player2); // Player 2 Wins

            match[2].Point(match[2].Player1); // 15 - 0
            match[2].Point(match[2].Player2); // 15 - 15
            match[2].Point(match[2].Player2); // 15 - 30
            match[2].Point(match[2].Player2); // 15 - 40
            match[2].Point(match[2].Player2); // Player 2 Wins

            string expected = $"Match is not over yet";

            Assert.Equal(expected, match.MatchScore());
        }

        [Fact]
        public void Match_PlayerScore_ReturnPoints()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Set mySet = new Set(3, player1, player2);
            Match match = new Match(mySet);

            match[1].Point(match[1].Player1); // 15 - 0
            match[1].Point(match[1].Player2); // 15 - 15
            match[1].Point(match[1].Player2); // 15 - 30
            match[1].Point(match[1].Player2); // 15 - 40
            match[1].Point(match[1].Player2); // Player 2 Wins

            Assert.Equal(1, match[1].Player1.Score._Score);
            Assert.Equal(4, match[1].Player2.Score._Score);
        }
    }
}
