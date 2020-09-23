using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FunWithClasses
{
    [TestFixture]
    class unitTest
    {
        [TestCase("ace","Ace")]
        [TestCase("jerry","Jerry")]
        public void testFirstNameProperty(string input, string expected)
        {
            person person = new person();

            person.firstname = input;

            Assert.That(person.firstname, Is.EqualTo(expected));
        }
    }
}
