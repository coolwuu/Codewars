using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StopSpinningMyWords
{
    [TestClass]
    public class StopSpinningMyWords
    {
        [TestMethod]
        public void input_empty_should_return_empty()
        {
            SpinResult(string.Empty, string.Empty);
        }
        [TestMethod]
        public void input_ABCD_should_return_ABCD()
        {
            SpinResult("ABCD", "ABCD");
        }

        [TestMethod]
        public void input_ABCDE_should_return_EDCBA()
        {
            SpinResult("ABCDE", "EDCBA");
        }

        [TestMethod]
        public void input_HI_FRIDAY_should_return_HI_YADIRF()
        {
            SpinResult("HI FRIDAY", "HI YADIRF");
        }

        private static void SpinResult(string input, string expected)
        {
            var actual = WordSpinner.Spin(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class WordSpinner
    {
        public static string Spin(string input)
        {
            string[] Sarray = input.Split(' ');
            for (var i = 0; i < Sarray.Length; i++)
                Sarray[i] = ReverseArray(Sarray[i].ToCharArray());
            return string.Join(" ", Sarray);
        }

        private static string ReverseArray(char[] array)
        {

            if (array.Length > 4)
                Array.Reverse(array);
            return new string(array);
        }
    }
}
