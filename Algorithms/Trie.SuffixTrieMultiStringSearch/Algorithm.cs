using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trie.SuffixTrieMultiStringSearch
{
    internal static class Algorithm
    {
        internal static void Insert(SuffixTrie trie, string str)
        {
            if(str != null)
            {
                for (var i = 0; i < str.Length; i++)
                {
                    InsertHelper(trie, i, str);
                }
            }
        }

        internal static bool Contains(SuffixTrie trie, string str)
        {
            if(trie != null && str != null)
            {
                var currentNode = trie._root;
                for (var i = 0; i < str.Length; i++)
                {
                    var character = str[i];
                    if (!currentNode._children.TryGetValue(character, out var value))
                    {
                        return false;
                    }

                    currentNode = value;
                }
            }

            return true;
        }

        internal static void InsertHelper(SuffixTrie trie, int i, string str)
        {
            if (trie == null)
            {
                return;
            }

            if(str == null)
            {
                return;
            }

            var currentNode = trie._root;
            for(var j=i; j < str.Length; j++)
            {
                var character = str[j];
                if(!currentNode._children.TryGetValue(character , out var value) )
                {
                    var newNode = new SuffixTrieNode();
                    value = newNode;
                    currentNode._children.Add(character, value);
                }

                currentNode = value;
            }
        }
    }
}
