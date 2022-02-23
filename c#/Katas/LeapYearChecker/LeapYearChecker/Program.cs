using System;
using LeapYear;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a year to check to see if the year is a leap year. format: YYYY");
            var leapYearChecker = new LeapYearChecker();
            var consoleInput = Console.ReadLine();
            var year = Int32.Parse(consoleInput);

            var isLeapYear = leapYearChecker.IsLeapYear(year);
            Console.WriteLine(isLeapYear ? $"The year {year} is a leap year." : $"The year {year} is not a leap year");
        }
    }
}
