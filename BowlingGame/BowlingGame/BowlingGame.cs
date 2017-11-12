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

            for (var current = 0; current < _frameResult.Count; current++)
            {
                var frame = _frameResult[current];
                if (current > 8)
                {
                    if (frame.Spare())
                        finalScore += _frameResult[current].ScoreOfBonusRoll();
                    finalScore += frame.Score();
                }
                else
                {
                    finalScore += frame.Score();
                    finalScore += GetScoreWhenSpare(current, frame);
                    finalScore += GetScoreWhenStrike(current, frame);
                }
            }
            return finalScore;
        }

        private int GetScoreWhenSpare( int index, Frame frame)
        {
            int result = 0;
            if (frame.Spare())
                result += _frameResult[index + 1].ScoreOfFirstRoll();
            return result;
        }

        private int GetScoreWhenStrike( int index, Frame frame)
        {
            int result = 0;
            if (frame.Strike())
            {
                if (_frameResult[index + 1].Strike())
                {
                    result += _frameResult[index + 1].Score();
                    result += _frameResult[index + 2].ScoreOfFirstRoll();
                }
                else
                {
                    result += _frameResult[index + 1].Score();
                }
            }

            return result;
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
}