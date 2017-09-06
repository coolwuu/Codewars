using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _0906_Largest5Digit
{
    class KataTest
    {
        [Test]
        public void input_4DigitNumber_return_greatest_2DigitNumber()
        {
            var input = 1234;
            Assert.AreEqual(34,Kata.GetNumber(input));

        }
    }
}
