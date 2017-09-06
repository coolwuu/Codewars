using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0906_Reverse_Rotate
{
    public class StringProcesser
    {
        public static string RevRot(string number, int size)
        {
            if (size <= 0)
                return string.Empty;

            var result=string.Empty;
            var numbers = Regex.Matches(number, @"\d{2}");
;            foreach (Match num in numbers)
            {
                char[] digitArray = num.Value.ToCharArray();
                if (num.Value.Length >= size)
                {
                    if (int.Parse(num.Value) % 2 == 0)
                    {
                        Array.Reverse(digitArray);
                    }
                    else
                    {
                        
                    }
                }
                result += new string(digitArray);
            }
            return result;
        }
    }
}
