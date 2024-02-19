using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Stack.NextGreaterElement
{
    internal static class Runner
    {
        public static void Run()
        {
            int[] inputArray = [2, 5, -3, -4, 6, 7, 2];
            var result = Algorithm.NextGreaterElement(inputArray);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
