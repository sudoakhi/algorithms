using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Greedy_MinimumWaitingTime
{
    internal class Algorithm
    {
       
        public static int MinimumWaitingTime(int[] queries)
        {
            int minTime = 0;
            Array.Sort(queries);
            int[] minWaitingTime = new int[queries.Length];
            minWaitingTime[0] = 0;
            for(int i = 1; i < queries.Length; i++)
            {
                minWaitingTime[i] = minWaitingTime[i - 1] + queries[i-1];
                minTime += minWaitingTime[i];
            }

            return minTime;
        }
    }
}
