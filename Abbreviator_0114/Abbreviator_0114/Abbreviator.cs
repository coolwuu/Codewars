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
            if (input.Length <= 3)
                return input;
            var result = new List<string>();
            var words = Regex.Split(input, @"\W+");
            foreach (var word in words)
            {
                result.Add(word.First() + (word.Length - 2).ToString() + word.Last()); 
            }
            return String.Join(" ",result.ToArray());
        }
    }
}