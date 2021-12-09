//PROJEKTUPPGIFT
//MADE BY: Maria Kilsved, Kaveh Jalilyand, Louise Littecke

namespace Padel
{

    public class Game
    {
        //Changed names from _player1 and _player2 to conform to naming conventions
        //Added readonly modifier due to VisualStudio suggestions
        private readonly Player _Player1;
        private readonly Player _Player2;

        //Added properties to enable access outside of class
        public Player Player1 => _Player1;
        public Player Player2 => _Player2;

        //Added backing field and property for the winner of a game to make it easier to use the class. Will be null if unassigned.
        private Player _Winner = null;
        public Player Winner => _Winner;

        //Added constructor to force the assignment of initial values.
        public Game(Player player1, Player player2)
        {
            _Player1 = player1;
            _Player2 = player2;

        }

        public void Point(Player player)
        {
            //Changed from _player1.Point() to assign a point to the correct player
            player.Point();

            //Assign a value to _Winner if a winner exists 
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
            //Changed from _player1.Score to obtain the value of the Score of the correct player
            return player.Score;
        }

        public string ScoreString()
        {

            //Changed to more complex conditional expressions to follow the rules of a real padel game.
            if (_Player1.Score._Score >= 4 &&
                _Player1.Score._Score >= _Player2.Score._Score + 2)
            {
                _Winner = Player1;
                return "Player 1 wins";
            }
            //Included a condition to check if _Player2 has won. Necessary in case neither player has won.
            if (_Player2.Score._Score >= 4 &&
                _Player2.Score._Score >= _Player1.Score._Score + 2)
            {
                _Winner = Player2;
                return "Player 2 wins";
            }
            //Since a padel game cannot be a tie, return a message the game hasn't ended in case there is no winner.
            return "Game is not over yet";

        }
    }
}
