using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scratch_lottery_1
{
    [TestClass]
    public class ScratchLottery1
    {
        [TestMethod]
        public void _Input_1_win_lottery_return_100()
        {
            //arrange 
            string[] lotterys = { "tiger tiger tiger 100" };

            //action
            var actual = Lottery.Scratch(lotterys);
            var expected = 100;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Lottery
    {
        public static object Scratch(string[] lotterys)
        {
            int prize = 0;
            foreach (var lottery in lotterys)
            {
                var result = lottery.Split(' ');
                bool equal = false;
                for (int i = 0; i < 2; i++)
                {
                    equal = result[i] == result[i + 1];
                    if (!equal) break;
                }
                prize += equal ? Convert.ToInt32(result[3]) : 0;

            }
            return prize;
        }
    }
}
