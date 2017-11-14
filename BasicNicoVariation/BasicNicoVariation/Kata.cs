using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace BasicNicoVariation
{
    [TestFixture]
    public class Kata
    {

        [Test]
        public void A()
        {
            Assert.AreEqual("eky", Nico("key", "key"));
        }

        [Test]
        public void B()
        {
            Assert.AreEqual("cseerntiofarmit on  ", Nico("crazy", "secretinformation"));
        }
        [Test]
        public void C()
        {
            Assert.AreEqual("2143658709", Nico("ba", "1234567890"));
        }
        [Test]
        public void D()
        {
            Assert.AreEqual("b4ef39xtbt3us         g   ", Nico("w2zicjkr8hfxy", "tbs9extb43f3ug"));
        }

        public static string Nico(string unsortedKey, string message)
        {
            var sortedKey = unsortedKey.Select(e => string.Concat(unsortedKey.OrderBy(x => x)).IndexOf(e)).ToArray();
            message = message.PadRight((int)Math.Ceiling((double)message.Length / unsortedKey.Length) * unsortedKey.Length);
            var messageArray = message.ToCharArray();
            var messageDictionary = new SortedDictionary<int, Queue<char>>();

            for (var i = 0; i < messageArray.Length; i++)
            {
                var j = i % sortedKey.Length;
                if (!messageDictionary.ContainsKey(sortedKey[j]))
                    messageDictionary[sortedKey[j]] = new Queue<char>();
                messageDictionary[sortedKey[j]].Enqueue(messageArray[i]);
            }

            var result = string.Empty;
            for (var i = 0; i < message.Length; i++)
            {
                var j = i % sortedKey.Length;
                result += messageDictionary[j].Dequeue();
            }

            return result;
        }

    }
}
