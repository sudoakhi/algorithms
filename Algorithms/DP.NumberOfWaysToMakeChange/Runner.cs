// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DP.NumberOfWaysToMakeChange
{
    internal static class Runner
    {
        internal static void Run()
        {
            //This should return 2
            var targetMoney = 6;
            int[] coinDenominations = [1, 5];
            var result = Algorithm.NumberOfWaysToMakeChange(targetMoney, coinDenominations);
            Console.WriteLine(result);

            //This should return 4
            targetMoney = 10;
            coinDenominations = [1, 5, 10, 25];
            result = Algorithm.NumberOfWaysToMakeChange(targetMoney, coinDenominations);
            Console.WriteLine(result);
        }
    }
}
