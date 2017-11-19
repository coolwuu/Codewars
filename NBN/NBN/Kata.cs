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
            Assert.AreEqual(21, NextBiggerNumber(12));
        }
        [Test]
        public void input_21_should_return_minus_one()
        {
            Assert.AreEqual(-1, NextBiggerNumber(21));
        }
        [Test]
        public void input_123_should_return_132()
        {
            Assert.AreEqual(132, NextBiggerNumber(123));
        }

        private int NextBiggerNumber(int number)
        {
            if (number.ToString().Length < 2)
                return -1;

            var num = GetArrayBy(number);
            bool IsChanged = false;
            for (int i = num.Length - 1; i >= 1; i--)
            {
                if (num[i] > num[i - 1])
                {
                    var temp = num[i];
                    num[i] = num[i - 1];
                    num[i - 1] = temp; 
                    IsChanged = true;
                    break;
                }
            }
            return IsChanged ? int.Parse(new string(num)) : -1;

        }

        private char[] GetArrayBy(int number)
        {
            return number.ToString().ToCharArray();
        }
    }
}
