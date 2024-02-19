using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Sorting_BubbleSort
{
    internal class Runner
    {
        public static void Run()
        {
            int[] array = { 8,5,2,9,5,6,3 };
            int[] result = Algorithm.BubbleSort(array);
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}
