using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Sorting.SelectionSort
{
    public sealed class Algorithm
    {
        public static int[] SelectionSort(int[] array)
        {
            if(array != null)
            {
                for ( var i = 0; i < array.Length; i++ )
                {
                    var minNumber = array[i];
                    var minNumberIndex = i;
                    for ( var j = i; j < array.Length; j++ )
                    {
                        if ( array[j] < minNumber )
                        {
                            minNumber = array[j];
                            minNumberIndex = j;
                        }
                    }

                    Swap(i , minNumberIndex , array);
                }
            }

            return array;
        }

        public static void Swap(int i, int j, int[] array)
        {
            if( array != null )
            {
                var temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}
