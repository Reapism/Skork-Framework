using NUnit.Framework;
using Skork.Language.Util.Parse;
using System;

namespace Skork.Language.Util.Tests.Parse
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
        [TestCase("a", 'a')]
        [TestCase("aa", 'a')]
        [TestCase(";", ';')]
        [TestCase(";;", ';')]
        [TestCase("\n", '\n')]
        [TestCase("\n\n", '\n')]
        [TestCase("\r", '\r')]
        [TestCase("\r\r", '\r')]
        [TestCase("\\", '\\')]
        [TestCase("\\\\", '\\')]
        [TestCase("\"", '\"')]
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
        public void ShouldReturnFalseGivenStringsAndCharacters(string strValue, char charValue)
        {
            Assert.IsFalse(SRFContainsUtility.ContainsOnly(strValue, charValue));
        }
    }
}
