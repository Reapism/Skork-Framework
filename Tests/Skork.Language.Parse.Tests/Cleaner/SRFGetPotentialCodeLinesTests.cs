using NUnit.Framework;
using Skork.Language.Parse.Cleaner;

namespace Skork.Language.Parse.Tests.Cleaner
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFGetPotentialCodeLinesTests
    {
        private const string ExpectedStrSemiColon = "int i = 0;";
        private const string ExpectedStrOpenCurlyBrace = "loop() {";

        [TestCase("")]
        public void ShouldReturnFalse_GivenString_WhenInvokingIsCodeBlock(string actualStr)
        {
            SRFGetPotentialCodeLines.GetPotentialCodeStatements(null);
        }

        [TestCase("")]
        public void ShouldReturnTrue_GivenString_WhenInvokingIsCodeBlock(string actualStr)
        {

        }
    }
}
