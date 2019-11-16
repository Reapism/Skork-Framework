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
        public void ShouldThrowExceptionGivenNullArgument()
        {
            Assert.Throws<ArgumentNullException>(() =>
                SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(null)
            );
        }

        [TestCase("", "")]
        [TestCase("", "")]
        [TestCase("", "  ")]
        [TestCase("a ", "a  ")]
        [TestCase("a ", "a   ")]
        [TestCase("", "\n  ")]
        [TestCase("", "\t  ")]
        [TestCase("", "\v  ")] //' ', '\f', '\n', '\r', '\t', '\v'
        [TestCase("", "\f  ")]
        [TestCase("", "\r  ")]
        [TestCase("foo bar", "foo  bar")]
        [TestCase("foo bar", "foo   bar")]
        [TestCase("foo bar", "foo\tbar")]
        [TestCase("foo bar", "foo\vbar")]
        [TestCase("foo bar", "foo\fbar")]
        [TestCase("foo bar", "foo\rbar")]
        [TestCase("foo bar", "foo\nbar")]
        public void ShouldThrowExceptionGivenNullArgument(string expectedStr, string actualStr)
        {
            actualStr = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(actualStr);
            StringAssert.AreEqualIgnoringCase(expectedStr, actualStr);
        }

    }
}
