using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Greedy_MinimumWaitingTime
{
    internal class Runner
    {
        public static void Run()
        {
            //This should return 17
            int[] queries = { 3,2,1,2,6 };
            int result = Algorithm.MinimumWaitingTime(queries);
            Console.WriteLine(result);
        }
    }
}
