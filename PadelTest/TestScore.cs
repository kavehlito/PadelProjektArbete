using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class TestScore
    {
        [Fact]
        public void Score_Init_ShouldBeZero()
        {
            Score firstScore = new Score();
            Assert.Equal(0, firstScore._Score);
        }

        [Fact]
        public void Increase_IncreaseOnce_ShouldBeOne()
        {
            var score = new Score();
            score.Increase();

            Assert.Equal(1, score._Score);
        }

        [Fact]
        public void ScoreClass_Init_NotNull()
        {
            Score firstScore = new Score();

            Assert.NotNull(firstScore);
        }
    }
}
