using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohen_UT2_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            foreach (DateTime value in friendBirthdays.Values)
            {
                Console.WriteLine(value.ToString("MM/dd/yyyy"));
            }
        }
    }
}
