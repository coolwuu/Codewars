using System;
using System.Collections.Generic;
using System.Linq;
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
            Assert.AreEqual(0, fruit(reels, spins));
        }
        [Test]
        public void Two_of_Jack__return_1()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 9, 9, 4 };
            Assert.AreEqual(1, fruit(reels, spins));
        }
        [Test]
        public void Three_of_Jack__return_10()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 9, 9, 9 };
            Assert.AreEqual(10, fruit(reels, spins));
        }
        [Test]
        public void Two_of_Jack_and_WILD_return_2()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 9, 9, 0 };
            Assert.AreEqual(2, fruit(reels, spins));
        }

        private static int fruit(List<string[]> reels, int[] spins)
        {
            var ScoreMapping = new Dictionary<string, Dictionary<string, int>>()
            {
                { "Wild", new Dictionary<string, int> { { "ThreeOfSame", 100 }, { "TwoOfSame", 10 } } },
                { "Star", new Dictionary<string, int> { { "ThreeOfSame", 90 }, { "TwoOfSame", 9 } } },
                { "Bell", new Dictionary<string, int> { { "ThreeOfSame", 80 }, { "TwoOfSame", 8 } } },
                { "Shell", new Dictionary<string, int> { { "ThreeOfSame", 70 }, { "TwoOfSame", 7 } } },
                { "Seven", new Dictionary<string, int> { { "ThreeOfSame", 60 }, { "TwoOfSame", 6 } } },
                { "Cherry", new Dictionary<string, int> { { "ThreeOfSame", 50 }, { "TwoOfSame", 5 } } },
                { "Bar", new Dictionary<string, int> { { "ThreeOfSame", 40 }, { "TwoOfSame", 4 } } },
                { "King", new Dictionary<string, int> { { "ThreeOfSame", 30 }, { "TwoOfSame", 3 } } },
                { "Queen", new Dictionary<string, int> { { "ThreeOfSame", 20 }, { "TwoOfSame", 2 } } },
                { "Jack", new Dictionary<string, int> { { "ThreeOfSame", 10 }, { "TwoOfSame", 1 } } },
            };

            List<string> result = new List<string>();
            for (int i = 0; i < reels.Count; i++)
            {
                result.Add(reels[i][spins[i]]);
            }

            if (IsThreeOfTheSame(result))
                return ScoreMapping[result[0]]["ThreeOfSame"];
            if (IsTwoOfTheSame(result))
            {
                var item = GetMatchingItemBy(result);
                if(item == "Wild")
                    return ScoreMapping[item]["TwoOfSame"];
                if (result.Contains("Wild"))
                    return ScoreMapping[item]["TwoOfSame"] * 2;
                return ScoreMapping[item]["TwoOfSame"];
            }
            return 0;
        }

        private static string GetMatchingItemBy(List<string> input)
        {
            var result =  input
                .GroupBy(x => x)
                .Select(r => new { item = r.Key, count = r.Count() })
                .Where(g => g.count == 2)
                .ToList();
            return result[0].item;
        }

        private static bool IsTwoOfTheSame(List<string> result)
        {
            return result[0] == result[1] || result[1] == result[2] || result[0] == result[2];
        }

        private static bool IsThreeOfTheSame(List<string> result)
        {
            return result[0] == result[1] && result[1] == result[2];
        }
    }
}
