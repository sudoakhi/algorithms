using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace suhyphen.Algo.MinMaxStackConstruction
{
    internal class Algorithm
    {
        static List<int> stack = new List<int>();
        static List<int> minStack = new List<int>();
        static List<int> maxStack = new List<int>();
        public static int Peek()
        {
            return stack[stack.Count -1];
        }

        public static int Pop()
        {
            int value = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            minStack.RemoveAt(minStack.Count - 1);
            maxStack.RemoveAt(maxStack.Count - 1);
            return value;
        }

        public static void Push(int number)
        {
            stack.Add(number);
            if(minStack.Count == 0)
            {
                minStack.Add(number);
            } else
            {
                int minNumber = minStack[minStack.Count - 1];
                if(number < minNumber)
                {
                    minStack.Add(number);
                }
                else
                {
                    minStack.Add(minNumber);
                }
            }

            if (maxStack.Count == 0)
            {
                maxStack.Add(number);
            }
            else
            {
                int maxNumber = maxStack[maxStack.Count - 1];
                if(number > maxNumber)
                {
                    maxStack.Add(number);
                }
                else
                {
                    maxStack.Add(maxNumber);
                }
            }
        }

        public static int GetMin()
        {
            return minStack[minStack.Count - 1];
        }

        public static int GetMax()
        {
            return maxStack[maxStack.Count - 1];
        }
    }
}
