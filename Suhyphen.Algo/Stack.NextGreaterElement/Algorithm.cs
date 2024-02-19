using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Stack.NextGreaterElement
{
    public sealed class Algorithm
    {
        public static int[] NextGreaterElement(int[] array)
        {
            if(array != null)
            {
                var result = new int[array.Length];
                Array.Fill(result , -1);

                var stack = new Stack<int>();
                for ( var i = 0; i < 2 * array.Length; i++ )
                {
                    var circularIdx  = i % array.Length;

                    while ( stack.Count > 0 && array[stack.Peek()] < array[circularIdx] )
                    {
                        var top = stack.Pop();
                        result[top] = array[circularIdx];
                    }

                    stack.Push(circularIdx);
                }

                return result;
            }

            return null;
        }
    }
}
