using System.Collections.Generic;

namespace Padel
{
    public class Match
    {
        //Changed from List<Set> _sets to a list of games.
        //This change was decided on after long discussions within the group.
        //Changed to readonly because of VisualStudio recommendation messages.
        private readonly List<Game> _Games = new List<Game>();

        //Changed names from _player1 and _player2 to _Player1 and _Player2, due to naming conventions.
        public Player _Player1;
        public Player _Player2;

        //Added a Set as a field to create a one-to-one connection between the Set and Match classes.
        //Changed to readonly because of VisualStudio recommendation messages.
        private readonly Set _Set;

        //Changed removed previous constructor parameters and changed them to a Set. This Set contains the necessary members to initialize Match.
        public Match(Set set)
        {
            //Initialize the fields used in Match, now different from before.
            this._Set = set;
            this._Player1 = set._Player1;
            this._Player2 = set._Player2;
            this._Games = set._Games;
        }

        //Indexer was added to access the private List<Game>
        public Game this[int i]
        {
            get { return _Games[i]; }
            set { _Games[i] = value; }
        }

        //Changed to simply access the Points method in the corresponding Set.
        public int Point(Player player)
        {
            return _Set.Points(player);
        }

        //Previously, MatchScore() would only return a new Score.
        //Will now attempt to calculate the winner of a match and return a string of who the winner is.
        //Previously, this method wouldn't pass all tests
        public string MatchScore()
        {
            int pointDifference1 = Point(_Player1) - Point(_Player2);
            int pointDifference2 = Point(_Player2) - Point(_Player1);

            if (pointDifference1 > pointDifference2 && Point(_Player1) >= 3)
            {
                return $"{_Player1.Name} wins {Point(_Player1)}-{Point(_Player2)}";
            }
            else if (pointDifference1 < pointDifference2 && Point(_Player2) >= 3)
            {
                return $"{_Player2.Name} wins {Point(_Player1)}-{Point(_Player2)}";
            }
            else
                return "Match is not over yet";
        }

    }
}


