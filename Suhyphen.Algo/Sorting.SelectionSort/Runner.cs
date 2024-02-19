using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Sorting.SelectionSort
{
    internal static class Runner
    {
        public static void Run()
        {
            int[] array = [8,5,2,9,5,6,3];
            var result = Algorithm.SelectionSort(array);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
