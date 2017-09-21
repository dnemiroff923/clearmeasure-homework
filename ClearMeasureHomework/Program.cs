using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using NotFizzBuzz;

namespace ClearMeasureHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for the range of numbers to loop through
            Console.Write("Enter a starting number: ");
            var start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an ending number: ");
            var end = Convert.ToInt32(Console.ReadLine());

            // Allow user to enter as many divisor and corresponding values as they want
            var values = new InputValues();

            while (true)
            {
                Console.Write("Enter multiplier number or type 'Quit' to exit: ");
                var multiNum = Console.ReadLine();
                if (multiNum.ToLower() == "quit")
                    break;

                Console.Write("Enter cooresponding word or type 'Quit' to exit: ");
                var multiWord = Console.ReadLine();
                if (multiWord.ToLower() == "quit")
                    break;

                var multiplier = Convert.ToInt32(multiNum);

                // Add user input values to List<Values>
                values.Add(multiplier, multiWord);
            }

            // Pass range of numbers from user input and Values list
            var range = new Range(start, end, values);
            range.Output();
            Console.ReadLine();




            /*  From phone interview - put FizzBuzz in a separate class */
                //  Console.WriteLine(FizzBuzzing.DoFizzBuzz());
                //  Console.ReadLine();  
        }
    }
}