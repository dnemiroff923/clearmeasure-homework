using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzzing
    {
        public static string DoFizzBuzz()
        {
            string fizzBuzzOutput = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    fizzBuzzOutput += i.ToString() + " FizzBuzz\n";
                else if (i % 3 == 0)
                    fizzBuzzOutput += i.ToString() + " Fizz\n";
                else if (i % 5 == 0)
                    fizzBuzzOutput += i.ToString() + " Buzz\n";
                else
                    fizzBuzzOutput += i.ToString() + "\n";
            }
            return fizzBuzzOutput;
        }
    }
}