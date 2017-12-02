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
            Assert.AreEqual(-1, NextBiggerNumber(8));
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

        [Test]
        public void input_1234567890_should_return_1234567908()
        {
            Assert.AreEqual(1234567908, NextBiggerNumber(1234567890));
        }


        private static long NextBiggerNumber(long number)
        {
            if (number.ToString().Length < 2)
                return -1;

            var num = GetArrayBy(number);
            bool IsChanged = false;
            for (int index = num.Length - 1; index >= 1; index--)
            {
                if (num[index] > num[index - 1])
                {
                    num = GenerateNextBiggerNumber(index, num, ref IsChanged);
                    break;
                }
            }
            return IsChanged ? Convert.ToInt64(new string(num)) : -1;

        }

        private static char[] GenerateNextBiggerNumber(int index, char[] num, ref bool isChanged)
        {
            var rightPart = new List<char>();
            var leftPart = new List<char>();
            var largerNum = new List<char>();

            for (var j = index - 1; j < num.Length; j++)
            {
                rightPart.Add(num[j]);
                if (num[j] > num[index - 1])
                {
                    largerNum.Add(num[j]);
                }
            }

            num[index - 1] = largerNum.Min();

            for (var j = 0; j < index; j++)
            {
                leftPart.Add(num[j]);
            }

            rightPart.Remove(largerNum.Min());
            rightPart.Sort();

            num = JoinArray(leftPart, rightPart);
            isChanged = true;
            return num;
        }

        private static char[] JoinArray(List<char> leftPart, List<char> rightPart)
        {
            var a = new char[leftPart.Count + rightPart.Count];
            leftPart.CopyTo(a, 0);
            rightPart.CopyTo(a, leftPart.Count);
            return a;
        }

        private static char[] GetArrayBy(long number)
        {
            return number.ToString().ToCharArray();
        }


    }
}
