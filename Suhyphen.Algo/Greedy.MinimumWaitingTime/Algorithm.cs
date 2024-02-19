using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Greedy.MinimumWaitingTime
{
    public static class Algorithm
    {
       
        public static int MinimumWaitingTime(int[] queries)
        {
            if(queries != null)
            {
                var minTime = 0;
                Array.Sort(queries);
                var minWaitingTime = new int[queries.Length];
                minWaitingTime[0] = 0;
                for ( var i = 1; i < queries.Length; i++ )
                {
                    minWaitingTime[i] = minWaitingTime[i - 1] + queries[i - 1];
                    minTime += minWaitingTime[i];
                }

                return minTime;
            }

            return -1;
        }
    }
}
