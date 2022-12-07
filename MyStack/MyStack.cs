using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class MyStack
    {
        private List<int> values;

        public MyStack()
        {
            this.values = new List<int>();
        }

        public void Push(int n)
        {
            values.Add(n);
        }

        public int Pop()
        {
            int n = values[values.Count - 1];
            values.RemoveAt(values.Count - 1);
            return n;
        }

        public int Peek()
        {
            return values[values.Count - 1];
        }
    }
}
