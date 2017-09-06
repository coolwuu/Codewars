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
            var numbers = Regex.Matches(number, "\\d{"+size+"}");
;            foreach (Match num in numbers)
            {
                char[] digitArray = num.Value.ToCharArray();
                if (num.Value.Length >= size)
                {
                    if (int.Parse(num.Value) % 2 == 0)
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
                        result += string.Join("", list.ToArray()); ;
                    }
                } 
            }
            return result;
        }
    }
}
