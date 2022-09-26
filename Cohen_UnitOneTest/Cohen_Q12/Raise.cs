using System;

namespace Raise
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.Write("Please enter your name: ");
            sName = Console.ReadLine();

            if (GiveRaise(sName, ref dSalary)) {
                Console.WriteLine("Congratulations, {0}, on your raise to ${1}", sName, Math.Round(dSalary, 2));
            }
        }

        static bool GiveRaise( string name, ref double salary)
        {
            if (name.Equals("Maffie"))
            {
                salary += 19999.99;
                return true;
            }
            return false;
        }
    }
}
