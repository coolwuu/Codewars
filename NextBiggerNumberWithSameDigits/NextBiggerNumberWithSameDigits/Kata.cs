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

        private int NextBigNumber(int number)
        {
            throw new NotImplementedException();
        }
    }
}
