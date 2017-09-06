using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _0906_Reverse_Rotate
{
    class StringProcesserTest
    {
        [Test]
        public void Size_less_equal_0_return_empty_string()
        {
            Assert.AreEqual("",StringProcesser.RevRot("12345678",0));
        }

        [Test]
        public void Size_less_equal_0_return_empty_string_2()
        {
            Assert.AreEqual("", StringProcesser.RevRot("12345678", -1));
        }

        [Test]
        public void input_1234_with_size_2_return_2143()
        {
            Assert.AreEqual("2143", StringProcesser.RevRot("1234", 2));
        }

        [Test]
        public void input_123456_with_size_2_return_214365()
        {
            Assert.AreEqual("214365", StringProcesser.RevRot("123456", 2));
        }

        [Test]
        public void input_124456_with_size_3_return_321654()
        {
            Assert.AreEqual("241564", StringProcesser.RevRot("124456", 3));
        }

        [Test]
        public void input_123456_with_size_3_return_321654()
        {
            Assert.AreEqual("321564", StringProcesser.RevRot("123456", 3));
        }

        [Test]
        public void input_123456987653_with_size_6_return_234561356789()
        {
            Assert.AreEqual("234561356789", StringProcesser.RevRot("123456987653", 6));
        }

        [Test]
        public void input_664438769_with_size_8_return_67834466()
        {
            Assert.AreEqual("67834466", StringProcesser.RevRot("664438769", 8));
        }

    }
}
