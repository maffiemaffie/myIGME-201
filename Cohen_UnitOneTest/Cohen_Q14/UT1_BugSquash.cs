using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            // int nY
            int nY; // Compile-time: no semicolon
            int nAnswer;

            // Console.WriteLine(This program calculates x ^ y.);
            Console.WriteLine("This Program calculates x ^ y."); // Compile-time: no quotations

            do
            {
                Console.Write("Enter a whole number for x: ");
                // Console.ReadLine();
                sNumber = Console.ReadLine(); // Compile-time: input not stored in sNumber
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            // } while (int.TryParse(sNumber, out nX));
            } while (!int.TryParse(sNumber, out nY)); // Logic: Y should go into nY, missing ! in front of conditional

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            // Console.WriteLine("{nX}^{nY} = {nAnswer}");
            Console.WriteLine("{0}^{1} = {2}", nX, nY, nAnswer); // Logic: wrong syntax
        }


        // int Power(int nBase, int nExponent)
        static int Power(int nBase, int nExponent) // Compile-time: declared as instance method
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                // returnVal = 0;
                returnVal = 1; // Logic: x^0 = 1, not 0
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                // nextVal = Power(nBase, nExponent + 1); 
                nextVal = Power(nBase, nExponent - 1); // Logic / Run-time: nExponent never reaches base case

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            // returnVal;
            return returnVal; // Compile-time: doesn't return value
        }
    }
}
