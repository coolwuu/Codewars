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
        [Test]
        public void one_black_one_white_should_return_black()
        {
            double black = 1;
            double white = 1;
            Assert.AreEqual("Black",NotSoRandom(black,white));
        }

        private static string NotSoRandom(double black, double white)
        {
            return "Black";
        }
    }
}
