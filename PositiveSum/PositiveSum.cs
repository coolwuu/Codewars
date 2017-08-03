using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PositiveSum
{
    [TestClass]
    public class PositiveSum
    {
        [TestMethod]
        public void TestMethod1()
        {
            Kata kata = new Kata();
            int[] array = { 1, -2, 3, -1, 0, 1 };
            Assert.AreEqual(5, kata.PositiveSum(array));
        }
    }

    public class Kata
    {
        public int PositiveSum(int[] array)
        {
            var a =
                array.Where(number => number > -1);

            return a.Sum();
        }
    }
}
