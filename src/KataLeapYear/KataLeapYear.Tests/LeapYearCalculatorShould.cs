using System;
using FluentAssertions;
using Xunit;

namespace KataLeapYear.Tests
{
    public class LeapYearCalculatorShould
    {
        [Fact]
        public void NotThrowException()
            => new Action(() => new LeapYearCalculator().IsLeapYear(0)).Should().NotThrow<Exception>();

        [Theory]
        [InlineData(2000, true)]
        [InlineData(1700, false)]
        [InlineData(1800, false)]
        [InlineData(1900, false)]
        [InlineData(2100, false)]
        [InlineData(2008, true)]
        [InlineData(2012, true)]
        [InlineData(2016, true)]
        [InlineData(2017, false)]
        [InlineData(2018, false)]
        [InlineData(2019, false)]
        public void CalculateIfGivenYearIsALeapYear(int year, bool expectedResult) =>
            new LeapYearCalculator().IsLeapYear(year)
                .Should().Be(expectedResult);
    }
}
