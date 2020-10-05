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
        public void convertToRPN(string input,string expected)
        {
            string actual = parser.ConvertTorpm(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
