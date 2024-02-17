using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Sorting_BubbleSort
{
    internal class Algorithm
    {
        public static int[] BubbleSort(int[] array)
        {
            for(int i=0; i<array.Length-1; i++)
            {
                for(int j=0; j < array.Length-i-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
