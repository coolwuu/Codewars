using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NBN
{
    public class Kata
    {
        [Test]
        public void input_8_should_return_minus_one()
        {
            Assert.AreEqual(-1, NextBiggerNumber(9));
        }
        [Test]
        public void input_12_should_return_21()
        {
            Assert.AreEqual(-1, NextBiggerNumber(9));
        }

        private int NextBiggerNumber(int number)
        {
            if (number.ToString().Length < 2)
                return -1;

            var numInArray = GetArrayBy(number);
            Array.Reverse(numInArray);
            return int.Parse(new string(numInArray));

        }

        private char[] GetArrayBy(int number)
        {
            return number.ToString().ToCharArray();
        }
    }
}
