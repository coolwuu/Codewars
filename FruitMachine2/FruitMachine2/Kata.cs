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

        [Test]
        public void Two_of_Jack_and_WILD_return_2()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = { 9, 9, 0 };
            Assert.AreEqual(2, Fruit(reels, spins));
        }


        private static int Fruit(List<string[]> reels, int[] spins)
        {
            List<string> slotResult = new List<string>();
            for (int i = 0; i < reels.Count; i++)
            {
                slotResult.Add(reels[i][spins[i]]);
            }

            var matchingItem = GetMatchingItemBy(slotResult);
            if (matchingItem.Count == 3)
                return 10;
            if (matchingItem.Count == 2)
                return 1;
            return 0;
        }

        private static Item GetMatchingItemBy(List<string> slotResult)
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
