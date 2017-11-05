using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WhoLikeIts
{
    public static class Kata
    {
        [Test]
        public static void Empty_input_should_return_correct_text()
        {
            Assert.AreEqual("no one likes this", Likes(new string[0]));
        }

        [Test]
        public static void Input_1_name_should_return_correct_text()
        {
            Assert.AreEqual("Peter likes this", Likes(new[] { "Peter" }));
        }

        [Test]
        public static void Input_2_name_should_return_correct_text()
        {
            Assert.AreEqual("Jacob and Alex like this", Likes(new[] { "Jacob", "Alex" }));
        }

        [Test]
        public static void Input_3_name_should_return_correct_text()
        {
            Assert.AreEqual("Max, John and Mark like this", Likes(new[] { "Max", "John","Mark" }));
        }

        [Test]
        public static void Input_4_name_should_return_correct_text()
        {
            Assert.AreEqual("Alex, Jacob and 2 others like this", Likes(new[] { "Alex", "Jacob", "Mark", "Max" }));
        }

        private static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            return $"{name[0]}, {name[1]} and {name.Length-2} others like this";

        }
    }
}
