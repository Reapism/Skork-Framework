using NUnit.Framework;
using Skork.Language.Parse.Cleaner;

namespace Skork.Language.Parse.Tests.Cleaner
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFCodeCleanerTests
    {
        private const string ExpectedStr = "int i = 0";
        private const string ExpectedStr2 = "int i=0";

        [SetUp]
        public void SetUp()
        {

        }

        [TestCase("int i = 0")]
        [TestCase(" int i = 0")]
        [TestCase(" int  i  = 0")]
        [TestCase("int i =  0")]
        [TestCase("  int  i  =  0  ")]
        [TestCase("\tint\ti\t=\t0\t")]
        [TestCase("  \t\n\t\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \r\n\t\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\r\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\t\r   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \n\n\t\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\n\t   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\t\n   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \t\n\n\n   int  \t\t i \t\n \t = \r\t \n 0")]
        [TestCase("  \n\n\n\n   int  \t\t i \t\n \t = \r\t \n 0")]
        public void GivenCodeSampleWhenCleaningCodeShouldCleanCode(string actualStr)
        {
            var actual = SRFCodeCleaner.CleanPotentialCodeLine(actualStr);
            StringAssert.AreEqualIgnoringCase(ExpectedStr, actual);
        }
    }
}
