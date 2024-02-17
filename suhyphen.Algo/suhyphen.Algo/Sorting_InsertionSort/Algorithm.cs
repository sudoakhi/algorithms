using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Sorting_InsertionSort
{
    internal class Algorithm
    {
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    Swap(j, j - 1, array);
                    j--;
                }
            }

            return array;
        }

        public static void Swap(int i, int j, int[] array)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
