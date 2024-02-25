// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trie
{
    public static class SuffixTrieHelper
    {
        public static void Insert(SuffixTrie trie, string str)
        {
            if(str == null)
            {
                return;
            }

            for(var i = 0; i < str.Length; i++)
            {
                InsertHelper(trie, i, str);
            }
        }

        public static bool Contains(SuffixTrie trie, string str)
        {
            if(trie == null)
            {
                return false;
            }

            if(str == null || str.Length == 0)
            {
                return false;
            }

            var endSymbol = trie.EndSymbol;
            var currentNode = trie.Root;
            for(var i = 0; i < str.Length; i++)
            {
                var character = str[i];
                if(!currentNode.Children.TryGetValue(character, out var value))
                {
                    return false;
                }

                currentNode = value;
            }

            return currentNode.Children.ContainsKey(endSymbol);
        }

        public static void InsertHelper(SuffixTrie trie, int i, string str)
        {
            if(trie == null)
            {
                return;
            }

            if(str == null || str.Length == 0)
            {
                return;
            }

            var currentNode = trie.Root;
            var endSymbol = trie.EndSymbol;
            for(var j = i; j < str.Length; j++)
            {
                var character = str[j];
                if(!currentNode.Children.TryGetValue(character, out var value))
                {
                    var newNode = new SuffixTrieNode();
                    value = newNode;
                    currentNode.Children.Add(character, value);
                }

                currentNode = value;
            }

            currentNode.Children[endSymbol] = null;
        }
    }
}
