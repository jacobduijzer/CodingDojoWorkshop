using FluentAssertions;
using Xunit;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void ReturnString() =>
            new FizzBuzz().GetStringForNumber(3).Should().BeOfType<string>();

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        public void ReturnFizzOnMultipleOfThree(int number, string result) =>
            new FizzBuzz().GetStringForNumber(number).Should().Be(result);

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        public void ReturnBuzzOnMultipleOfFive(int number, string result) =>
            new FizzBuzz().GetStringForNumber(number).Should().Be(result);

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        public void ReturnBuzzOnMultipleOfFifteen(int number, string result) =>
            new FizzBuzz().GetStringForNumber(number).Should().Be(result);

        [Theory]
        [InlineData(11, "11")]
        [InlineData(17, "17")]
        public void ReturnStringRepresentationOfNumberWhenNotFizzBuzzNumber(int number, string result) =>
            new FizzBuzz().GetStringForNumber(number).Should().Be(result);

        [Theory]
        [InlineData(7, "FizzBuzzBang")]
        [InlineData(14, "FizzBuzzBang")]
        [InlineData(28, "FizzBuzzBang")]
        public void ReturnFizzBuzzBangOnMultipleOfSeven(int number, string result) =>
            new FizzBuzz().GetStringForNumber(number).Should().Be(result);
    }
}

