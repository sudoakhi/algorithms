// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Security.Cryptography;
using Algorithms.DP;
using Algorithms.DP.NumberOfWaysToMakeChange;

namespace Algorithms.Tests.DP
{
    [TestClass]
    public class NumberOfWaysToMakeChangeTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var targetMoney = 6;
            int[] coinDenominations = [1, 5];
            var expected = 2;
            var actual = Algorithm.Run(targetMoney, coinDenominations);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase2()
        {
            var targetMoney = 10;
            int[] coinDenominations = [1, 5, 10, 25];
            var expected = 4;
            var actual = Algorithm.Run(targetMoney, coinDenominations);
            Assert.AreEqual(expected, actual);
        }
    }
}
