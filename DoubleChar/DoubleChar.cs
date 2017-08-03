using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoubleChar
{
    [TestClass]
    public class DoubleChar
    {
        [TestMethod]
        public void _1_should_return_11()
        {
            GetValue("11","1");
        }

        private static void GetValue(string expected,string input)
        {
            var kata = new Kata();
            var actual = kata.DoubleChar(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _1a_should_return_11aa()
        {
            GetValue("11aa", "1a");
        }
    }

    public class Kata
    {
        public string DoubleChar(string input)
        {
            string result = "";
            foreach (char cha in input)
            {
                result += cha.ToString() + cha.ToString();
            }
            return result;
        }
    }
}
