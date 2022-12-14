﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class MyStack
    {
        public List<int> myStack = new List<int>();

        public void Push(int n)
        {
            myStack.Add(n);
        }

        public int? Peek()
        {
            if (myStack.Count > 0)
            {
                return myStack[myStack.Count - 1];
            }
            else
            {
                return null;
            }
        }

        public int? Pop()
        {
            if (myStack.Count > 0)
            {
                int? r = myStack[myStack.Count - 1];
                myStack.RemoveAt(myStack.Count - 1);
                return r;
            }
            else
            {
                return null;
            }
        }
    }
}
