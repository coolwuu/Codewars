﻿using System.Collections.Generic;
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

        private static int Fruit(List<string[]> reels, int[] spins)
        {
            List<string> slotResult = new List<string>();
            for (int i = 0; i < reels.Count; i++)
            {
                slotResult.Add(reels[i][spins[i]]);
            }

            var matchingItem = slotResult
                .GroupBy(r => r)
                .Select(result => new { item = result.Key, count = result.Count() })
                .ToList();
            if (matchingItem[0].count == 3)
                return 10;
            if (TwoSameItemsIn(slotResult))
                return 1;
            return 0;
        }

        private static bool TwoSameItemsIn(List<string> result)
        {
            return result[0] == result[1] || result[1] == result[2] || result[0] == result[2];
        }
    }
}