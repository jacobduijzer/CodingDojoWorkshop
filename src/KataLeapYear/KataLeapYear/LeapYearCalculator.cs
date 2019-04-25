using System;
namespace KataLeapYear
{
    public class LeapYearCalculator
    {
        public bool IsLeapYear(int year)
        {
            var result = false;
            if (year % 4 == 0)
            {
                result = true;
            }
            if (year % 100 == 0)
            {
                result = year % 400 == 0;
            }
            return result;
        }
    }
}
