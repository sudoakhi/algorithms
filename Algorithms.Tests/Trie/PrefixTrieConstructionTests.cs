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
    public class PrefixTrieConstructionTests
    {
        [TestMethod]
        public void TestCase1()
        {
            string[] strings = ["the",
                "a",
                "there",
                "answer",
                "any",
                "by",
                "bye",
                "their"];

            var trie = new PrefixTrie();
            foreach(var s in strings)
            {
                PrefixTrieHelper.Insert(trie, s);
            }

            var expected = true;
            var actual = PrefixTrieHelper.Search(trie, "there");
            Assert.AreEqual(expected, actual);

            PrefixTrieHelper.Delete(trie, "there");
            expected = false;
            actual = PrefixTrieHelper.Search(trie, "there");
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = PrefixTrieHelper.Search(trie, "bya");
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = PrefixTrieHelper.Search(trie, "by");
            Assert.AreEqual(expected, actual);
        }
    }
}
