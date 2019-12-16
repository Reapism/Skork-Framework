using NUnit.Framework;
using Skork.Language.Util.Parse;
using System;

namespace Skork.Language.Util.Tests.Parse.Cleaner
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFContainsUtilityTests
    {
        [Test]
        public void ShouldThrowExceptionWhenNullStringIsPassed()
        {
            Assert.Throws<ArgumentNullException>(() => SRFContainsUtility.ContainsOnly(null, ' '));
        }

        [Test]
        public void ShouldThrowExceptionWhenEmptyStringIsPassed()
        {
            Assert.Throws<ArgumentNullException>(() => SRFContainsUtility.ContainsOnly("", ' '));
        }

        [TestCase(" ", ' ')]
        [TestCase("  ", ' ')]
        [TestCase("\f", '\f')]
        [TestCase("\f\f", '\f')]
        [TestCase("\n", '\n')]
        [TestCase("\n\n", '\n')]
        [TestCase("\r", '\r')]
        [TestCase("\r\r", '\r')]
        [TestCase("\t", '\t')]
        [TestCase("\t\t", '\t')]
        [TestCase("\v", '\v')]
        [TestCase("\v\v", '\v')]
        [TestCase("\u0000", '\u0000')]
        [TestCase("\u0000\u0000", '\u0000')]
        [TestCase("a", 'a')]
        [TestCase("aa", 'a')]
        [TestCase(";", ';')]
        [TestCase(";;", ';')]
        [TestCase("\\", '\\')]
        [TestCase("\\\\", '\\')]
        [TestCase("\"", '\"')]
        [TestCase("\'", '\'')]
        public void ShouldReturnTrueGivenStringsAndCharacters(string strValue, char charValue)
        {
            Assert.IsTrue(SRFContainsUtility.ContainsOnly(strValue, charValue));
        }

        [TestCase(";  ", ' ')]
        [TestCase("   ;", ' ')]
        [TestCase(";  ", ';')]
        [TestCase("   ;", ';')]
        [TestCase("; ;", ';')]
        [TestCase("a ", 'a')]
        [TestCase(" aa", 'a')]
        [TestCase("a ", ' ')]
        [TestCase(" aa", ' ')]
        [TestCase("; ", ';')]
        [TestCase(";; ", ';')]
        [TestCase(" ;", ' ')]
        [TestCase("  ;", ' ')]
        [TestCase(" \n", ' ')]
        [TestCase("\n ", ' ')]
        [TestCase("  \n", ' ')]
        [TestCase("\n\n ", ' ')]
        [TestCase(" \n\n ", ' ')]
        [TestCase(" \n", '\n')]
        [TestCase("\n ", '\n')]
        [TestCase("  \n", '\n')]
        [TestCase("\n\n ", '\n')]
        [TestCase(" \n\n ", '\n')]
        [TestCase(" \r", ' ')]
        [TestCase("\r ", ' ')]
        [TestCase("  \r", ' ')]
        [TestCase("\r\r ", ' ')]
        [TestCase(" \r\r ", ' ')]
        [TestCase(" \r", '\r')]
        [TestCase("\r ", '\r')]
        [TestCase("  \r", '\r')]
        [TestCase("\r\r ", '\r')]
        [TestCase(" \r\r ", '\r')]
        [TestCase("\\ ", '\\')]
        [TestCase("\\\\ ", '\\')]
        [TestCase(" \\", '\\')]
        [TestCase(" \\\\", '\\')]
        [TestCase(" \"", '\"')]
        [TestCase("\" ", '\"')]
        [TestCase(" \f", ' ')]
        [TestCase(" \f", '\f')]
        [TestCase(" \n", ' ')]
        [TestCase(" \n", '\n')]
        [TestCase(" \r", ' ')]
        [TestCase(" \r", '\r')]
        [TestCase(" \t", ' ')]
        [TestCase(" \t", '\t')]
        [TestCase(" \v", ' ')]
        [TestCase(" \v", '\v')]
        [TestCase("\f\n", '\f')]
        [TestCase("\f\n", '\n')]
        [TestCase("\f\r", '\f')]
        [TestCase("\f\r", '\r')]
        [TestCase("\f\t", '\f')]
        [TestCase("\f\t", '\t')]
        [TestCase("\f\v", '\f')]
        [TestCase("\f\v", '\v')]
        [TestCase("\n\f", '\n')]
        [TestCase("\n\f", '\f')]
        [TestCase("\n\r", '\n')]
        [TestCase("\n\r", '\r')]
        [TestCase("\n\t", '\n')]
        [TestCase("\n\t", '\t')]
        [TestCase("\n\v", '\n')]
        [TestCase("\n\v", '\v')]
        [TestCase("\r\f", '\r')]
        [TestCase("\r\f", '\f')]
        [TestCase("\r\n", '\r')]
        [TestCase("\r\n", '\n')]
        [TestCase("\r\t", '\r')]
        [TestCase("\r\t", '\t')]
        [TestCase("\r\v", '\r')]
        [TestCase("\r\v", '\v')]
        [TestCase("\t\f", '\t')]
        [TestCase("\t\f", '\f')]
        [TestCase("\t\n", '\t')]
        [TestCase("\t\n", '\n')]
        [TestCase("\t\r", '\t')]
        [TestCase("\t\r", '\r')]
        [TestCase("\t\v", '\t')]
        [TestCase("\t\v", '\v')]
        [TestCase("\v\f", '\v')]
        [TestCase("\v\f", '\f')]
        [TestCase("\v\n", '\v')]
        [TestCase("\v\n", '\n')]
        [TestCase("\v\r", '\v')]
        [TestCase("\v\r", '\r')]
        [TestCase("\v\t", '\v')]
        [TestCase("\v\t", '\t')]
        public void ShouldReturnFalseGivenStringsAndCharacters(string strValue, char charValue)
        {
            Assert.IsFalse(SRFContainsUtility.ContainsOnly(strValue, charValue));
        }
    }
}
