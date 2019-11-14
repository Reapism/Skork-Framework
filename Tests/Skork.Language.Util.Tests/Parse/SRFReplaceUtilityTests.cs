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
        [TestCase(@"int\i\=\\0\;\", "int  i  =  0  ;")]
        [TestCase(@"int i = 0 ;", "int   i   =   0   ;")]
        [TestCase(@"int i = 0 ;", "int\ti\t=\t0\t;")]
        [TestCase(@"int i = 0 ;", "int\vi\v=\v0\v;")]
        [TestCase(@"int i = 0 ;", "int\fi\f=\f0\f;")]
        [TestCase(@"int i = 0 ;", "int\ri\r=\r0\r;")]
        [TestCase(@"int i = 0 ;", "int\ni\n=\n0\n;")]
        [TestCase(@"int i = 0 ;", "int\t i\t =\t 0\t ;")]
        [TestCase(@"int i = 0 ;", "int\v i\v =\v 0\v ;")]
        [TestCase(@"int i = 0 ;", "int\f i\f =\f 0\f ;")]
        [TestCase(@"int i = 0 ;", "int\r i\r =\r 0\r ;")]
        [TestCase(@"int i = 0 ;", "int\n i\n =\n 0\n ;")]
        [TestCase(@"int i = 0 ;", " int\ti\t=\t0\t; ")]
        [TestCase(@"int i = 0 ;", " int\vi\v=\v0\v; ")]
        [TestCase(@"int i = 0 ;", " int\fi\f=\f0\f; ")]
        [TestCase(@"int i = 0 ;", " int\ri\r=\r0\r; ")]
        [TestCase(@"int i = 0 ;", " int\ni\n=\n0\n; ")]
        [TestCase(@"int i = 0 ;", "  int\ti\t=\t0\t;  ")]
        [TestCase("int i = 0 ;", "  int\vi\v=\v0\v;  ")]
        [TestCase("int i = 0 ;", "  int\fi\f=\f0\f;  ")]
        [TestCase("int i = 0 ;", "  int\ri\r=\r0\r;  ")]
        [TestCase("int i = 0 ;", "  int\ni\n=\n0\n;  ")]
        public void ShouldThrowExceptionGivenNullArgument(string expectedStr, string actualStr)
        {
            actualStr = SRFReplaceUtility.ReplaceMultipleWhitespacesWithSingleSpace(actualStr);
            StringAssert.AreEqualIgnoringCase(expectedStr, actualStr);
        }

    }
}
