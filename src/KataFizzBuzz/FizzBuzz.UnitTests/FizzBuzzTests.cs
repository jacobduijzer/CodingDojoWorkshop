using FluentAssertions;
using Xunit;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void ReturnString() =>
            new FizzBuzz().GetStringForNumber(0).Should().BeOfType<string>();

        [Fact]
        public void ShouldDivisibleBy3BeFizz() =>
            new FizzBuzz().GetStringForNumber(3).Should().Be("Fizz");

        [Fact]
        public void ShouldDivisibleBy5BeBuzz() =>
            new FizzBuzz().GetStringForNumber(5).Should().Be("Buzz");

        [Fact]
        public void ShouldDivisibleBy15BeFizzBuzz() =>
            new FizzBuzz().GetStringForNumber(15).Should().Be("FizzBuzz");

        [Fact]
        public void ShouldReturnNumberWhenNotDevisableBy3or5() =>
            new FizzBuzz().GetStringForNumber(4).Should().Be("4");
    }
}
