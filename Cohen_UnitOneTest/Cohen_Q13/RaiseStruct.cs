using System;

namespace Raise
{
    static internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }

        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.Write("Please enter your name: ");
            sName = Console.ReadLine();

            employee user;
            user.sName = sName;
            user.dSalary = dSalary;

            if (GiveRaise(ref user)) {
                Console.WriteLine("Congratulations, {0}, on your raise to ${1}", user.sName, Math.Round(user.dSalary, 2));
            }
        }

        static bool GiveRaise( ref employee user )
        {
            if (user.sName.Equals("Maffie"))
            {
                user.dSalary += 19999.99;
                return true;
            }
            return false;
        }
    }
}
