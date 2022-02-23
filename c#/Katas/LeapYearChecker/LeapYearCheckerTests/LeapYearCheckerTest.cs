using NUnit.Framework;
using LeapYear;

namespace LeapYearCheckerTests;

public class Tests
{
    [TestFixture]
    public class LeapYearTests
    {
        private LeapYearChecker leapYearChecker;

        [SetUp]
        public void Setup()
        {
            leapYearChecker = new LeapYearChecker();
        }

        [TestCase(2000)] // leap year = pass
        [TestCase(1900)] // non leap year = fail
        [TestCase(2012)] // leap year = pass
        [TestCase(2019)] // non leap year = fail
        public void IsGivenYear_ALeapYear(int year)
        {
            Assert.IsTrue(leapYearChecker.IsLeapYear(year));
        }
    }
}
