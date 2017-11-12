using NUnit.Framework;

namespace Bowling
{
    public class Bowling
    {
        readonly BowlingGame _bowlingGame = new BowlingGame();

        [Test]
        public void all_zero_pins_should_return_0()
        {
            ScoreShouldBe(0,"0- 0- 0- 0- 0- 0- 0- 0- 0- 0-");
        }

        [Test]
        public void all_one_pins_should_return_10()
        {
            ScoreShouldBe(10, "1- 1- 1- 1- 1- 1- 1- 1- 1- 1-");
        }



        private void ScoreShouldBe(int expected,string playerResult)
        {
            Assert.AreEqual(expected, _bowlingGame.GetScoreBy(playerResult));
        }
    }
}
