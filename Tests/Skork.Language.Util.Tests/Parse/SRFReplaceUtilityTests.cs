using NUnit.Framework;
using Skork.Language.Util.Parse;
using System;
using System.Collections.Generic;
using System.Text;

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
                SRFReplaceUtility.ReplaceWhitespacesWithSingleSpaces(null)
            );
        }

        [TestCase("")]
        public void ShouldThrowExceptionGivenNullArgument(string actualStr)
        {
            
        }

    }
}
