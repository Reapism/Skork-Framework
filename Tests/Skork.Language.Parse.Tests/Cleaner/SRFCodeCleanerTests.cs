using NUnit.Framework;
using Skork.Language.Parse.Cleaner;
using System;
using System.Collections.Generic;

namespace Skork.Language.Parse.Tests.Cleaner
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFCodeCleanerTests
    {
        private const string ExpectedStr = "int i = 0";
        private const string ExpectedStr2 = "int i=0";

        [TestCase("int i = 0")]
        [TestCase(" int i = 0")]
        [TestCase(" int  i  = 0")]
        [TestCase("int i =  0")]
        [TestCase("  int  i  =  0  ")]
        [TestCase("\tint\ti\t=\t0\t")]
        [TestCase("  \t\n\t\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \r\n\t\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\r\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\t\r   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \n\n\t\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\n\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\t\n   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\n\n   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \n\n\n\n   int  \t\t i \t\n \t = \r\t \n 0")]
        public void ShouldCleanCode_GivenPotentialString_WhenCleaningCodeLine(string actualStr)
        {
            var actual = SRFCodeCleaner.CleanPotentialCodeLine(actualStr);
            StringAssert.AreEqualIgnoringCase(ExpectedStr, actual);
        }

        [Test]
        public void ShouldNotThrowException_GivenEmptyString_WhenCleaningCodeLine()
        {
            Assert.DoesNotThrow(() => SRFCodeCleaner.CleanPotentialCodeLine(""));
        }

        [Test]
        public void ShouldNotThrowException_GivenEmptyString_WhenCleaningCodeLines()
        {
            Assert.DoesNotThrow(() => SRFCodeCleaner.CleanPotentialCodeLines(new List<string> { "" }));
        }

        [Test]
        public void ShouldThrowException_GivenNullString_WhenCleaningCodeLine()
        {
            Assert.Throws<ArgumentException>(() => SRFCodeCleaner.CleanPotentialCodeLine(null));
        }

        [Test]
        public void ShouldThrowException_GivenNullString_WhenCleaningCodeLines()
        {
            Assert.Throws<ArgumentException>(() => SRFCodeCleaner.CleanPotentialCodeLines(null));
        }
    }
}
