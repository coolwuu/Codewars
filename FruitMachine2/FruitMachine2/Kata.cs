using System.Collections.Generic;
using NUnit.Framework;

namespace FruitMachine2
{
    public class Kata
    {
        [Test]
        public void No_matching_items_return_Zero_()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 0, 1, 2 };
            Assert.AreEqual(0, Fruit(reels, spins));
        }


        private static int Fruit(List<string[]> reels,int[] spins)
        {
            return 0;
        }
    }
}
