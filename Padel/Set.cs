using System;
using System.Collections.Generic;

namespace Padel
{
    public class Set
    {
        private List<Game> _games = new List<Game>();

        //Constructor added to initialize games and players
        public Set(int nrOfSets, Player player1, Player player2)
        {
            for(int i = 0; i < nrOfSets; i++)
            {
                Game newGame = new Game(player1, player2);
                _games.Add(newGame);
            }
        }

        //Indexer was added to access the private List<Game>
        public Game this[int i]
        {
            get { return _games[i]; }
            set { _games[i] = value; }
        }
        

        //Changed to count points depending on number of winning games
        public int Points(Player player)
        {
            int points = 0;
            for(int i = 0; i < _games.Count; i++)
            {
                if (_games[i].Winner?.Name == player.Name)
                    points++;
            }
            return points;
        }
    }
}
