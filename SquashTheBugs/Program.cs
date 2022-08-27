using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh & Maffie Cohen :3
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: 1 / 0 is undefined
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0
            int i = 0; // compile-time error: missing semicolon
            string allNumbers = null; // compile-time error: declared in wrong scope

            // loop through the numbers 1 through 10
            // for (i = 1; i < 10; ++i)
            for (i = 1; i <= 10; ++i) // logic error: loop stops at 9
            {
                // declare string to hold all numbers
                // string allNumbers = null;

                // output explanation of calculation
                // Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = "); // compile-time error: incorrect order of operations

                // output the calculation based on the numbers
                if (i - 1 != 0)
                {
                    // Console.WriteLine(i / (i - 1));
                    Console.WriteLine((double) i / (i - 1)); // logic error: int/int will return an int
                } else
                {
                    Console.WriteLine("Divide by 0 is not defined"); // runtime error: divides by 0
                }
                

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // i = i + 1; logic error: increment is redundant
            }

            // output all numbers which have been processed
            // Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers); // compile-time error: missing + operator
        }
    }
}
