using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Arrays_NonConstructibleChange
{
    internal class Runner
    {
        public static void Run()
        {
            // This should output 20
            int[] coins = { 5, 7, 1, 1, 2, 3, 22 };
            int result = Algorithm.NonConstructibleChange(coins);
            Console.WriteLine(result);
        }
    }
}
