using NUnit.Framework;
using Skork.Language.Util.Parse;

namespace Skork.Language.Util.Tests.Parse.Cleaner
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFTrimUtilityTests
    {
        private char[] _ignorableCharacters;

        public SRFTrimUtilityTests()
        {
            //' ', '\f', '\n', '\r', '\t', '\v'
            _ignorableCharacters = SRFIsStringIgnorableUtility.IgnorableCharacters;
        }

        [TestCase("", " ")]
        [TestCase("", "  ")]
        [TestCase("", "\f")]
        [TestCase("", "\f\f")]
        [TestCase("", "\n")]
        [TestCase("", "\n\n")]
        [TestCase("", "\r")]
        [TestCase("", "\r\r")]
        [TestCase("", "\t")]
        [TestCase("", "\t\t")]
        [TestCase("", "\v")]
        [TestCase("", "\v\v")]
        [TestCase("a", " a")]
        [TestCase("a", "  a")]
        [TestCase("a", "\fa")]
        [TestCase("a", "\f\fa")]
        [TestCase("a", "\na")]
        [TestCase("a", "\n\na")]
        [TestCase("a", "\ra")]
        [TestCase("a", "\r\ra")]
        [TestCase("a", "\ta")]
        [TestCase("a", "\t\ta")]
        [TestCase("a", "\va")]
        [TestCase("a", "\v\va")]
        [TestCase("a", "a ")]
        [TestCase("a", "a  ")]
        [TestCase("a", "a\f")]
        [TestCase("a", "a\f\f")]
        [TestCase("a", "a\n")]
        [TestCase("a", "a\n\n")]
        [TestCase("a", "a\r")]
        [TestCase("a", "a\r\r")]
        [TestCase("a", "a\t")]
        [TestCase("a", "a\t\t")]
        [TestCase("a", "a\v")]
        [TestCase("a", "a\v\v")]
        public void GivenStringShouldTrimLeadingAndTrailingWhitespaceCharacters(string expectedStr, string actualStr)
        {
            actualStr = SRFTrimUtility.TrimLeadingAndTrailingWhitespaces(actualStr);

            StringAssert.AreEqualIgnoringCase(expectedStr, actualStr);
        }

    }
}
