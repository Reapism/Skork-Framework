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
        [TestCase(" ", " ")]
        [TestCase(" ", "  ")]
        [TestCase("a ", "a ")]
        [TestCase("a ", "a  ")]
        [TestCase(" a ", " a ")]
        [TestCase(" a ", " a  ")]
        [TestCase(" a ", "  a ")]
        [TestCase(" a ", "  a  ")]
        [TestCase("\n", "\n  ")]
        [TestCase("\t", "\t  ")]
        [TestCase("\v", "\v  ")] //' ', '\f', '\n', '\r', '\t', '\v'
        [TestCase("\f", "\f  ")]
        [TestCase("\r", "\r  ")]
        [TestCase("foo bar", "foo  bar")]
        [TestCase("foo bar", "foo   bar")]
        [TestCase("foo\tbar", "foo\tbar")]
        [TestCase("foo\vbar", "foo\vbar")]
        [TestCase("foo\fbar", "foo\fbar")]
        [TestCase("foo\rbar", "foo\rbar")]
        [TestCase("foo\nbar", "foo\nbar")]
        [TestCase("foo\tbar", "foo\t\tbar")]
        [TestCase("foo\vbar", "foo\v\vbar")]
        [TestCase("foo\fbar", "foo\f\fbar")]
        [TestCase("foo\rbar", "foo\r\rbar")]
        [TestCase("foo\nbar", "foo\n\nbar")]
        [TestCase(" foo\tbar", "  foo\t\tbar")]
        [TestCase(" foo\vbar", "  foo\v\vbar")]
        [TestCase(" foo\fbar", "  foo\f\fbar")]
        [TestCase(" foo\rbar", "  foo\r\rbar")]
        [TestCase(" foo\nbar", "  foo\n\nbar")]
        [TestCase(" foo\tbar ", "  foo\t\tbar  ")]
        [TestCase(" foo\vbar ", "  foo\v\vbar  ")]
        [TestCase(" foo\fbar ", "  foo\f\fbar  ")]
        [TestCase(" foo\rbar ", "  foo\r\rbar  ")]
        [TestCase(" foo\nbar ", "  foo\n\nbar  ")]
        [TestCase(" foo bar ", "  foo  bar  ")]
        [TestCase(" foo bar ", "  foo \n\n bar  ")]
        [TestCase("foo bar\n", "foo   bar\n\n")]
        public void ShouldReturnExpectedStringWhenActualStringIsPassed(string expectedStr, string actualStr)
        {
            actualStr = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(actualStr);
            StringAssert.AreEqualIgnoringCase(expectedStr, actualStr);
        }

    }
}
