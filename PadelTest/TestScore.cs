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
        public void ScoreField_Init()
        {
            Score firstScore = new Score();
            Assert.Equal(0, firstScore._Score);
        }

        [Fact]
        public void ScoreMethod_Increase()
        {
            var score = new Score();
            score.Increase();

            Assert.Equal(1, score._Score);
        }

        [Fact]
        public void ScoreClass_Init()
        {
            Score firstScore = new Score();

            Assert.NotNull(firstScore);
        }
    }
}
