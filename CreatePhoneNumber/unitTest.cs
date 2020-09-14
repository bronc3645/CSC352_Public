using System;
using NUnit.Framework;

namespace CreatePhoneNumber
{
    [TestFixture]
    public class unitTest
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, "(000) 000-0000")]
        public void ValidFormat(int[] numbers, String expected)
        {
            String actual = Logic.TranslateToPhoneNumbers(numbers);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
