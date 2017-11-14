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
        private string BonusRoll => Result[2].ToString();


        private string Result { get; }

        private bool SecondRollIsGutterBall()
        {
            return SecondRoll.Contains("-");
        }

        public int Score()
        {
            if (Strike())
                return 10;
            if (Spare())
                return 10;
            if (SecondRollIsGutterBall())
                return int.Parse(FirstRoll);
            return int.Parse(FirstRoll) + int.Parse(SecondRoll);
        }

        public bool Strike()
        {
            return FirstRoll.Contains("X");
        }

        public bool Spare()
        {
            if (Strike())
                return false;
            return SecondRoll.Contains("/");
        }

        public int ScoreOfBonusRoll()
        {
            if (BonusRoll.Contains("X"))
                return 10;
            return int.Parse(BonusRoll);
        }

        public int ScoreOfFirstRoll()
        {
            if (Strike())
                return 10;
            return int.Parse(FirstRoll);
        }
    }
}