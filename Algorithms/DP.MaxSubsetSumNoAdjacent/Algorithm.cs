// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DP.MaxSubsetSumNoAdjacent
{
    internal static class Algorithm
    {
        // Time Compexity = O(N), N = Length of the array
        // Space Complexity = O(1)
        public static int MaxSubsetSumNoAdjacent(int[ ] array)
        {
            if(array == null || array.Length == 0)
            {
                return 0;
            }

            if(array.Length == 1 )
            {
                return array[0];
            }
            
            var first = array[0];
            var second = GetMax(array[0], array[1]);
            for(var i=2; i<array.Length; i++)
            {
                var current = GetMax(second, first + array[i]);
                first = second;
                second = current;
            }

            return second;
        }

        private static int GetMax(int a, int b)
        {
            return a < b ? b : a;
        }
    }
}
