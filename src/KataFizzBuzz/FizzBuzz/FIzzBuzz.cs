using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetStringForNumber(int number)
        {
            if (number % 7 == 0)
                return "FizzBuzzBang";
            else if (number % 15 == 0)
                return "FizzBuzz";
            else if (number % 5 == 0)
                return "Buzz";
            else if (number % 3 == 0)
                return "Fizz";
            else
                return number.ToString();
        }

    }
}

