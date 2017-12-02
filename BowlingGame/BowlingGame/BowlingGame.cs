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

            foreach (Frame frame in _frameResult)
            {
                if (CheckIsLastFrame(frame))
                {
                    if (frame.Spare())
                        finalScore += frame.ScoreOfBonusRoll();
                    finalScore += frame.Score();
                }
                else
                {
                    finalScore += GetScoreBy(frame);
                }
            }
            return finalScore;
        }

        private int GetScoreBy(Frame frame)
        {
            var result = 0;
            result += frame.Score();
            result += GetScoreWhenSpare(frame);
            result += GetScoreWhenStrike(frame);
            return result;
        }

        private bool CheckIsLastFrame(Frame frame)
        {
            var currentIndex = _frameResult.IndexOf(frame);
            return currentIndex > 8;
        }

        private int GetScoreWhenSpare(Frame frame)
        {
            int result = 0;
            var currentIndex = _frameResult.IndexOf(frame);
            if (frame.Spare())
                result += _frameResult[currentIndex + 1].ScoreOfFirstRoll();
            return result;
        }

        private int GetScoreWhenStrike(Frame frame)
        {
            int result = 0;
            var currentIndex = _frameResult.IndexOf(frame);
            if (frame.Strike())
            {
                if (_frameResult[currentIndex + 1].Strike())
                {
                    result += _frameResult[currentIndex + 1].Score();
                    result += _frameResult[currentIndex + 2].ScoreOfFirstRoll();
                }
                else
                {
                    result += _frameResult[currentIndex + 1].Score();
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