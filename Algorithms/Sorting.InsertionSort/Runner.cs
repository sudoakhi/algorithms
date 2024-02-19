using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.InsertionSort
{
    internal static class Runner
    {
        internal static void Run()
        {
            int[] array = [8,5,2,9,5,6,3];
            var result = Algorithm.InsertionSort(array);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
