using System;

namespace RoundDelegate
{
    delegate double roundingFunction(double n, int precision);


    static internal class Program
    {
        static void Main(string[] args)
        {
            double d1 = 10.325;
            double d2 = 2.0934;

            int i1 = 0;
            int i2 = 1;

            roundingFunction roundNumber;

            roundNumber = new roundingFunction(roundMethod); 
            double dresult1 = roundNumber(d1, i1);

            roundNumber = new roundingFunction( (double n, int p) => Math.Round(n, p) );
            double dresult2 = roundNumber(d2, i2);

            Console.WriteLine("{0} rounded to the {1} decimal place => {2}", d1, i1, dresult1);
            Console.WriteLine("{0} rounded to the {1} decimal place => {2}", d2, i2, dresult2);

        }

        static double roundMethod(double n, int p)
        {
            return Math.Round(n, p);
        }
    }
}
