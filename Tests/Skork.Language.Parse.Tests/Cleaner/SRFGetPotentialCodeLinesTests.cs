using NUnit.Framework;
using Skork.Language.Parse.Cleaner;
using System.Collections.Generic;
using System.Linq;

namespace Skork.Language.Parse.Tests.Cleaner

{
    [TestFixture]
    [Author("Reapism")]
    public class SRFGetPotentialCodeLinesTests
    {

        private IEnumerable<IEnumerable<string>> _listOfPotentialCodeLines;

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void GetPotentialCodeStatements_GivenActual_ShouldMatchExpected()
        {
            // Given
            var expectedCodeLinesList = GetExpectedCodeLines();
            var actualCodeLinesList = GetPotentialCodeLines();

            //When 
            actualCodeLinesList = SRFGetPotentialCodeLines.GetPotentialCodeStatements(actualCodeLinesList).ToList();

            // Ensure the conversion is not null.
            Assert.IsNotNull(expectedCodeLinesList, nameof(expectedCodeLinesList));
            Assert.IsNotNull(actualCodeLinesList, nameof(actualCodeLinesList));

            for (int i = 0; i < expectedCodeLinesList.Count; i++)
            {
                StringAssert.AreEqualIgnoringCase(expectedCodeLinesList[i], actualCodeLinesList[i]);
            }
        }
        

        private List<string> GetPotentialCodeLines()
        {
            var lst = new List<string>
            {
                "\n\t int\n\t i\n\t = \t\t\n 0\n \t;",
                "\n  int\n\t i\n\t = \t\t\n 0\n \t;",
                "\n\t int \n\t i\n\t = \t\t\n 0\n \t;",
                "\n\t int\n\t i \n\t = \t\t \n 0\n \t;",
                " \n\t int\n\t i\n\t = \t \t\n 0\n \t;",
                "\n \t int\n\t i\n\t = \t \t\n 0\n \t;",
                " \v \n\t int\n\t i\n\t = \t \t\n 0\n \t;",
                "\t \v loop(i\t\n=> \rx) {",
                "\n\t int\n\t i\n\t = \t\t\n 0\n \t;",
                "\t\v}",
                "\n\t int\n\t i\n\t = \t\t\n 0\n \t;"
            };
            return lst;
        }

        private List<string> GetExpectedCodeLines()
        {
            var lst = new List<string>
            {
                "\n\t int\n\t i\n\t = \t\t\n 0\n \t",
                "\n  int\n\t i\n\t = \t\t\n 0\n \t",
                "\n\t int \n\t i\n\t = \t\t\n 0\n \t",
                "\n\t int\n\t i \n\t = \t\t \n 0\n \t",
                " \n\t int\n\t i\n\t = \t \t\n 0\n \t",
                "\n \t int\n\t i\n\t = \t \t\n 0\n \t",
                " \v \n\t int\n\t i\n\t = \t \t\n 0\n \t",
                "\t \v loop(i\t\n=> \rx) {\n\t int\n\t i\n\t = \t\t\n 0\n \t;\t\v}",
                "\n\t int\n\t i\n\t = \t\t\n 0\n \t",
            };
            return lst;
        }
    }
}
