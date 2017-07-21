using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0_Shouldbe_0()
        {
            Assert.AreEqual("0=0", Kata.ShowSequence(0));
        }
        [TestMethod]
        public void Input_negative_Should_Return_Less_than_0()
        {
            Assert.AreEqual("-15<0", Kata.ShowSequence(-15));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("0+1=1", Kata.ShowSequence(1));
        }
    }

    public class Kata
    {
        public static string ShowSequence(int i)
        {
            
            if (i == 0)
                //return $"{i}=0";
                return  Convert.ToString(i) + "=0";
            if (i <= 0)
                //return $"{i}<0";
                return  Convert.ToString(i) + "<0";

            string result = "";
            int sum = 0;
            for (int j = 0; j <= i; j++)
            {
                sum += j;
                result += j == i ? Convert.ToString(j) + "=" : Convert.ToString(j) + "+";
            }
            result += sum;
            
            return result;
        }
    }
}
