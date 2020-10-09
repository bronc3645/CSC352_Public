using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.logic.unitTest
{
    [TestFixture]
    public class parserTest
    {
        [TestCase("1 + 1","1 1 +")]
        [TestCase("1 + 1 + 1","1 1 1 + +")]
        [TestCase("1 * 2 + 1","1 2 * 1 +")]
        [TestCase("1 + 2 * 2 + 1","1 2 2 * 1 + +")]
        [TestCase("1 + 2 * 2 + 1 * 2", "1 2 2 * 1 2 * + +")]
        [TestCase("1 * ( 1 + 2 )","1 1 2 + *")]
        [TestCase("1 + 1 * 2","1 1 2 * +")]
        public void convertToRPN(string input,string expected)
        {
            string actual = parser.ConvertTorpm(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("+", "+",true)]
        [TestCase("+", "-", true)]
        [TestCase("-", "+", true)]
        [TestCase("-", "-", true)]
        [TestCase("+", "*", false)]
        [TestCase("*", "+", false)]
        [TestCase("-", "*", false)]
        [TestCase("*", "-", false)]
        [TestCase("+", "/", false)]
        [TestCase("/", "+", false)]
        [TestCase("-", "/", false)]
        [TestCase("/", "-", false)]
        [TestCase("*", "/", true)]
        [TestCase("*", "*", true)]
        [TestCase("/", "/", true)]
        [TestCase("/", "*", true)]
        [TestCase("^", "*", false)]
        [TestCase("^", "/", false)]
        [TestCase("^", "+", false)]
        [TestCase("^", "-", false)]
        [TestCase("+", "^", false)]
        [TestCase("-", "^", false)]
        [TestCase("*", "^", false)]
        [TestCase("/", "^", false)]
        [TestCase("^", "^", true)]
        public void testequalprecidence(string x,string y, bool expected)
        {
            bool actual = parser.operatorHasequalpres(x, y);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [TestCase("+", "+", false)]
        [TestCase("+", "-", false)]
        [TestCase("-", "+", false)]
        [TestCase("-", "-", false)]
        [TestCase("+", "*", false)]
        [TestCase("*", "+", true)]
        [TestCase("-", "*", false)]
        [TestCase("*", "-", true)]
        [TestCase("+", "/", false)]
        [TestCase("/", "+", true)]
        [TestCase("-", "/", false)]
        [TestCase("/", "-", true)]
        [TestCase("*", "/", false)]
        [TestCase("*", "*", false)]
        [TestCase("/", "/", false)]
        [TestCase("/", "*", false)]
        [TestCase("^", "*", true)]
        [TestCase("^", "/", true)]
        [TestCase("^", "+", true)]
        [TestCase("^", "-", true)]
        [TestCase("+", "^", false)]
        [TestCase("-", "^", false)]
        [TestCase("*", "^", false)]
        [TestCase("/", "^", false)]
        [TestCase("^", "^", false)]
        public void testhigherprecidence(string x, string y, bool expected)
        {
            bool actual = parser.opperatorHasGreaterPres(x, y);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
