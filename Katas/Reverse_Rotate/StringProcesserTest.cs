﻿using System;
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
    }
}
