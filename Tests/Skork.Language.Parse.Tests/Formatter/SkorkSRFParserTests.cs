using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Skork.Language.Parse.Tests.Formatter
{
    [TestFixture]
    [Author("Reapism")]
    public class SkorkSRFParserTests
    {
        [Test]
        public void ShouldThrowExceptionGivenNullArgumentToArrayConstructor()
        {
            Assert.Throws<ArgumentNullException>(() => new SkorkSRFParser(codeStrArr: null));
        }

        [Test]
        public void ShouldThrowExceptionGivenEmptyArgumentToArrayConstructor()
        {
            Assert.Throws<ArgumentNullException>(() => new SkorkSRFParser(codeStrArr: new string[] { }));
        }

        [Test]
        public void ShouldThrowExceptionGivenNullArgumentToIEnumerableConstructor()
        {
            Assert.Throws<ArgumentNullException>(() => new SkorkSRFParser(code: null));
        }

        [Test]
        public void ShouldThrowExceptionGivenEmptyListArgumentToConstructor()
        {
            Assert.Throws<ArgumentNullException>(() => new SkorkSRFParser(code: new List<string>()));
        }

        [TestCase("a")]
        [TestCase("a", "a")]
        [TestCase(";")]
        [TestCase("{")]
        [TestCase("}")]
        [TestCase("int")]
        [TestCase(" ")]
        [TestCase("[")]
        [TestCase("]")]
        [TestCase("A", "{")]
        public void DoesNotThrowGivenArgumentToArrayConstructor(params string[] args)
        {
            Assert.DoesNotThrow(() => new SkorkSRFParser(codeStrArr: args));
        }

        [TestCase("a")]
        [TestCase("a", "a")]
        [TestCase(";")]
        [TestCase("{")]
        [TestCase("}")]
        [TestCase("int")]
        [TestCase(" ")]
        [TestCase("[")]
        [TestCase("]")]
        [TestCase("A", "{")]
        public void DoesNotThrowGivenArgumentToListConstructor(params string[] args)
        {
            var list = new List<string>(args);

            Assert.DoesNotThrow(() => new SkorkSRFParser(code: list));
        }
    }
}
