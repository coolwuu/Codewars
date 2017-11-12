using NUnit.Framework;

namespace Bowling
{
    public class Bowling
    {
        readonly BowlingGame _bowlingGame = new BowlingGame();
        [Test]
        public void all_zero_pins_should_return_0()
        {
            
            //arrange 
            var playerResult = "0- 0- 0- 0- 0- 0- 0- 0- 0- 0-";
            Assert.AreEqual(0, _bowlingGame.GetScoreBy(playerResult));
        }
    }
}
