using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzing.Library
{
    /* Using for unit testing */

    public enum Multiplier
    {
        FizzBuzz,
        Fizz,
        Buzz,
    }

    public class FizzBuzzRules
    {
        public static Multiplier GetNewValue(Multiplier currentWords, int multiplier)
        {
            switch (currentWords)
            {
                case Multiplier.FizzBuzz:
                    if (multiplier == 15)
                        return Multiplier.FizzBuzz;
                    break;
                case Multiplier.Fizz:
                    if (multiplier == 3 || multiplier == 6)
                        return Multiplier.Fizz;
                    break;
                case Multiplier.Buzz:
                    if (multiplier == 5)
                        return Multiplier.Buzz;
                    break;
            }
            return currentWords;
        }
    }
}