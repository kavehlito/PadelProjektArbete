using System.Collections.Generic;

namespace Padel
{
    public class Match
    {

        private readonly List<Game> _Games = new List<Game>();
        public Player _Player1;
        public Player _Player2;
        private readonly Set _Set;
        public Match(Set set)
        {
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

        public int Point(Player player)
        {
            return _Set.Points(player);
        }

        public string MatchScore()
        {
            int pointDifference1 = Point(_Player1) - Point(_Player2);
            int pointDifference2 = Point(_Player2) - Point(_Player1);

            if (pointDifference1 > pointDifference2)
            {
                return $"{_Player1.Name} wins {Point(_Player1)}-{Point(_Player2)}";
            }
            else if (pointDifference1 < pointDifference2)
            {
                return $"{_Player2.Name} wins {Point(_Player1)}-{Point(_Player2)}";
            }
            else
                return "Match is not over yet";
        }

    }
}


