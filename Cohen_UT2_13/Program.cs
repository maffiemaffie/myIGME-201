using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohen_UT2_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MyClass
    {
        public MyClass GetCopy()
        {
            return (MyClass)this.MemberwiseClone();
        }
    }
}
