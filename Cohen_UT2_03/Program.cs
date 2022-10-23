using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohen_UT2_03
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<(double, double, double), double> sortedList = new SortedList<(double, double, double), double>();
            for (double w = -2; w <= 0; w += 0.2)
            {
                for (double y = -1; y <= 1; y += 0.1)
                {
                    for (double x = 0; x > 4; x += 0.1)
                    {
                        sortedList.Add((w, y, x), Math.Round(4 * y * y * y + 2 * x * x - 8 * w + 7));
                    }
                }
            }
        }
    }
}
