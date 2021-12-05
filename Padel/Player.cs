using System;

namespace Padel
{
    public class Player
    {
        //Unchanged properties.
        public string Name { set; get; }
        public Score Score { set; get; }
        
        //Changed to init Score
        public Player(string name)
        {
            //Added exception: Name cannot be null or empty.
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Cannot be empty");
            }

            //Added to initialize Score to 0, preventing test failures.
            Score = new Score
            {
                _Score = 0
            };
            Name = name;
        }
        
        //Unchanged method
        public void Point()
        {
            Score.Increase();
        }
    }
}
