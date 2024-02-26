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
    public static class PrefixTrieHelper
    {
        public static PrefixTrieNode Prefix(PrefixTrie trie, string s)
        {
            if(trie == null)
            {
                return null;
            }

            if(s == null)
            {
                return null;
            }

            var currentNode = trie.Root;
            var resultNode = currentNode;
            foreach(var c in s)
            {
                currentNode = FindChildNode(currentNode, c);
                if(currentNode == null)
                {
                    break;
                }

                resultNode = currentNode;
            }

            return resultNode;
        }

        public static void Insert(PrefixTrie trie, string s)
        {
            if(trie == null )
            {
                return;
            }

            if(s == null )
            {
                return;
            }

            var prefixNode = Prefix(trie, s);
            var currentNode = prefixNode;
            for(var i = currentNode.Depth; i < s.Length; i++)
            {
                var newNode = new PrefixTrieNode(s[i], currentNode.Depth + 1, currentNode);
                currentNode.Children.Add(newNode);
                currentNode = newNode;
            }

            currentNode.Children.Add(new PrefixTrieNode('$', currentNode.Depth + 1, currentNode));
        }

        public static void Delete(PrefixTrie trie, string s)
        {
            if(Search(trie, s))
            {
                var trieNode = FindChildNode(Prefix(trie, s), '$');
                while(IsLeaf(trieNode))
                {
                    var parent = trieNode.Parent;
                    DeleteChildNode(parent, trieNode.Value);
                    trieNode = parent;
                }
            }
        }

        public static bool Search(PrefixTrie trie, string s)
        {
            if(trie == null)
            {
                return false;
            }

            if(s == null)
            {
                return false;
            }

            var prefixNode = Prefix(trie, s);
            return prefixNode.Depth == s.Length && FindChildNode(prefixNode, '$') != null;
        }

        private static bool IsLeaf(PrefixTrieNode node)
        {
            return node.Children.Count == 0;
        }

        private static PrefixTrieNode FindChildNode(PrefixTrieNode node, char c)
        {
            if(node == null)
            {
                return null;
            }

            foreach(var trieNode in node.Children)
            {
                if(trieNode.Value == c)
                {
                    return trieNode;
                }
            }

            return null;
        }

        private static void DeleteChildNode(PrefixTrieNode node, char c)
        {
            if(node == null)
            {
                return;
            }

            for(var i = 0; i < node.Children.Count; i++)
            {
                if(node.Children[i].Value == c)
                {
                    node.Children.RemoveAt(i);
                }
            }
        }
    }
}
