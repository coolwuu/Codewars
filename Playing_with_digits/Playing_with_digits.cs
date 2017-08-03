using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Playing_with_digits
{
    [TestClass]
    public class PlayingWithDigits
    {
        [TestMethod]
        public void input_89_1_should_return_1()
        {
            //arrange 
            //action
            var expected = 1;
            var actual = Digit.digPow(89, 1);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_92_1_should_return_minus_1()
        {
            //arrange 
            //action
            var expected = -1;
            var actual = Digit.digPow(92, 1);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_46288_3_should_return_51()
        {
            //arrange 
            //action
            var expected = 51;
            var actual = Digit.digPow(46288, 3);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Digit
    {
        public static int digPow(int number, int pow)
        {
            string num = number.ToString();
            int total = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int a = int.Parse(num[i].ToString());
                total += (int)Math.Pow(a,pow);
                pow++;
            }
            return total%number == 0? total/number :-1;
        }
    }
}
