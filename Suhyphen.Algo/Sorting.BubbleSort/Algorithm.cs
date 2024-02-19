using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Sorting.BubbleSort
{
    public sealed class Algorithm
    {
        public static int[] BubbleSort(int[] array)
        {
            if(array != null)
            {
                for (var i = 0; i < array.Length - 1; i++)
                {
                    for (var j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            var temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            return array;
        }
    }
}
