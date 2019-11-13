using NUnit.Framework;
using Skork.Language.Util.Parse;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Skork.Language.Util.Tests.Parse
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFSplitUtilityTests
    {
        private Queue<string> _actualLineStringQueue;
        private Queue<string> _expectedLineStringQueue;

        [SetUp]
        public void Setup()
        {
            _actualLineStringQueue = new Queue<string>(new[] {
                " ",
                "\f",
                "\n",
                "\r",
                "\t",
                "\v",
                "\f\f",
                "\n\n",
                "\r\r",
                "\t\t",
                "\v\v",
            });
            // ' ', '\f', '\n', '\r', '\t', '\v'
            _expectedLineStringQueue = new Queue<string>(new[] {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
            });
        }

        [Test]
        public void ShouldSplitLinesGivenQueues()
        {
            _actualLineStringQueue = SRFSplitUtility.SplitIgnorableLines(_actualLineStringQueue);
            
            for (int i = 0; i < _actualLineStringQueue.Count; i++)
            {
                Assert.AreEqual(_expectedLineStringQueue.Dequeue(), _actualLineStringQueue.Dequeue());
            }

        }

        [Test]
        public void ShouldThrowExceptionGivenNullArgument()
        {
            Assert.Throws<ArgumentNullException>(() => SRFSplitUtility.SplitIgnorableLines(null));
        }
    }
}
