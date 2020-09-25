using System;
using System.Collections;
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
        
        [TestCaseSource(typeof(EqualityTest))]
        public void testEquality(person a,person b,bool expected)
        {
            bool actual = a.Equals(b);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    internal class EqualityTest : System.Collections.IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new TestCaseData(
                new person() {
                    firstname = "ace",
                    Lastname="o",
                    birthdate=new DateTime(1988, 03, 31)},
                new person() {
                    firstname = "ace",
                    Lastname = "s",
                    birthdate = new DateTime(1990, 03, 31) },
                false);
            yield return new TestCaseData(
                new person()
                {
                    firstname = "ace",
                    Lastname = "o",
                    birthdate = new DateTime(1988, 03, 31)
                },
                new person()
                {
                    firstname = "ace",
                    Lastname = "o",
                    birthdate = new DateTime(1988, 03, 31)
                },
                true);
        }
    }
}
