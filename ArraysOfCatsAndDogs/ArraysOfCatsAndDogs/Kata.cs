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
        public void one_dog_one_cat_one_step()
        {
            Assert.AreEqual(1,Solve(new List<char>{'D','C'},1));
        }

        [Test]
        public void no_cat_one_step()
        {
            Assert.AreEqual(0,Solve(new List<char>{'D','D'},0));
        }

        private static int Solve(List<char> pets, int steps)
        {
            if (!pets.Contains('C'))
                return 0;
            return 1;
        }
    }
}
