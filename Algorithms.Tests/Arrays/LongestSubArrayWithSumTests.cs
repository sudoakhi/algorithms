// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Arrays.LongestSubArrayWithSum;

namespace Algorithms.Tests.Arrays
{
    [TestClass]
    public class LongestSubArrayWithSumTests
    {
        [TestMethod]
        public void TestCase1()
        {
            int[] array = [1 ,2, 3, 4, 3, 3, 1, 2, 1, 2];
            var targetSum = 10;
            int[] expected = [4,8];
            var actual = Algorithm.Run(array, targetSum);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase1BruteForce()
        {
            int[] array = [1, 2, 3, 4, 3, 3, 1, 2, 1, 2];
            var targetSum = 10;
            int[] expected = [4,8];
            var actual = Algorithm.RunBruteForce(array, targetSum);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase2()
        {
            int[] array = [1, 2, 3];
            var targetSum = 10;
            int[] expected = [];
            var actual = Algorithm.Run(array, targetSum);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase3()
        {
            int[] array = [10];
            var targetSum = 10;
            int[] expected = [0,0];
            var actual = Algorithm.Run(array, targetSum);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase4()
        {
            //This should return [0, 0]
            int[] array4 = [0];
            var targetSum = 0;
            int[] expected = [0,0];
            var actual = Algorithm.Run(array4, targetSum);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
