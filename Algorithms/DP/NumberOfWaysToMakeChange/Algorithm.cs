﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DP.NumberOfWaysToMakeChange
{
    public static class Algorithm
    {
        // Space Complexity = O(N) where N is equal to targetMoney
        // Time Complexity = O(N*D) where N is equal to targetMoney and D is equal to number of denominations
        public static int Run(int targetMoney, int[ ] coinDenominations)
        {
            if(coinDenominations == null || coinDenominations.Length == 0)
            {
                return 0;
            }

            var numOfWays = new int[targetMoney+1];
            numOfWays[0] = 1;

            foreach(var coin in coinDenominations)
            {
                for(var amount = 1; amount < targetMoney + 1; amount++)
                {
                    if(coin <= amount)
                    {
                        numOfWays[amount] = numOfWays[amount] + numOfWays[amount - coin];
                    }
                }
            }

            return numOfWays[targetMoney];
        }
    }
}
