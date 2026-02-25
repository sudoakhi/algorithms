// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Strings.GroupAnagrams;

namespace Algorithms.Tests.Strings
{
    [TestClass]
    public class GroupAnagramsTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var input = new List<string> { "yo", "oy"};
            var expected = new List<List<string>>();
            var output = new List<string> { "yo", "oy"};
            expected.Add(output);
            var actual = Algorithm.Run(input);
            Console.WriteLine(actual);
            Console.WriteLine(expected);
            Assert.AreEqual(expected, actual);
        }
    }
}
