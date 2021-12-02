using System;

namespace Padel
{
    public class Player
    {
        public string Name { set; get; }
        public Score Score { set; get; }
        
        //Changed to init Score
        public Player(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Cannot be empty");
            }

            Score = new Score
            {
                _Score = 0
            };
            Name = name;
        }
        
        public void Point()
        {
            Score.Increase();
        }
    }
}
