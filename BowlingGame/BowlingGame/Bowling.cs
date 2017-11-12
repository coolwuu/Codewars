using NUnit.Framework;

namespace Bowling
{
    public class Bowling
    {
        readonly BowlingGame _bowlingGame = new BowlingGame();

        [Test]
        public void all_zero_pins_should_return_0()
        {
            var playerResult = "0- 0- 0- 0- 0- 0- 0- 0- 0- 0-";
            Assert.AreEqual(0, _bowlingGame.GetScoreBy(playerResult));
        }

        [Test]
        public void all_one_pins_should_return_10()
        {
            var playerResult = "1- 1- 1- 1- 1- 1- 1- 1- 1- 1-";
            Assert.AreEqual(10, _bowlingGame.GetScoreBy(playerResult));
        }
    }
}
