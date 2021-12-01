namespace Padel
{

    public class Game
    {
        private readonly Player _Player1;
        private readonly Player _Player2;

        public Player Player1 => _Player1;
        public Player Player2 => _Player2;

        private Player _Winner;
        public Player Winner => _Winner;

        public Game(Player player1, Player player2)
        {
            _Player1 = player1;
            _Player2 = player2;
        }

        public void Point(Player player)
        {
            player.Point();

            if (_Player1.Score._Score >= 4 && _Player1.Score._Score >= _Player2.Score._Score + 2)
            {
                _Winner = Player1;
            }
            if (_Player2.Score._Score >= 4 && _Player2.Score._Score >= _Player1.Score._Score + 2)
            {
                _Winner = Player2;
            }
        }

        public Score Score(Player player)
        {
            return player.Score;
        }

        public string ScoreString()
        {

            if (_Player1.Score._Score >= 4 &&
                _Player1.Score._Score >= _Player2.Score._Score + 2)
            {
                _Winner = Player1;
                return "Player 1 wins";
            }
            if (_Player2.Score._Score >= 4 &&
                _Player2.Score._Score >= _Player1.Score._Score + 2)
            {
                _Winner = Player2;
                return "Player 2 wins";
            }
            return "Game is not over yet";

        }
    }
}
