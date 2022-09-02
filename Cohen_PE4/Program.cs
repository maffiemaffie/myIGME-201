using System;

namespace Cohen_PE4
{
    // Author: Maffie Cohen
    // Purpose: Displays two numbers if only one is greater than 10
    // Restrictions:
    static class Program
    {
        // Purpose: Asks for numbers and either displays them or asks for new ones
        // Restrictions:
        static void Main(string[] args)
        {
            double num1;
            double num2;
            do
            {
                Console.WriteLine("Hello please give me a couple numbers");
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());
            } while (((num1 > 10) && (num2 > 10)) || ((num1 < 10) && (num2 < 10)));
            Console.WriteLine(num1 + " " + num2);

        }
    }
}
