﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting.BubbleSort
{
   public static class Algorithm
    {
        public static int[] Run(int[] array)
        {
            if(array != null)
            {
                for (var i = 0; i < array.Length - 1; i++)
                {
                    for (var j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            (array [j + 1], array [j]) = (array [j], array [j + 1]);
                        }
                    }
                }
            }

            return array;
        }
    }
}
