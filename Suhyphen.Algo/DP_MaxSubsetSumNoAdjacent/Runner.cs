using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.DP_MaxSubsetSumNoAdjacent
{
    internal class Runner
    {
        public static void Run()
        {
            //This should output 330
            int[] array = { 75, 105, 120, 75, 90, 135};
            int result = Algorithm.MaxSubsetSumNoAdjacent(array);
            Console.WriteLine(result);
        }
    }
}
