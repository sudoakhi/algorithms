using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.SelectionSort
{
    public static class Algorithm
    {
        public static int[] Run(int[] array)
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

        internal static void Swap(int i, int j, int[] array)
        {
            if( array != null )
            {
                (array [i], array [j]) = (array [j], array [i]);
            }
        }
    }
}
