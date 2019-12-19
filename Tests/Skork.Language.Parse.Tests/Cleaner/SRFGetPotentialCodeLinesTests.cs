using NUnit.Framework;
using Skork.Language.Parse.Cleaner;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skork.Language.Parse.Tests.Cleaner
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFGetPotentialCodeLinesTests
    {
        [TestCase("")]
        public void GivenStringWithSemiColonShouldReturnFalse(string actualStr)
        {
            Assert.IsFalse(SRFGetPotentialCodeLines.)
        }
    }
}
