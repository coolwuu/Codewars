using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _0906_Reverse_Rotate
{
    public class StringProcesser
    {
        public static string RevRot(string number, int size)
        {
            if (size <= 0)
                return string.Empty;

            var result = string.Empty;
            var numberGroup = Regex.Matches(number, $"\\d{{{size}}}");

            foreach (Match num in numberGroup)
                if (Sum(num.Value) % 2 == 0)
                {
                    num.Value.Reverse();
                    result += num.Value;
                }
                else
                {
                    result += num.Value.Substring(1) + num.Value[0];
                }
            return result;
        }

        public static int Sum(string number)
        {
            return number.ToList().Select(Convert.ToInt32).Sum();
        }
    }
}
