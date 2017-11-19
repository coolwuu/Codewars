using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NextBiggerNumberWithSameDigits
{
    public class Kata
    {
        [Test]
        public void input_9_should_return_minus_1()
        {
            Assert.AreEqual(-1, NextBigNumber(9));
        }
        [Test]
        public void input_12_should_return_21()
        {
            Assert.AreEqual(21, NextBigNumber(12));
        }
        [Test]
        public void input_13_should_return_31()
        {
            Assert.AreEqual(31, NextBigNumber(13));
        }

        [Test]
        public void input_31_should_return_minus_1()
        {
            Assert.AreEqual(-1, NextBigNumber(31));
        }
        [Test]
        public void input_111_should_return_minus_1()
        {
            Assert.AreEqual(-1, NextBigNumber(111));
        }
        private int NextBigNumber(int number)
        {
            if (number.ToString().Length < 2)
                return -1;

            var num = GetCharArrayBy(number);

            for (var i = num.Length - 1; i >= 1; i--)
            {
                if (num[i] > num[i - 1])
                {
                    var temp = new char();
                    temp = num[i];
                    num[i] = num[i - 1];
                    num[i - 1] = temp;
                }
                else
                {
                    return -1;
                }
            }
            return int.Parse(new string(num));
        }

        private static char[] GetCharArrayBy(int number)
        {
            return number.ToString().ToCharArray();
        }
    }
}
