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
            var numberGroup = Regex.Matches(number, "\\d{" + size + "}");

            foreach (Match num in numberGroup)
            {
                char[] digitArray = num.Value.ToCharArray();

                if (Sum(num.Value) % 2 == 0)
                {
                    Array.Reverse(digitArray);
                    result += new string(digitArray);
                }
                else
                {
                    var firstDigit = digitArray[0];
                    var list = digitArray.ToList();
                    list.RemoveAt(0);
                    list.Add(firstDigit);
                    result += string.Join("", list.ToArray());
                    
                }

            }
            return result;
        }

        public static int Sum(string number)
        {
            return number.ToList().Select(Convert.ToInt32).Sum();
        }
    }
}
