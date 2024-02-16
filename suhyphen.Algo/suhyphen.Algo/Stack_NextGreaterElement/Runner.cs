using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.NextGreaterElement
{
    internal class Runner
    {
        public static void Run()
        {
            int[] inputArray = { 2, 5, -3, -4, 6, 7, 2 };
            int[] result = Algorithm.NextGreaterElement(inputArray);
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}
