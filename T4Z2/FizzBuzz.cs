using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Z2
{
    class FizzBuzz
    {
        public  string CheckFizzBuzz(int number)
        {
            string fizzBuzz = String.Empty;
            if (number % 3 == 0)
                fizzBuzz += "Fizz";
            if (number % 5 == 0)
                fizzBuzz += "Buzz";
            if (fizzBuzz.Equals(String.Empty))
                fizzBuzz = number.ToString();
            return fizzBuzz;
        }
    }
}
