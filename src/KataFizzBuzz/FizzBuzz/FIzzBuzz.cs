using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetStringForNumber(int number) {
            var result = "";

            if (number % 3 == 0) {
                result += "Fizz";
            }

            if (number % 5 == 0)
            {
                result += "Buzz";
            }

            if( result == "")
            {
                return number.ToString();
            }

            return result;
        }
    }
}
