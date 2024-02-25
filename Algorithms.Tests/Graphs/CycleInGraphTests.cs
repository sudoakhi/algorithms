// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Graphs;
using Algorithms.Graphs.CycleInGraph;

namespace Algorithms.Tests.Graphs
{
    [TestClass]
    public class CycleInGraphTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var edge1 = new Edge("0", "1", 0);
            var edge2 = new Edge("0", "3", 0);
            var edge3 = new Edge("1", "2", 0);
            var edge4 = new Edge("1", "3", 0);
            var edge5 = new Edge("1", "4", 0);
            var edge6 = new Edge("2", "0", 0);
            var edge7 = new Edge("3", "null", 0);
            var edge8 = new Edge("4", "2", 0);
            var edge9 = new Edge("4", "5", 0);
            var edge10 = new Edge("5", "null", 0);

            var edgeList = new List<Edge>
            {
                edge1,
                edge2,
                edge3,
                edge4,
                edge5,
                edge6,
                edge7,
                edge8,
                edge9,
                edge10
            };

            var graph = new Graph(edgeList);
            var expected = true;
            var actual = Algorithm.Run(graph);
            Assert.AreEqual(expected, actual);
        }
    }
}
