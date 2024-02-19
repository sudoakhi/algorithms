using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Stack_NextGreaterElement
{
    internal class Algorithm
    {
        public static int[] NextGreaterElement(int[] array)
        {
            int[] result = new int[array.Length];
            Array.Fill(result, -1);

            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < 2 * array.Length; i++)
            {
                int circularIdx  = i % array.Length;

                while(stack.Count > 0 && array[stack.Peek()] < array[circularIdx]) 
                {
                    int top = stack.Pop();
                    result[top] = array[circularIdx];
                }

                stack.Push(circularIdx);
            }

            return result;

        }
    }
}
