using System.Collections.Generic;
using NUnit.Framework;

namespace FruitMachine
{
    public class Kata
    {
        [Test]
        public void No_matching_return_Zero_()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 0, 1, 2 };
            Assert.AreEqual(0, Fruit(reels, spins));
        }
        [Test]
        public void Two_of_Jack__return_1()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 9, 9, 4 };
            Assert.AreEqual(1, Fruit(reels, spins));
        }
        [Test]
        public void Three_of_Jack__return_10()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 9, 9, 9 };
            Assert.AreEqual(10, Fruit(reels, spins));
        }

        private static int Fruit(List<string[]> reels, int[] spins)
        {
            int score = 0;
            List<string> result = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                result.Add(reels[i][spins[i]]);
            }

            if (result[0] == result[1] && result[1] == result[2])
                return 10;
            if (result[0] == result[1] || result[1] == result[2])
                return 1;
            return 0;
        }
    }
}
