// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.FirstDuplicateValue
{
    public static class Algorithm
    {
        public static int Run(int[ ] array)
        {
            if(array == null || array.Length == 1)
            {
                return -1;
            }

            foreach(var value in array)
            {
                var aboluteValue = Math.Abs(value);
                if(array[aboluteValue - 1] < 0)
                {
                    return aboluteValue;
                }
                array[aboluteValue - 1] = array[aboluteValue - 1] * -1;
            }

            return -1;
        }
    }
}
