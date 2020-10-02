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
        [TestCase("1+1",2)]
        public void parseValidInput(string input,int expected)
        {
            int actual = parser.parse(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
