// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sorting.InsertionSort;

namespace Algorithms.Tests.Sorting
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void TestCase1()
        {
            int[] array = [8,5,2,9,5,6,3];
            int[] expected = [2, 3, 5, 5, 6, 8, 9];
            var actual = Algorithm.Run(array);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
