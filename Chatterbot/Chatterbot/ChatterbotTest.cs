using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ChatterbotProject
{
    [TestFixture]
    public class ChatterbotTest
    {
        [Test]
        [TestCase("hi", true)]
        [TestCase("hi.", true)]
        [TestCase("hi ", true)]
        [TestCase(" hi", true)]
        [TestCase("hhi", false)]
        [TestCase("h hi", true)]
        [TestCase("I said hi", true)]
        [TestCase("this", false)]
        public void TestChatterbot(string input, bool expectedResult)
        {
            Chatterbot chat = new Chatterbot();
            Assert.AreEqual(expectedResult, chat.Chat(input));
        }

    }
}
