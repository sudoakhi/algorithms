using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.InsertionSort
{
    public static class Algorithm
    {
        public static int[] Run(int[] array)
        {
            if (array != null)
            {
                for (var i = 1; i < array.Length; i++)
                {
                    var j = i;
                    while (j > 0 && array[j] < array[j - 1])
                    {
                        Swap(j, j - 1, array);
                        j--;
                    }
                }
            }
            
            return array;
        }

        internal static void Swap(int i, int j, int[] array)
        {
            if(array != null)
            {
                (array [i], array [j]) = (array [j], array [i]);
            }
        }
    }
}
