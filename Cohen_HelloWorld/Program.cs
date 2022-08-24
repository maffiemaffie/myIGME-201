using System;

namespace HelloWorld
{
    // Author: Maffie Cohen
    // Purpose: to practice syntax in C#
    // Restrictions: 
    static class Program
    {
        // Purpose: Write a few lines to the console
        // Restrictions: 
        static void Main(string[] args)
        {
            int num = 15;
            string str = "3";
            Console.WriteLine("Maffie Cohen");
            Console.WriteLine("num + str = " + num + str);
            Console.WriteLine("num + num = " + (num + num)); // parentheses evaluate math before concatenating to string

            int counter = 0;
            while (++counter < 10)
            {
                Console.Write(counter + "");
            }
        }
    }
}