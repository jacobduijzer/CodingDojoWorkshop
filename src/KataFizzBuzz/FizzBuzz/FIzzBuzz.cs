using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetStringForNumber(int number)
        {
            var devisableBy3 = number % 3 == 0;
            var devisableBy5 = number % 5 == 0;

            if (devisableBy3 && devisableBy5)
            {
                return "FizzBuzz";
            }
            else if (devisableBy3)
            {
                return "Fizz";
            }
            else if (devisableBy5)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }

        public IEnumerable<string> GetListForNumberRange(int amountOfItems)
        {
            for (int i = 1; i <= amountOfItems; i++)
            {
                yield return GetStringForNumber(i);
            }
        }
    }
}
