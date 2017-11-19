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
            Assert.AreEqual(-1,NextBiggerNumber(9));
        }

        private int NextBiggerNumber(int number)
        {
            return -1;
        }
    }
}
