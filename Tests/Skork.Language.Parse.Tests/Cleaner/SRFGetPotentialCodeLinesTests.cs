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
                "\t int \r\v  i \t\n\n=\n \r\t 0;",
                "loop(x => y) {",
                "\t int i = 1;",
                "}",
                "\t int \r\v  i \t\n\n=\n \r\t 2;",
                "loop(x => y) {",
                "\t int i = 3;",
                "\r\n int \n \ti = 3\r;",
                "}",
            };
            return lst;
        }

        private List<string> GetExpectedCodeLines()
        {
            var lst = new List<string>
            {
                "\t int \r\v  i \t\n\n=\n \r\t 0",
                "loop(x => y) {\t int i = 1;}",
                "\t int \r\v  i \t\n\n=\n \r\t 2",
                "loop(x => y) {\t int i = 3;\r\n int \n \ti = 3\r;}",
            };
            return lst;
        }
    }
}
