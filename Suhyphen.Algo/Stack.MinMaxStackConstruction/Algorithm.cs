using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Suhyphen.Algo.Stack.MinMaxStackConstruction
{
    public sealed class Algorithm
    {
        private static readonly List<int> s_stack = [];
        private static readonly List<int> s_minStack = [];
        private static readonly List<int> s_maxStack = [];
        public static int Peek()
        {
            return s_stack.Count == 0 ? -1 : s_stack[^1];
        }

        public static int Pop()
        {
            if (s_stack.Count == 0)
            {
                return -1;
            }

            var value = s_stack[^1];
            s_stack.RemoveAt(s_stack.Count - 1);
            s_minStack.RemoveAt(s_minStack.Count - 1);
            s_maxStack.RemoveAt(s_maxStack.Count - 1);
            return value;
        }

        public static void Push(int number)
        {
            s_stack.Add(number);
            if(s_minStack.Count == 0)
            {
                s_minStack.Add(number);
            } else
            {
                var minNumber = s_minStack[^1];
                if(number < minNumber)
                {
                    s_minStack.Add(number);
                }
                else
                {
                    s_minStack.Add(minNumber);
                }
            }

            if (s_maxStack.Count == 0)
            {
                s_maxStack.Add(number);
            }
            else
            {
                var maxNumber = s_maxStack[^1];
                if(number > maxNumber)
                {
                    s_maxStack.Add(number);
                }
                else
                {
                    s_maxStack.Add(maxNumber);
                }
            }
        }

        public static int GetMin()
        {
            return s_minStack.Count == 0 ? -1 : s_minStack[^1];
        }

        public static int GetMax()
        {
            return s_maxStack.Count == 0 ? -1 : s_maxStack[^1];
        }
    }
}
