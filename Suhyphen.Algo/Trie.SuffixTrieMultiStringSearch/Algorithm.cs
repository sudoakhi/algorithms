using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Trie.SuffixTrieMultiStringSearch
{
    public sealed class Algorithm
    {
        public static void Insert(SuffixTrie trie, string str)
        {
            if(str != null)
            {
                for (var i = 0; i < str.Length; i++)
                {
                    InsertHelper(trie, i, str);
                }
            }
        }

        public static bool Contains(SuffixTrie trie, string str)
        {
            if(trie != null && str != null)
            {
                var currentNode = trie.Root;
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

        public static void InsertHelper(SuffixTrie trie, int i, string str)
        {
            if (trie == null)
            {
                return;
            }

            if(str == null)
            {
                return;
            }

            var currentNode = trie.Root;
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
