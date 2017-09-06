using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0906_Largest5Digit
{
    public class Kata
    {
        public static int GetNumber(string numbers)
        {
            List<int> twoDigitNumberList = new List<int>();
            for (var i = 0; i < numbers.Length-4; i++)
            {
                twoDigitNumberList.Add(Convert.ToInt32(numbers.Substring(i, 5)));
            }
            return twoDigitNumberList.Select(x => x).Max();

        }
    }
}
