// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Stack.NextGreaterElement;

namespace Algorithms.Tests.Stack
{
    [TestClass]
    public class NextGreaterElementTests
    {
        [TestMethod]
        public void TestCase1()
        {
            int[] inputArray = [2, 5, -3, -4, 6, 7, 2];
            int[] expected = [5, 6, 6, 6, 7, -1, 5];
            var result = Algorithm.Run(inputArray);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
