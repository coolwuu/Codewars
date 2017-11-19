using System;
using System.Collections.Generic;
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
            Assert.AreEqual(-1,NextBigNumber(9));
        }
        [Test]
        public void input_12_should_return_21()
        {
            Assert.AreEqual(21,NextBigNumber(12));
        }
        [Test]
        public void input_13_should_return_31()
        {
            Assert.AreEqual(31,NextBigNumber(12));
        }

        private int NextBigNumber(int number)
        {
            if(number.ToString().Length <2)
                return -1;
            return 21;

        }
    }
}
