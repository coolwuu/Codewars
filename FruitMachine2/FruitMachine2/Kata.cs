using System.Collections.Generic;
using System.Linq;
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

        [Test]
        public void Two_of_Jack_return_1()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 9, 9, 4 };
            Assert.AreEqual(1, Fruit(reels, spins));
        }

        [Test]
        public void Three_of_Jack_return_10()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 9, 9, 9 };
            Assert.AreEqual(10, Fruit(reels, spins));
        }

        [Test]
        public void Two_of_Jack_and_WILD_return_2()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 9, 9, 0 };
            Assert.AreEqual(2, Fruit(reels, spins));
        }

        [Test]
        public void Two_of_Wild_return_10()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 0, 9, 0 };
            Assert.AreEqual(10, Fruit(reels, spins));
        }
        [Test]
        public void Three_of_Wild_return_100()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 0, 0, 0 };
            Assert.AreEqual(100, Fruit(reels, spins));
        }


        private static int Fruit(List<string[]> reels, int[] spins)
        {
            List<string> slotResult = new List<string>();
            for (int i = 0; i < reels.Count; i++)
            {
                slotResult.Add(reels[i][spins[i]]);
            }
            var item = GetMatchingItemIn(slotResult);
            return GetScoreBy(item, slotResult);
        }

        private static int GetScoreBy(Item item, List<string> slotResult)
        {
            var bonusRate = 2;
            var scoreMapping = new Dictionary<string, Dictionary<string, int>>()
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
            if (item.Count == 3)
                return scoreMapping[item.Name]["ThreeOfSame"];
            if (item.Count == 2)
            {
                if (item.Name == "Wild")
                    return scoreMapping[item.Name]["TwoOfSame"];
                if (slotResult.Contains("Wild"))
                    return scoreMapping[item.Name]["TwoOfSame"] * bonusRate;
                return scoreMapping[item.Name]["TwoOfSame"];
            }
            return 0;
        }

        private static Item GetMatchingItemIn(List<string> slotResult)
        {
            var result = slotResult
                .GroupBy(r => r)
                .Select(g => new { item = g.Key, count = g.Count() })
                .ToList();
            return new Item(result[0].item, result[0].count);
        }
    }

    internal class Item
    {
        public int Count;
        public string Name;
        public Item(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
}
