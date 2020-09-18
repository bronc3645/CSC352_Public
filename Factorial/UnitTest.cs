using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

using NUnit.Framework;

namespace Factorial
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class UnitTest
    {
        [TestCase(5,120)]
        [TestCase(1,1)]
        [TestCase(3,6)]
        [TestCase(4,24)]
        [Test]
        public void factorial_test(int input,int expected)
        {
            int actual = Logic.factorial(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
