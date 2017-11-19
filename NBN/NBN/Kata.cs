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
        [Test]
        public void input_132_should_return_213()
        {
            Assert.AreEqual(213, NextBiggerNumber(132));
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
                    var rightPart = new List<char>();
                    var leftPart = new List<char>();
                    var lNum = new List<char>();
                    for (var j = i - 1; j < num.Length; j++)
                    {
                        rightPart.Add(num[j]);
                        if (num[j] > num[i - 1])
                        {
                            lNum.Add(num[j]);
                        }
                    }
                    var largerNum = lNum.Min();
                    num[i - 1] = largerNum;
                    for (var j = 0; j < i; j++)
                    {
                        leftPart.Add(num[j]);
                    }
                    rightPart.Remove(largerNum);
                    var a = new char[leftPart.Count+rightPart.Count];
                    leftPart.CopyTo(a,0);
                    rightPart.CopyTo(a,leftPart.Count);
                    num = a;
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
