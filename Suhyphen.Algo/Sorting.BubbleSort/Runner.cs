using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Sorting.BubbleSort
{
    internal static class Runner
    {
        public static void Run()
        {
            int[] array = [8,5,2,9,5,6,3];
            var result = Algorithm.BubbleSort(array);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
