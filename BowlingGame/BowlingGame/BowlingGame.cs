using System.Collections.Generic;
using System.Xml.Schema;
using NUnit.Framework;

namespace Bowling
{
    public class BowlingGame
    {
        private List<Frame> _frameResult = new List<Frame>();
        public int GetScoreBy(string playerResult)
        {
            var finalScore = 0;
            GenerateFramesResultBy(playerResult);

            foreach (var frame in _frameResult)
            {
                finalScore += frame.Score();
            }
            return finalScore;
        }

        private void GenerateFramesResultBy(string playerResult)
        {
            var playerResultInFrames = playerResult.Split(' ');
            foreach (var result in playerResultInFrames)
            {
                _frameResult.Add(new Frame(result));
            }
                
        }

    }

    public class Frame
    {
        public Frame(string result)
        {
            Result = result;
        }

        private string FirstRoll => Result[0].ToString();
        private string SecondRoll => Result[1].ToString();

        private string Result { get; }

        private bool SecondRollIsGutterBall()
        {
            return SecondRoll.Contains("-");
        }

        public int Score()
        {
            if (SecondRollIsGutterBall())
                return int.Parse(FirstRoll);
            return int.Parse(FirstRoll) + int.Parse(SecondRoll);
        }
    }
}