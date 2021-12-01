﻿using System.Collections.Generic;

namespace Padel
{
    public class Match
    {

        public List<Set> _sets;
        public Player _player1;
        public Player _player2;
        public Match(int numberOfSets, Player player1, Player player2)
        {

            _sets = new List<Set>(numberOfSets);
            for (int i = 0; i < numberOfSets; i++)
            {
                _sets.Add(new Set(5, player1, player2));
            }
            _player1 = player1;
            _player2 = player2;

        }

        public void Point(Player player)
        {
            _sets[0].Points(player);
        }

        public Score MatchScore()
        {
            return new Score();
        }

    }
}


