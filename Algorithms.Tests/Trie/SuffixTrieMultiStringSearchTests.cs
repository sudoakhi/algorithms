// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Trie;
using Algorithms.Trie.SuffixTrieMultiStringSearch;

namespace Algorithms.Tests.Trie
{
    [TestClass]
    public class SuffixTrieMultiStringSearchTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var trie = new SuffixTrie();
            var bigString = "abcdefghijklmnopqrstuvwxyz";
            if(bigString.Contains(' ', StringComparison.Ordinal))
            {
                var inputStringArray = bigString.Split(" ");
                foreach(var s in inputStringArray)
                {
                    Algorithm.Insert(trie, s);
                }
            }
            else
            {
                Algorithm.Insert(trie, bigString);
            }

            string[] smallerString = ["abc", "mnopqr", "wyz", "no", "e", "tuuv"];
            bool[] expected = [true, true, false, true, true, false];
            var actual = new bool[smallerString.Length];
            for(var i = 0; i < smallerString.Length; i++)
            {
                if(Algorithm.Contains(trie, smallerString[i]))
                {
                    actual[i] = true;
                }
            }

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
