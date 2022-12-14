using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunction
{
    class Program
    {
        public delegate double MyRounder(double d, int n);
        static void Main(string[] args)
        {
            // create variable of delegate function type 
            MyRounder myRounder;

            // your code here
            // 1
            myRounder = new MyRounder(delegate (double d, int n) { return Math.Round(d, n); });

            // 2
            myRounder += delegate (double d, int n) { return Math.Round(d, n); };

            // 3
            myRounder += (double d, int n) => { return Math.Round(d, n); };

            // 4
            myRounder += (double d, int n) => Math.Round(d, n);

            // 5
            myRounder += new MyRounder((double d, int n) => { return Math.Round(d, n); });

            // 6
            myRounder += (d, n) => { return Math.Round(d, n); };

            // 7
            myRounder += (d, n) => Math.Round(d, n);

            // 8
            myRounder += new MyRounder(Math.Round);

            // 9
            myRounder += Math.Round;

            // 10
            myRounder += new MyRounder(new Func<double, int, double>((double d, int n) => { return Math.Round(d, n); }));

            // 11
            myRounder += new MyRounder(new Func<double, int, double>(Math.Round));

            // 12
            myRounder += new MyRounder((d, n) => { return Math.Round(d, n); });
        }
    }
}
