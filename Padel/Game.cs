﻿namespace Padel
{

    public class Game
    {
        private Player _player1;
        private Player _player2;

        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void Point(Player player)
        {
            player.Point();
        }

        public Score Score(Player player)
        {
            return player.Score;
        }

        public string ScoreString()
        {
            if (_player1.Score._Score > 4 &&
                _player1.Score._Score >= _player2.Score._Score + 2)
            {
                return "Player 1 wins";
            }
            if (_player2.Score._Score > 4 &&
                _player2.Score._Score >= _player1.Score._Score + 2)
            {
                return "Player 2 wins";
            }
            return "Game is not over yet";
        }
    }
}
