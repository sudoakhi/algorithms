// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Security.Cryptography;
using Algorithms.DP.MaxSubsetSumNoAdjacent;

namespace Algorithms.Tests.DP
{
    [TestClass]
    public class MaxSubsetSumNoAdjacentTests
    {
        [TestMethod]
        public void TestCase1()
        {
            int[] array = [75, 105, 120, 75, 90, 135];
            var expected = 330;
            var actual = Algorithm.Run(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
