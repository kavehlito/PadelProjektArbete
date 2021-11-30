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
            this.Score = new Score();
            this.Score._Score = 0;
            Name = name;
        }
        
        public void Point()
        {
            Score.Increase();
        }
    }
}
