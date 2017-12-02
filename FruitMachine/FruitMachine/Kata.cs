using System.Collections.Generic;
using NUnit.Framework;

namespace FruitMachine
{
    public class Kata
    {
        [Test]
        public void No_matching_return_Zero()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 0, 1, 2 };
            Assert.AreEqual(0, Fruit(reels, spins));
        }

        private static int Fruit(List<string[]> reels, int[] spins)
        {
            return 0;
        }
    }
}
