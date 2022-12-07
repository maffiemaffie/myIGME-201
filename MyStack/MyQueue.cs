using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class MyQueue
    {
        private List<int> values;

        public MyQueue ()
        {
            values = new List<int> ();
        }

        public void Enqueue(int n) { values.Add (n); }

        public int Dequeue()
        {
            int n = values[0];
            values.RemoveAt(0);
            return n;
        }

        public int Peek()
        {
            return values[0];
        }
    }
}
