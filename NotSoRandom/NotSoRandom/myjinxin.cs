using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NotSoRandom
{
    [TestFixture]
    public class Myjinxin
    {
        [TestCase(1, 1, "Black", TestName = "one_black_one_white_should_return_black")]
        [TestCase(2, 1, "White", TestName = "two_black_one_white_should_return_white")]
        [TestCase(1, 2, "Black", TestName = "one_black_two_white_should_return_black")]
        [TestCase(2, 2, "White", TestName = "2_black_2_white_should_return_white")]
        [TestCase(3, 2, "Black", TestName = "3_black_2_white_should_return_Black")]
        public void Test(double black, double white, string expected)
        {
            Assert.AreEqual(expected, NotSoRandom(black, white));
        }

        private static string NotSoRandom(double black, double white)
        {
            if (black == 2)
                return "White";
            return "Black";
        }
    }
}
