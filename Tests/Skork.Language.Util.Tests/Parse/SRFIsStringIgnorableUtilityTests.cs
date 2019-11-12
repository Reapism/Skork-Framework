using NUnit.Framework;
using Skork.Language.Util.Parse;

namespace Skork.Language.Util.Tests.Parse
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFIsStringIgnorableUtilityTests
    {
        [TestCase(" ")]
        [TestCase("\f")]
        [TestCase("\n")]
        [TestCase("\r")]
        [TestCase("\t")]
        [TestCase("\v")]
        [TestCase("  ")]
        [TestCase("\f\f")]
        [TestCase("\n\n")]
        [TestCase("\r\r")]
        [TestCase("\t\t")]
        [TestCase("\v\v")]
        [TestCase(" \f")]
        [TestCase(" \n")]
        [TestCase(" \r")]
        [TestCase(" \t")]
        [TestCase(" \v")]
        [TestCase("  \f")]
        [TestCase("  \n")]
        [TestCase("  \r")]
        [TestCase("  \t")]
        [TestCase("  \v")]
        [TestCase("\f\f ")]
        [TestCase("\n\n ")]
        [TestCase("\r\r ")]
        [TestCase("\t\t ")]
        [TestCase("\v\v ")]
        [TestCase("\f \f")]
        [TestCase("\n \n")]
        [TestCase("\r \r")]
        [TestCase("\t \t")]
        [TestCase("\v \v")]
        [TestCase(" \f\f")]
        [TestCase(" \n\n")]
        [TestCase(" \r\r")]
        [TestCase(" \t\t")]
        [TestCase(" \v\v")]
        public void ShouldReturnTrueGivenIgnorableString(string strValue)
        {
            Assert.IsTrue(
                SRFIsStringIgnorableUtility.IsStringIgnorable(strValue)
            );
        }

        [TestCase(" ;")]
        [TestCase("\f;")]
        [TestCase("\n;")]
        [TestCase("\r;")]
        [TestCase("\t;")]
        [TestCase("\v;")]
        [TestCase("  ;")]
        [TestCase("\f\f;")]
        [TestCase("\n\n;")]
        [TestCase("\r\r;")]
        [TestCase("\t\t;")]
        [TestCase("\v\v;")]
        [TestCase(" \f;")]
        [TestCase(" \n;")]
        [TestCase(" \r;")]
        [TestCase(" \t;")]
        [TestCase(" \v;")]
        [TestCase("  \f;")]
        [TestCase("  \n;")]
        [TestCase("  \r;")]
        [TestCase("  \t;")]
        [TestCase("  \v;")]
        [TestCase("\f\f ;")]
        [TestCase("\n\n ;")]
        [TestCase("\r\r ;")]
        [TestCase("\t\t ;")]
        [TestCase("\v\v ;")]
        [TestCase("\f \f;")]
        [TestCase("\n \n;")]
        [TestCase("\r \r;")]
        [TestCase("\t \t;")]
        [TestCase("\v \v;")]
        [TestCase(" \f\f;")]
        [TestCase(" \n\n;")]
        [TestCase(" \r\r;")]
        [TestCase(" \t\t;")]
        [TestCase(" \v\v;")]
        public void ShouldReturnFalseGivenNonIgnorableString(string strValue)
        {
            Assert.IsFalse(
                SRFIsStringIgnorableUtility.IsStringIgnorable(strValue)
            );
        }

    }
}
