using System.Linq;

namespace Abbreviator_0114
{
    public class Abbreviator
    {
        public string Abbreviate(string input)
        {
            if (input.Length <= 3)
                return input;
            return input.First() + (input.Length - 2).ToString() + input.Last();
        }
    }
}