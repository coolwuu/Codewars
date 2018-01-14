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

        [TestCase("ant","ant",TestName = "Return_input_when_length_equal_to_3")]
        public void Abbreviate(string expected, string input)
        {
            Assert.AreEqual(expected, _abbreviator.Abbreviate(input));
        }
    }
}
