using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class TestScore
    {
        // testa när initierar score- är den null?

        [Fact]
        public void Does_Score_Increase()
        {
            var score = new Score();
            score.Increase();

            Assert.Equal(1, score._Score);
        }
    }
}
