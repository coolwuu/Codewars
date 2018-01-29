using System.Collections.Generic;
using NUnit.Framework;

namespace ArraysOfCatsAndDogs
{
    [TestFixture]
    public class Kata
    {
        private static List<char> _pets = new List<char>();
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
            _pets = pets;
            if (IsAllDog())
                return 0;
            var indexOfCatCaught = new List<int>();

            for (var i = 0; i < _pets.Count; i++)
            {
                if (!IsDog(i)) continue;
                for (var j = i - steps; j <= i + steps; j++)
                {
                    if (!IsWithinArray(j)) continue;
                    if (indexOfCatCaught.Contains(j) || _pets[j] != 'C') continue;
                    indexOfCatCaught.Add(j);
                    break;
                }
            }
            return indexOfCatCaught.Count;
        }

        private static bool IsWithinArray(int j)
        {
            return j >= 0 && j < _pets.Count;
        }

        private static bool IsDog(int index)
        {
            return _pets[index] == 'D';
        }

        private static bool IsAllDog()
        {
            return !_pets.Contains('C');
        }
    }
}
