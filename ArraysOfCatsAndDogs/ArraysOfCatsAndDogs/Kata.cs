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
        public void one_dog_one_cat_one_step_should_return_1()
        {
            Assert.AreEqual(1, Solve(new List<char> { 'D', 'C' }, 1));
        }

        [Test]
        public void no_cat_should_return_0()
        {
            Assert.AreEqual(0, Solve(new List<char> { 'D', 'D' }, 0));
        }
        [Test]
        public void one_dog_two_cat_one_step_should_return_1()
        {
            Assert.AreEqual(1, Solve(new List<char> { 'C', 'D', 'C' }, 1));
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(2, Solve(new List<char> { 'C', 'D', 'C', 'D' }, 1));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(3, Solve(new List<char> { 'C', 'C', 'D', 'D', 'C', 'D' }, 2));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(3, Solve(new List<char> { 'D', 'C', 'D', 'C', 'C', 'D' }, 3));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(2, Solve(new List<char> { 'C', 'C', 'D', 'D', 'C', 'D' }, 1));
        }



        private static int Solve(List<char> pets, int steps)
        {
            if (!pets.Contains('C'))
                return 0;
            var indexOfCatCaught = new List<int>();

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i] == 'D')
                {
                    for (var j = i - steps; j <= i + steps; j++)
                    {
                        if (j >= 0 && j < pets.Count)
                        {
                            if (!indexOfCatCaught.Contains(j) && pets[j] == 'C')
                            {
                                indexOfCatCaught.Add(j);
                                break;
                            }

                        }
                    }
                }
            }
            return indexOfCatCaught.Count;
        }
    }
}
