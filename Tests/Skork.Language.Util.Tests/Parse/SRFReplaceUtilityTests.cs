using NUnit.Framework;
using Skork.Language.Util.Parse;
using System;

namespace Skork.Language.Util.Tests.Parse
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFReplaceUtilityTests
    {
        [Test]
        public void ShouldThrowExceptionWhenReplaceMultipleWhitespacesWithSingleWhitespaceGivenNullArgument()
        {
            Assert.Throws<ArgumentNullException>(() =>
                SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleWhitespace(null)
            );
        }

        [Test]
        public void ShouldThrowExceptionWhenReplaceSingleWhitespacesWithSingleSpaceGivenNullArgument()
        {
            Assert.Throws<ArgumentNullException>(() =>
                SRFReplaceUtility.ReplaceSingleWhitespacesWithSingleSpaces(null)
            );
        }

        [TestCase("", "")]
        [TestCase(" ", " ")]
        [TestCase(" ", "  ")]
        [TestCase("a ", "a ")]
        [TestCase("a ", "a  ")]
        [TestCase(" a ", " a ")]
        [TestCase(" a ", " a  ")]
        [TestCase(" a ", "  a ")]
        [TestCase(" a ", "  a  ")]
        [TestCase("\n ", "\n  ")]
        [TestCase("\t ", "\t  ")]
        [TestCase("\v ", "\v  ")] //' ', '\f', '\n', '\r', '\t', '\v'
        [TestCase("\f ", "\f  ")]
        [TestCase("\r ", "\r  ")]
        [TestCase("\n ", "\n\n  ")]
        [TestCase("\t ", "\t\t  ")]
        [TestCase("\v ", "\v\v  ")] 
        [TestCase("\f ", "\f\f  ")]
        [TestCase("\r ", "\r\r  ")]
        public void ShouldReplaceMultipleWhitespacesWithSingleWhitespaceWhenActualStringIsPassed(string expectedStr, string actualStr)
        {
            actualStr = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleWhitespace(actualStr);
            StringAssert.AreEqualIgnoringCase(expectedStr, actualStr);
        }

        [TestCase("", "")]
        [TestCase(@"\", " ")]
        [TestCase(@"\\", "  ")]
        [TestCase(@"\int\", " int ")]
        [TestCase(@"\int\i\", " int i ")]
        [TestCase(@"\int\i\=\", " int i = ")]
        [TestCase(@"\int\i\=\3\", " int i = 3 ")]
        [TestCase(@"\int\i\=\3;", " int i = 3;")]
        public void ShouldReplaceSpacesWithBackslashesWhenActualStringIsPassed(string expectedStr, string actualStr)
        {
            actualStr = SRFReplaceUtility.ReplaceSpacesWithBackslashes(actualStr);
            StringAssert.AreEqualIgnoringCase(expectedStr, actualStr);
        }

    }
}
