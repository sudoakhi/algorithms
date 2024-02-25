// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Greedy.MinimumWaitingTime;

namespace Algorithms.Tests.Greedy
{
    [TestClass]
    public class MinimumWaitingTimeTests
    {
        [TestMethod]
        public void TestCase1()
        {
            int[] queries = [3,2,1,2,6];
            var expected = 17;
            var actual = Algorithm.Run(queries);
            Assert.AreEqual(expected, actual);
        }
    }
}
