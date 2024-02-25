// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Arrays.WaterfallStreams;

namespace Algorithms.Tests.Arrays
{
    [TestClass]
    public class WaterfallStreamsTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var array = new double[7][];
            array[0] = [0, 0, 0, 0, 0, 0, 0];
            array[1] = [1, 0, 0, 0, 0, 0, 0];
            array[2] = [0, 0, 1, 1, 1, 0, 0];
            array[3] = [0, 0, 0, 0, 0, 0, 0];
            array[4] = [1, 1, 1, 0, 0, 1, 0];
            array[5] = [0, 0, 0, 0, 0, 0, 1];
            array[6] = [0, 0, 0, 0, 0, 0, 0];
            var source = 3;
            double[] expected = [0, 0, 0, 25, 25, 0, 0];
            var actual = Algorithm.Run(array, source);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase2()
        {
            var array = new double[2][];
            array[0] = [0, 0, 0, 0, 0, 0, 0];
            array[1] = [1, 0, 0, 0, 0, 0, 0];
            var source = 2;
            double[] expected = [0, 0, 100, 0, 0, 0, 0];
            var actual = Algorithm.Run(array, source);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase3()
        {
            var array = new double[1][];
            array[0] = [0, 0, 0, 0, 0, 0, 0];
            var source = 2;
            double[] expected = [0, 0, 100, 0, 0, 0, 0];
            var actual = Algorithm.Run(array, source);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase4()
        {
            var array = new double[7][];
            array[0] = [0, 0, 0, 0, 0, 0, 0];
            array[1] = [1, 0, 0, 0, 0, 0, 0];
            array[2] = [0, 0, 1, 1, 1, 0, 0];
            array[3] = [0, 0, 0, 0, 0, 0, 0];
            array[4] = [1, 1, 1, 0, 0, 1, 0];
            array[5] = [0, 0, 0, 0, 1, 0, 1];
            array[6] = [0, 0, 0, 0, 0, 0, 0];
            var source = 3;
            double[] expected = [0, 0, 0, 37.5, 0, 0, 0];
            var actual = Algorithm.Run(array, source);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
