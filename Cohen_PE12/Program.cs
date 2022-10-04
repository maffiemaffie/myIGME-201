using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohen_PE12
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass testClass = new MyDerivedClass();
            Console.WriteLine(testClass.GetString());
        }

        public class MyClass
        {
            private string MyString;
            public virtual string GetString()
            {
                return MyString;
            }
        }

        public class MyDerivedClass : MyClass
        {
            public virtual string GetString()
            {
                return base.GetString() + " (output from the derived class)";
            }
        }
    }
}
