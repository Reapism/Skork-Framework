using NUnit.Framework;
using Skork.Language.Util.Parse;
using System;
using System.Collections.Generic;

namespace Skork.Language.Util.Tests.Parse
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFSplitUtilityTests
    {
        private IEnumerable<string> _actualLineStringQueue;
        private IEnumerable<string> _expectedLineStringQueue;

        [SetUp]
        public void Setup()
        {
            _actualLineStringQueue = new Queue<string>(new[] {
                " ; ",
                "",
            });

            _expectedLineStringQueue = new Queue<string>(new[] {
                ";",
                "",
            });
        }

        [Test]
        public void ShouldThrowExceptionGivenNullArgument()
        {
            Assert.Throws<ArgumentNullException>(() => SRFSplitUtility.SplitIgnorableLines(null));
        }
    }
}
