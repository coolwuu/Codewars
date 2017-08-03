using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TowerBuilderBasic
{
    [TestClass]
    public class TowerBuilderBasic
    {
        [TestMethod]
        public void input_one_return()
        {
            //arrange
            TowerBuilder tb = new TowerBuilder();
            var expected = new[] { "*" };

            //action
            var actual = tb.Builder(1);

            //assert
            //Assert.AreEqual(expected,actual);
            CollectionAssert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void input_2_return()
        {
            //arrange
            TowerBuilder tb = new TowerBuilder();
            var expected = new[] { " * ", "***" };

            //action
            var actual = tb.Builder(2);

            //assert
            //Assert.AreEqual(expected,actual);
            CollectionAssert.AreEqual(expected, actual);

        }
    }



    internal class TowerBuilder
    {
        public string[] Builder(int nFloors)
        {
            string[] result = new string[nFloors];

            for (int j = 1; j <= nFloors; j++)
            {
                for (int i = j; i <= nFloors-1; i++)
                    result[j-1] += " ";

                for (int k = 1; k <= j * 2 - 1; k++)
                    result[j-1] += "*";

                for (int i = j; i <= nFloors-1; i++)
                    result[j-1] += " ";
            }
            return result;
        }
    }
}
