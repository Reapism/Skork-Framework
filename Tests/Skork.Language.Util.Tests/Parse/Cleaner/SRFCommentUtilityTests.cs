﻿using NUnit.Framework;
using Skork.Language.Util.Parse;
using System;

namespace Skork.Language.Util.Tests.Parse.Cleaner
{
    [TestFixture]
    [Author("Reapism")]
    public class SRFCommentUtilityTests
    {
        [TestCase("", "")]
        [TestCase("", "// ")]
        [TestCase("", "// /")]
        [TestCase("", "// //")]
        [TestCase("", "// ///")]
        [TestCase("", "// // //")]
        [TestCase("", "//int m //= 0;//hello")]
        [TestCase(" ", " //int n //= 0;// hello")]
        [TestCase("/ ", "/ //int o //= 0;//  hello")]
        [TestCase("/  ", "/  //int p //= 0;///hello ")]
        [TestCase("\t", "\t///int m //= 0;//hello")]
        [TestCase("\r", "\r///int m //= 0;//hello")]
        [TestCase("\n", "\n///int m //= 0;//hello")]
        [TestCase("\v", "\v///int m //= 0;//hello")]
        [TestCase("a", "a")]
        [TestCase("ab", "ab")]
        [TestCase("a\\", "a\\")]
        [TestCase("a\\ ", "a\\ ")]
        [TestCase(" a", " a")]
        [TestCase(" ab", " ab")]
        [TestCase(" a\\", " a\\")]
        [TestCase(" a\\ ", " a\\ ")]
        [TestCase("\ta", "\ta")]
        [TestCase("\tab", "\tab")]
        [TestCase("\ta\\", "\ta\\")]
        [TestCase("\ta\\ ", "\ta\\ ")]
        [TestCase("\t\ta", "\t\ta")]
        [TestCase("\t\tab", "\t\tab")]
        [TestCase("\t\ta\\", "\t\ta\\")]
        [TestCase("\t\ta\\ ", "\t\ta\\ ")]
        [TestCase("\ra", "\ra")]
        [TestCase("\rab", "\rab")]
        [TestCase("\ra\\", "\ra\\")]
        [TestCase("\ra\\ ", "\ra\\ ")]
        [TestCase("\r\ra", "\r\ra")]
        [TestCase("\r\rab", "\r\rab")]
        [TestCase("\r\ra\\", "\r\ra\\")]
        [TestCase("\r\ra\\ ", "\r\ra\\ ")]
        [TestCase("\va", "\va")]
        [TestCase("\vab", "\vab")]
        [TestCase("\va\\", "\va\\")]
        [TestCase("\va\\ ", "\va\\ ")]
        [TestCase("\v\va", "\v\va")]
        [TestCase("\v\vab", "\v\vab")]
        [TestCase("\v\va\\", "\v\va\\")]
        [TestCase("\v\va\\ ", "\v\va\\ ")]
        [TestCase("\na", "\na")]
        [TestCase("\nab", "\nab")]
        [TestCase("\na\\", "\na\\")]
        [TestCase("\na\\ ", "\na\\ ")]
        [TestCase("\n\na", "\n\na")]
        [TestCase("\n\nab", "\n\nab")]
        [TestCase("\n\na\\", "\n\na\\")]
        [TestCase("\n\na\\ ", "\n\na\\ ")]
        [TestCase("int a = 0; ", "int a = 0; //hello")]
        [TestCase("int b = 0; ", "int b = 0; // hello")]
        [TestCase("int c = 0; ", "int c = 0; //  hello")]
        [TestCase("int d = 0; ", "int d = 0; ///hello ")]
        [TestCase("int e = 0; ", "int e = 0; ////hello  ")]
        [TestCase("int f = 0; ", "int f = 0; //////    hello    ")]
        [TestCase("int g = 0;", "int g = 0;//hello")]
        [TestCase("int h = 0;", "int h = 0;// hello")]
        [TestCase("int i = 0;", "int i = 0;//  hello")]
        [TestCase("int j = 0;", "int j = 0;///hello ")]
        [TestCase("int k = 0;", "int k = 0;////hello  ")]
        [TestCase("int l = 0;", "int l = 0;//////    hello    ")]
        [TestCase("int m ", "int m //= 0;//hello")]
        [TestCase("int n ", "int n //= 0;// hello")]
        [TestCase("int o ", "int o //= 0;//  hello")]
        [TestCase("int p ", "int p //= 0;///hello ")]
        [TestCase("int q ", "int q //= 0;////hello  ")]
        public void GivenStringsWithCommentsShouldReturnExpectedString(string expectedStr, string actualStr)
        {
            var actual = SRFCommentUtility.RemoveCommentsFromCodeLine(actualStr);
            StringAssert.AreEqualIgnoringCase(expectedStr, actual);
        }

        [Test]
        public void ShouldThrowExceptionGivenNullStringArgument()
        {
            Assert.Throws<ArgumentNullException>(() =>
                SRFCommentUtility.RemoveCommentsFromCodeLine(null));
        }
    }
}
