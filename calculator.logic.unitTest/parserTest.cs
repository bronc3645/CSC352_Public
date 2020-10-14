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
        [TestCase("1 + 2 * 3 ^ 4","1 2 3 4 ^ * +")]
        [TestCase("1 + 1 + 1","1 1 + 1 +")]
        [TestCase("1 * 2 + 1","1 2 * 1 +")]
        [TestCase("1 + 2 * 2 + 1", "1 2 2 * 1 + +")]
        [TestCase("1 + 2 * 2 + 1 * 2", "1 2 2 * 1 2 * + +")]
        [TestCase("1 ^ 2 ^ 2 + 1", "1 2 2 ^ ^ 1 +")]
        [TestCase("1 ^ 2 * 2 + 1","1 2 ^ 2 * 1 +")]
        [TestCase("1 * ( 1 + 2 )","1 1 2 + *")]
        [TestCase("1 + 1 * 2","1 1 2 * +")]
        [TestCase("( 2 * 2 ) ^ 2","2 2 * 2 ^")]
        [TestCase("3 / 2 * 4","3 2 / 4 *")]
        [TestCase("3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3","3 4 2 * 1 5 - 2 3 ^ ^ / +")]
        [TestCase("1 + sqrt ( 4 )","1 4 sqrt +")]
        public void convertToRPN(string input,string expected)
        {
            string actual = Parser.ConvertTorpm(input);

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
            bool actual = Parser.operatorHasequalpres(x, y);
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
            bool actual = Parser.opperatorHasGreaterPres(x, y);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
