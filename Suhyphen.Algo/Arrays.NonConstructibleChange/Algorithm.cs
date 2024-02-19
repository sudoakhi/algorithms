using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Suhyphen.Algo.Arrays.NonConstructibleChange
{
    public sealed class Algorithm
    {
        //Time Complexity = O(nlogn)
        //Space Complexity = O(1)

        //{ 1, 1, 2, 3, 5, 7, 22 };
        public static int NonConstructibleChange(int[] coins)
        {
            if (coins != null)
            {
                if (coins.Length == 0)
                {
                    return 1;
                }

                Array.Sort(coins);
                var currentChangeCreated = 0;
                foreach (var coin in coins)
                {
                    if (coin > currentChangeCreated + 1)
                    {
                        return currentChangeCreated + 1;
                    }

                    currentChangeCreated += coin;
                }

                return currentChangeCreated + 1;
            }

            return 1;
        }
    }
}
