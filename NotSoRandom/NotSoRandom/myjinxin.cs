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
        [TestCase(1,1,"Black")]
        public void one_black_one_white_should_return_black(double black,double white,string expected)
        {
            Assert.AreEqual("Black",NotSoRandom(black, white));
        }

        private static string NotSoRandom(double black, double white)
        {
            return "Black";
        }
    }
}
