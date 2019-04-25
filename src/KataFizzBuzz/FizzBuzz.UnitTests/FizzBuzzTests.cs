using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void ReturnString() =>
            new FizzBuzz().GetStringForNumber(0).Should().BeOfType<string>();

        [Fact]
        public void NumberNotDevisableBy3Or5ShouldReturnNumberString() =>
            new FizzBuzz().GetStringForNumber(1).Should().Be("1");

        [Fact]
        public void NumberDevisableBy3AndNotDevsiableBy5ShouldReturnFizz() =>
            new FizzBuzz().GetStringForNumber(3).Should().Be("Fizz");

        [Fact]
        public void NumberDevisableBy5AndNotDevsiableBy3ShouldReturnBuzz() =>
           new FizzBuzz().GetStringForNumber(5).Should().Be("Buzz");

        [Fact]
        public void NumberDevisableBy3AndDevsiableBy5ShouldReturnFizzBuzz() =>
           new FizzBuzz().GetStringForNumber(15).Should().Be("FizzBuzz");

        [Fact]
        public void NumberRangeShouldListOfStrings() =>
          new FizzBuzz().GetListForNumberRange(1).Should().BeAssignableTo<IEnumerable<string>>();

        [Fact]
        public void NumberRangeShouldListOfEqualSize() =>
          new FizzBuzz().GetListForNumberRange(5).Count().Should().Be(5);
    }
}
