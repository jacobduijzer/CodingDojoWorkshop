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
        public void NumberNotDevisableBy3Or5ShouldReturnNumberString() =>
            new FizzBuzz().GetStringForNumber(1).Should().Be("1");

        [Fact]
        public void NumberDevisableBy3AndNotDevsiableBy5ShouldReturnFizz() =>
            new FizzBuzz().GetStringForNumber(3).Should().Be("Fizz");
    }
}
