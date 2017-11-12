namespace Bowling
{
    public class BowlingGame
    {
        public int GetScoreBy(string playerResult)
        {
            var finalScore = 0;
            var playerResultInFrames = playerResult.Split(' ');
            foreach (var frame in playerResultInFrames)
            {
                finalScore += ScoreBy(frame);
            }
            return finalScore;
        }

        private int ScoreBy(string frame)
        {
            if (frame.Contains("-"))
                return int.Parse(frame[0].ToString());
            return int.Parse(frame[0].ToString()) +int.Parse(frame[1].ToString());
        }
    }
}