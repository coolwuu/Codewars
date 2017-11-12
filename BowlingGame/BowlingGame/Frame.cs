namespace Bowling
{
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
            if (Strike())
                return 10;
            if (SecondRollIsGutterBall())
                return int.Parse(FirstRoll);
            return int.Parse(FirstRoll) + int.Parse(SecondRoll);
        }

        public int ScoreOfFirstRoll()
        {
            if (Strike())
                return 10;
            return int.Parse(FirstRoll);
        }

        public bool Strike()
        {
            return FirstRoll.Contains("X");
        }
    }
}