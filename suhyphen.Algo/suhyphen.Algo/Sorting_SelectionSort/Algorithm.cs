using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Sorting_SelectionSort
{
    internal class Algorithm
    {
        public static int[] SelectionSort(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                int minNumber = array[i];
                int minNumberIndex = i;
                for(int j=i; j<array.Length; j++)
                {
                    if (array[j] < minNumber)
                    {
                        minNumber = array[j];
                        minNumberIndex = j;
                    }
                }

                Swap(i, minNumberIndex, array);
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
