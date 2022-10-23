using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohen_PE14
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            MyClass1 class1 = new MyClass1();
            MyClass2 class2 = new MyClass2();

            class1.whoAreYou();
            class2.whoAreYou();
        }

        public static void MyMethod(object myObject)
        {
            if (myObject.GetType() == typeof(MyInterface))
            {
                MyInterface thisInterface = (MyInterface)myObject;
                thisInterface.whoAreYou();
            }
        }

        public abstract class MyAbstract
        {
            private string editThis;

            public string EditThis
            {
                get { return editThis; }
                set { editThis = value;  }
            }
        }

        public interface MyInterface
        {
            public void whoAreYou();
        }

        public class MyClass1: MyInterface
        {
            public void whoAreYou()
            {
                Console.WriteLine("I am MyClass1");
            }
        }

        public class MyClass2 : MyInterface
        {
            public void whoAreYou()
            {
                Console.WriteLine("I am MyClass2");
            }
        }
    }
}
