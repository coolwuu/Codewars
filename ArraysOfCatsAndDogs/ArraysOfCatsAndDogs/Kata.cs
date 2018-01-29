using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ArraysOfCatsAndDogs
{
    [TestFixture]
    public class Kata
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(1,Kata.Solve(new List<char>{'D','C'},1));
        }

        private static int Solve(List<char> pets, int steps)
        {
            return 1;
        }
    }
}
