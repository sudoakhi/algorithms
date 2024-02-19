using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Greedy.MinimumWaitingTime
{
    internal static class Runner
    {
        public static void Run()
        {
            //This should return 17
            int[] queries = [3,2,1,2,6];
            var result = Algorithm.MinimumWaitingTime(queries);
            Console.WriteLine(result);
        }
    }
}
