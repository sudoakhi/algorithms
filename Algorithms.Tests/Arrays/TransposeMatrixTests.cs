// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Arrays.TransposeMatrix;

namespace Algorithms.Tests.Arrays
{
    [TestClass]
    public class TransposeMatrixTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var matrix = new int[1][];
            matrix[0] = new int[2];
            matrix[0][0] = 1;
            matrix[0][1] = 2;
            var expected = new int[2][];
            expected[0] = new int[1];
            expected[1] = new int[1];
            expected[0][0] = 1;
            expected[1][0] = 2;
            var actual = Algorithm.Run(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
