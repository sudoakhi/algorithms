// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Arrays.LongestPeak;

namespace Algorithms.Tests.Arrays
{
    [TestClass]
    public class LongestPeakTests
    {
        [TestMethod]
        public void TestCase1()
        {
            int[] array4 = [4, 0, 10];
            var expected = 0;
            var actual = Algorithm.Run(array4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase2()
        {
            int[] array1 = [1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3];
            var expected = 6;
            var actual = Algorithm.Run(array1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase3()
        {
            int[] array2 = [1, 2, 3];
            var expected = 0;
            var actual = Algorithm.Run(array2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase4()
        {
            int[] array3 = [1, 4, 10, 2];
            var expected = 4;
            var actual = Algorithm.Run(array3);
            Assert.AreEqual(expected, actual);
        }
    }
}
