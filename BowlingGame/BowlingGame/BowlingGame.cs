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

            for (var index = 0; index < _frameResult.Count; index++)
            {
                var frame = _frameResult[index];
                if (index > 8)
                {
                    if (frame.Spare())
                        finalScore += _frameResult[index].ScoreOfFirstRoll();
                    finalScore += frame.Score();
                }
                else
                {
                    finalScore += frame.Score();
                    if(frame.Spare())
                        finalScore +=  _frameResult[index + 1].ScoreOfFirstRoll();

                    if (frame.Strike())
                    {
                        if (_frameResult[index + 1].Strike())
                        {
                            finalScore += _frameResult[index + 1].Score();
                            finalScore += _frameResult[index + 2].ScoreOfFirstRoll();
                        }
                        else
                        {
                            finalScore += _frameResult[index + 1].Score();
                        }
                    }
                }
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
}