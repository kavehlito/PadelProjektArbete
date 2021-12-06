using System;
using System.Collections.Generic;

namespace Padel
{
    public class Set
    {
        //Changed name of field from _games to _Games to conform with naming conventions
        public List<Game> _Games = new List<Game>();

        //Added fields representing the players.
        public Player _Player1;
        public Player _Player2;

        //Constructor added to initialize games and players.
        public Set(int nrOfSets, Player player1, Player player2)
        {
            this._Player1 = new Player(player1.Name);
            this._Player2 = new Player(player2.Name); 

            //Looping over the number of sets to initialize the corresponding number of games, then add the games to the list of games.
            for (int i = 0; i < nrOfSets; i++)
            {

                Game newGame = new Game(new Player(player1.Name), new Player(player2.Name));
                _Games.Add(newGame);
            }
        }

        //Indexer was added to access the private List<Game>
        public Game this[int i]
        {
            get { return _Games[i]; }
            set { _Games[i] = value; }
        }
        

        //Changed to count points depending on number of winning games.
        //Would originally only add points to the first game in the list of games.
        //Changed method name for clarity.
        public int Points(Player player)
        {
            int points = 0;
            for(int i = 0; i < _Games.Count; i++)
            {
                if (_Games[i].Winner?.Name == player.Name)
                {
                    points++;
                    continue;
                }
            }
            return points;
        }
    }
}
