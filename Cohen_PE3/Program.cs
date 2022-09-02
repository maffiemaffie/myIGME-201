using System;

namespace Cohen_PE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                Console.WriteLine("ERROR: Invalid parameters, expected four integers, receieved " +
                    args.ToString());
            } else
            {
                int product = 1; // multiplicative identity
                bool isError = false;
                for (int i = 0; i < 4; i++)
                {
                    try
                    {
                        product *= Convert.ToInt32(args[i]);
                    } catch
                    {
                        Console.WriteLine("ERROR: Invalid parameter, " + args[i] + " is not a valid integer.");
                        isError = true;
                        break;
                    }   
                }
                if (!isError)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}
