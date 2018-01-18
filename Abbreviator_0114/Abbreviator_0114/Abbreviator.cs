using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Abbreviator_0114
{
    public class Abbreviator
    {
        public string Abbreviate(string input)
        {
            var words = Regex.Split(input, @"\W+");
            foreach (var word in words)
            {
                if (word.Length >= 4)
                {
                    input = input.Replace(word, Abbreviated(word));
                }
            }
            return input;
        }

        private static string Abbreviated(string word)
        {
            return word.First() + (word.Length - 2).ToString() + word.Last();
        }
    }
}