// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Trie;

namespace Algorithms.Tests.Trie
{
    [TestClass]
    public class SuffixTrieConstructionTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var inputString = "babc";
            var trie = new SuffixTrie();
            SuffixTrieHelper.Insert(trie, inputString);

            var expected = true;
            var actual = SuffixTrieHelper.Contains(trie, "abc");
            Assert.AreEqual(expected, actual);
        }
    }
}
