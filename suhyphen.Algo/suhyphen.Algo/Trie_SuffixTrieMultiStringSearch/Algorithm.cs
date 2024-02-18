using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Trie_SuffixTrieMultiStringSearch
{
    internal class Algorithm
    {
        public static void Insert(SuffixTrie trie, string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                InsertHelper(trie, i, str);
            }
        }

        public static bool Contains(SuffixTrie trie, string str)
        {
            SuffixTrieNode currentNode = trie.Root;
            for(int i=0; i < str.Length; i++)
            {
                char character = str[i];
                if(!currentNode.Children.ContainsKey(character))
                {
                    return false;
                }

                currentNode = currentNode.Children[character];
            }

            return true;
        }

        public static void InsertHelper(SuffixTrie trie, int i, string str)
        {
            SuffixTrieNode currentNode = trie.Root;
            for(int j=i; j < str.Length; j++)
            {
                char character = str[j];
                if(!currentNode.Children.ContainsKey(character))
                {
                    SuffixTrieNode newNode = new SuffixTrieNode();
                    currentNode.Children.Add(character, newNode);
                }

                currentNode = currentNode.Children[character];
            }
        }
    }
}
