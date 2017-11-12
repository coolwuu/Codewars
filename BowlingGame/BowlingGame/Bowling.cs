using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bowling
{
    public class Bowling
    {
    
        [Test]
        public void all_zero_pins_should_return_0()
        {
            //arrange 
            var playerResult = "0- 0- 0- 0- 0- 0- 0- 0- 0- 0-";
            var bowlingGame = new BowlingGame();
            Assert.AreEqual(0, bowlingGame.GetScoreBy(playerResult));
        }
    }

    public class BowlingGame
    {
        public int GetScoreBy(string playerResult)
        {
            return 0;
        }
    }
}
