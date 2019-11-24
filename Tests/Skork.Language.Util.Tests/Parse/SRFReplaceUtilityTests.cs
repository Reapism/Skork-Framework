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
        public void ShouldThrowExceptionWhenReplaceMultipleWhitespacesWithSingleSpaceGivenNullArgument()
        {
            Assert.Throws<ArgumentNullException>(() =>
                SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(null)
            );
        }

        [Test]
        public void ShouldThrowExceptionWhenReplaceSingleWhitespacesWithSingleSpaceGivenNullArgument()
        {
            Assert.Throws<ArgumentNullException>(() =>
                SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(null)
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
        [TestCase(" ", "\n  ")]
        [TestCase(" ", "\t  ")]
        [TestCase(" ", "\v  ")] //' ', '\f', '\n', '\r', '\t', '\v'
        [TestCase(" ", "\f  ")]
        [TestCase(" ", "\r  ")]
        [TestCase(" ", "\n\n  ")]
        [TestCase(" ", "\t\t  ")]
        [TestCase(" ", "\v\v  ")]
        [TestCase(" ", "\f\f  ")]
        [TestCase(" ", "\r\r  ")]
        public void ShouldReplaceMultipleWhitespacesWithSingleSpaceWhenActualStringIsPassed(string expectedStr, string actualStr)
        {
            actualStr = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(actualStr);
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
