using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFizzBuzz
{
    public class InputValues
    {
        private List<Input> vals;

        private class Input
        {
            public int multiplier;
            public string words;
        }

        public InputValues()
        {
            vals = new List<Input>();
        }

        // Add user input values from Values list to List<Input>
        public void Add(int multiNum, string multiWords)
        {
            vals.Add(new Input() { multiplier = multiNum, words = multiWords });
        }

        // Loop through user input range and divisor/words for calcuation
        public string GetString(int Number)
        {
            string output = "";
            foreach (var v in vals)
            {
                if (Number % v.multiplier == 0)
                    output += v.words.ToString() + " ";
                else
                    output += "";
            }
            return String.IsNullOrWhiteSpace(output) ? Number.ToString() : Number.ToString() + " " + output;
        }
    }

    // Loop through user input range values in Values list
    public class Range
    {
        private int min;
        private int max;
        private InputValues values;

        public Range(int rangeMin, int rangeMax, InputValues Values)
        {
            min = rangeMin;
            max = rangeMax;
            values = Values;
        }

        public void Output()
        {
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(values.GetString(i));
            }
        }
    }
}