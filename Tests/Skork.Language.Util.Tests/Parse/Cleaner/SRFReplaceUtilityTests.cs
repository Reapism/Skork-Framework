using NUnit.Framework;
using Skork.Language.Util.Parse;
using System;

namespace Skork.Language.Util.Tests.Parse.Cleaner
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
        [TestCase(" ", "\n")]
        [TestCase(" ", "\t")]
        [TestCase(" ", "\v")]
        [TestCase(" ", "\f")]
        [TestCase(" ", "\r")]
        [TestCase(" ", "\n  ")]
        [TestCase(" ", "\t  ")]
        [TestCase(" ", "\v  ")]
        [TestCase(" ", "\f  ")]
        [TestCase(" ", "\r  ")]
        [TestCase(" ", "\n\n  ")]
        [TestCase(" ", "\t\t  ")]
        [TestCase(" ", "\v\v  ")]
        [TestCase(" ", "\f\f  ")]
        [TestCase(" ", "\r\r  ")]
        [TestCase("int i = 0", "int\ni\n=\n0")]
        [TestCase("int i = 0", "int\ti\t=\t0")]
        [TestCase("int i = 0", "int\vi\v=\v0")]
        [TestCase("int i = 0", "int\fi\f=\f0")]
        [TestCase("int i = 0", "int\ri\r=\r0")]
        [TestCase("int i = 0", "int\n\ri\n=\n0")]
        [TestCase("int i = 0", "int\t\ri\t=\t0")]
        [TestCase("int i = 0", "int\v\ri\v=\v0")]
        [TestCase("int i = 0", "int\f\ri\f=\f0")]
        [TestCase("int i = 0", "int\r\ni\r=\r0")]
        public void ShouldReplaceMultipleWhitespacesWithSingleSpaceWhenActualStringIsPassed(string expectedStr, string actualStr)
        {
            actualStr = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(actualStr);
            StringAssert.AreEqualIgnoringCase(expectedStr, actualStr);
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
        [TestCase("\n", "\n")]
        [TestCase("\t", "\t")]
        [TestCase("\v", "\v")]
        [TestCase("\f", "\f")]
        [TestCase("\r", "\r")]
        [TestCase("\n", "\n  ")]
        [TestCase("\t", "\t  ")]
        [TestCase("\v", "\v  ")]
        [TestCase("\f", "\f  ")]
        [TestCase("\r", "\r  ")]
        [TestCase("\n", "\n\n  ")]
        [TestCase("\t", "\t\t  ")]
        [TestCase("\v", "\v\v  ")]
        [TestCase("\f", "\f\f  ")]
        [TestCase("\r", "\r\r  ")]
        [TestCase("int\ni\n=\n0", "int\ni\n=\n0")]
        [TestCase("int\ti\t=\t0", "int\ti\t=\t0")]
        [TestCase("int\vi\v=\v0", "int\vi\v=\v0")]
        [TestCase("int\fi\f=\f0", "int\fi\f=\f0")]
        [TestCase("int\ri\r=\r0", "int\ri\r=\r0")]
        [TestCase("int\ni\n=\n0", "int\n\ri\n=\n0")]
        [TestCase("int\ti\t=\t0", "int\t\ri\t=\t0")]
        [TestCase("int\vi\v=\v0", "int\v\ri\v=\v0")]
        [TestCase("int\fi\f=\f0", "int\f\ri\f=\f0")]
        [TestCase("int\ri\r=\r0", "int\r\ni\r=\r0")]
        public void ShouldReplaceMultipleWhitespacesWithSingleWhiteSpaceWhenActualStringIsPassed(string expectedStr, string actualStr)
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
