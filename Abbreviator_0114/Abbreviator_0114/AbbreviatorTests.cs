using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Abbreviator_0114
{
    [TestFixture]
    public class AbbreviatorTests
    {
        private readonly Abbreviator _abbreviator = new Abbreviator();

        [TestCase("a","a",TestName = "Return_input_when_length_equal_to_1")]
        [TestCase("an","an",TestName = "Return_input_when_length_equal_to_2")]
        [TestCase("ant","ant",TestName = "Return_input_when_length_equal_to_3")]
        [TestCase("a2s","ants",TestName = "Return_input_when_length_equal_to_4")]
        [TestCase("m3y","money",TestName = "Return_input_when_length_equal_to_5")]
        [TestCase("m3y m4y","money monkey",TestName = "Return input when pass in 2 words")]
        [TestCase("m3y m4y m6s","money monkey memories",TestName = "Return input when pass in 3 words")]
        public void Abbreviate(string expected, string input)
        {
            Assert.AreEqual(expected, _abbreviator.Abbreviate(input));
        }
    }
}
