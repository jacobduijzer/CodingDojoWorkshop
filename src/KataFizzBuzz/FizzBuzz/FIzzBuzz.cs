using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetStringForNumber(int number)
        {
            string result = null;
            if (number % 3 == 0)
            {
                result += "Fizz";
            }
            if (number % 5 == 0)
            {
                result += "Buzz";
            }
            if (number % 7 == 0)
            {
                result = "FizzBuzzBang";
            }
            return result ?? number.ToString();
        }

        public string GetStringForNumber1(int number)
        {
            if (number % 7 == 0)
            {
                return "FizzBuzzBang";
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}
