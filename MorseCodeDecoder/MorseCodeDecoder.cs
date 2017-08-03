using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MorseCodeDecoder
{
    [TestClass]
    public class MorseCodeDecoder
    {
        [TestMethod]
        public void input_should_return_A()
        {
            string input = ".-";

            var actual = MDecoder.Decode(input);
            var expected = "A";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_should_return_AB()
        {
            string input = ".- -...";

            var actual = MDecoder.Decode(input);
            var expected = "AB";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_should_return_AB_C()
        {
            string input = ".- -...   -.-.";

            var actual = MDecoder.Decode(input);
            var expected = "AB C";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void input_should_return_HEY_JUDE()
        {
            string input = ".... . -.--   .--- ..- -.. .";

            var actual = MDecoder.Decode(input);
            var expected = "HEY JUDE";

            Assert.AreEqual(expected, actual);
        }
    }

    public class MDecoder
    {
        public static string Decode(string input)
        {
            string[] codeList = input.Trim().Split(' ');
            string result = "";
            var count = 0;
            foreach (var code in codeList)
            {
                if (code != "") result += CodeDictionary[code];
                else
                {
                    count++;
                    if (count == 2)
                    {
                        result += " ";
                        count = 0;
                    }
                }

            }
            return result;
        }

        public static Dictionary<string, string> CodeDictionary = new Dictionary<string, string>()
        {
            {".-","A"},{"-...","B"},{"-.-.","C"},
            {"-..","D"},{".","E"},{"..-.","F"},
            {"--.","G"},{"....","H"},{"..","I"},
            {".---","J"},{"-.-","K"},{".-..","L"},
            {"--","M"},{"-.","N"},{"---","O"},
            {".--.","P"},{"--.-","Q"},{".-.","R"},
            {"...","S"},{"-","T"},
            {"..-","U"},{"...-","V"},
            {".--","W"},{"-..-","X"},
            {"-.--","Y"},{"--..","Z"},{" "," "},
            {".----","1"},{"..---","2"},{"...--","3"},
            {"....-","4"},{".....","5"},{"-....","6"},
            {"--...","7"},{"---..","8"},{"----.","9"},
            {"-----","0"},{"-.-.--","!"},{"...---...","SOS"},{".-.-.-","."}


        };

    }
}
