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

        [Test]
        public void Abbreviate()
        {
            Assert.AreEqual("ant", _abbreviator.Abbreviate("ant"));
        }
    }
}
