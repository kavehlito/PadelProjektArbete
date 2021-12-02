using System;
using System.Collections.Generic;

namespace Padel
{
    public class Set
    {
        public List<Game> _Games = new List<Game>();
        public Player _Player1;
        public Player _Player2;

        //Constructor added to initialize games and players
        public Set(int nrOfSets, Player player1, Player player2)
        {
            this._Player1 = player1;
            this._Player2 = player2;

            for(int i = 0; i < nrOfSets; i++)
            {
                Game newGame = new Game(player1, player2);
                _Games.Add(newGame);
            }
        }

        //Indexer was added to access the private List<Game>
        public Game this[int i]
        {
            get { return _Games[i]; }
            set { _Games[i] = value; }
        }
        

        //Changed to count points depending on number of winning games
        public int Points(Player player)
        {
            int points = 0;
            for(int i = 0; i < _Games.Count; i++)
            {
                if (_Games[i].Winner?.Name == player.Name)
                    points++;
            }
            return points;
        }
    }
}
