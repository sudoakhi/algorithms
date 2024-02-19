using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.NonConstructibleChange
{
    internal static class Runner
    {
        internal static void Run()
        {
            // This should output 20
            int[] coins = [5, 7, 1, 1, 2, 3, 22];
            var result = Algorithm.NonConstructibleChange(coins);
            Console.WriteLine(result);
        }
    }
}
