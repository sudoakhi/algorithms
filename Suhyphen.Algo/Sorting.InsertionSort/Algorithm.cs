using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Sorting.InsertionSort
{
    public sealed class Algorithm
    {
        public static int[] InsertionSort(int[] array)
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

        public static void Swap(int i, int j, int[] array)
        {
            if(array != null)
            {
                var temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}
