using NUnit.Framework;
using Skork.Language.Util.Parse;
using System;

namespace Skork.Language.Util.Tests.Parse.Cleaner
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFSplitUtilityTests
    {
        [TestCase("", " ")]
        [TestCase("", "\f")]
        [TestCase("", "\n")]
        [TestCase("", "\r")]
        [TestCase("", "\t")]
        [TestCase("", "\v")]
        [TestCase("", "  ")]
        [TestCase("", "\f\f")]
        [TestCase("", "\n\n")]
        [TestCase("", "\r\r")]
        [TestCase("", "\t\t")]
        [TestCase("", "\v\v")]
        [TestCase("", " ")]
        [TestCase("", "\f\t")]
        [TestCase("", "\n\t")]
        [TestCase("", "\r\t")]
        [TestCase("", "\t\r")]
        [TestCase("", "\v\t")]
        [TestCase("", "  ")]
        [TestCase("", "\f\f ")]
        [TestCase("", "\n\n ")]
        [TestCase("", "\r\r ")]
        [TestCase("", "\t\t ")]
        [TestCase("", "\v\v ")]
        public void ShouldIgnoreLineForSplitGivenStrings(string expectedStr, string actualStr)
        {
            actualStr = SRFSplitUtility.GetNonIgnorableLine(actualStr);
            StringAssert.AreEqualIgnoringCase(expectedStr, actualStr);
        }

        [TestCase(" a")]
        [TestCase("\fa")]
        [TestCase("\na")]
        [TestCase("\ra")]
        [TestCase("\ta")]
        [TestCase("\va")]
        [TestCase("  a")]
        [TestCase("\f\fa")]
        [TestCase("\n\na")]
        [TestCase("\r\ra")]
        [TestCase("\t\ta")]
        [TestCase("\v\va")]
        [TestCase("a ")]
        [TestCase("a\f\t")]
        [TestCase("a\n\t")]
        [TestCase("a\r\t")]
        [TestCase("a\t\r")]
        [TestCase("a\v\t")]
        [TestCase("a  ")]
        [TestCase("a\f\f ")]
        [TestCase("a\n\n ")]
        [TestCase("a\r\r ")]
        [TestCase("a\t\t ")]
        [TestCase("a\v\v ")]
        public void ShouldNotIgnoreLineForSplitGivenExpectedString(string expectedStr)
        {
            var actualStr = SRFSplitUtility.GetNonIgnorableLine(expectedStr);
            StringAssert.AreEqualIgnoringCase(expectedStr, actualStr);
        }

        [Test]
        public void ShouldThrowExceptionGivenNullArgument()
        {
            Assert.Throws<ArgumentNullException>(() => SRFSplitUtility.GetNonIgnorableLine(null));
        }

        [Test]
        public void ShouldThrowExceptionGivenEmptyStringArgument()
        {
            Assert.Throws<ArgumentNullException>(() => SRFSplitUtility.GetNonIgnorableLine(string.Empty));
        }
    }
}
