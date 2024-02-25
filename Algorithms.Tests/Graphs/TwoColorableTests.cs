// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Graphs.TwoColorable;

namespace Algorithms.Tests.Graphs
{
    [TestClass]
    public class TwoColorableTests
    {
        [TestMethod]
        public void TestCase1()
        {
            int[][] edges = [
                [1,2],
                [0,2],
                [0,1]
            ];

            var expected = false;
            var actual = Algorithm.Run(edges);
            Assert.AreEqual(expected, actual);
        }
    }
}
