﻿using NUnit.Framework;

namespace Bowling
{
    public class Bowling
    {
        private BowlingGame _bowlingGame;
        [SetUp]
        public void initialGame()
        {
            _bowlingGame = new BowlingGame();
        }

        [Test]
        public void all_frames_got_zero_pins_should_return_0()
        {
            ScoreShouldBe(0, "0- 0- 0- 0- 0- 0- 0- 0- 0- 0-");
        }

        [Test]
        public void all_frames_got_one_pins_should_return_10()
        {
            ScoreShouldBe(10, "1- 1- 1- 1- 1- 1- 1- 1- 1- 1-");
        }

        [Test]
        public void all_frames_got_9_pins_should_return_90()
        {
            ScoreShouldBe(90, "18 18 81 63 36 45 54 9- 09 18");
        }

        [Test]
        public void all_frames_got_strike_should_return_300()
        {
            ScoreShouldBe(300, "X X X X X X X X X X X X");
        }

        private void ScoreShouldBe(int expected, string playerResult)
        {
            Assert.AreEqual(expected, _bowlingGame.GetScoreBy(playerResult));
        }
    }
}
