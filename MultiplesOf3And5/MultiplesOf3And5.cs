using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplesOf3And5
{
    [TestClass]
    public class MultiplesOf3And5
    {
        [TestMethod]
        public void input_0_should_return_0()
        {
            //arrange
            Kata kata = new Kata();

            //action
            var expected = 0;
            var actual = kata.FindMultiples(0);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_1_should_return_0()
        {
            //arrange
            Kata kata = new Kata();

            //action
            var expected = 0;
            var actual = kata.FindMultiples(1);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_4_should_return_3()
        {
            //arrange
            Kata kata = new Kata();

            //action
            var expected = 3;
            var actual = kata.FindMultiples(4);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_10_should_return_23()
        {
            //arrange
            Kata kata = new Kata();

            //action
            var expected = 23;
            var actual = kata.FindMultiples(10);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int FindMultiples(int value)
        {
            if (value != 0)
            {
                int total = 0;
                for (int i = 0; i < value; i++)
                {
                    if (i%3 == 0 || i%5 == 0) total += i;
                }
                return total;
            }
            return 0;
        }
    }
}
