using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Trie.SuffixTrieConstruction
	{
    internal static class Algorithm
    {
        public static void Insert(SuffixTrie trie, string str)
        {
            for(var i = 0; i < str.Length; i++)
            {
                InsertHelper(trie, i, str);
            }
        }

        public static bool Contains(SuffixTrie trie, string str)
        {
            var endSymbol = trie.EndSymbol;
            var currentNode = trie.Root;
            for(var i=0; i < str.Length; i++)
            {
                var character = str[i];
                if(!currentNode._children.TryGetValue(character , out var value) )
                {
                    return false;
                }

                currentNode = value;
            }

            return currentNode._children.ContainsKey(endSymbol);
        }

        public static void InsertHelper(SuffixTrie trie, int i, string str)
        {
            var currentNode = trie.Root;
            var endSymbol = trie.EndSymbol;
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

            currentNode._children[endSymbol] = null;
        }
    }
}
