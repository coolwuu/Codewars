namespace Abbreviator_0114
{
    public class Abbreviator
    {
        public string Abbreviate(string input)
        {
            if (input.Length <= 3)
                return input;
            return string.Empty;
        }
    }
}