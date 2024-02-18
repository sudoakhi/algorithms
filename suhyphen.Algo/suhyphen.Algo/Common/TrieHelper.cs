using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace suhyphen.Algo.Common
{
    public class TrieHelper
    {
        public static TrieNode Prefix(Trie trie, string s)
        {
            TrieNode currentNode = trie.Root;
            TrieNode resultNode = currentNode;
            foreach(char c in s)
            {
                currentNode = currentNode.FindChildNode(c);
                if(currentNode == null)
                {
                    break;
                }

                resultNode = currentNode;
            }

            return resultNode;
        }

        public static void Insert(Trie trie, string s)
        {
            TrieNode prefixNode = Prefix(trie, s);
            TrieNode currentNode = prefixNode;
            for(int i = currentNode.Depth; i < s.Length; i++)
            {
                TrieNode newNode = new TrieNode(s[i], currentNode.Depth+1, currentNode);
                currentNode.Children.Add(newNode);
                currentNode = newNode;
            }

            currentNode.Children.Add(new TrieNode('$', currentNode.Depth + 1, currentNode));
        }

        public static void Delete(Trie trie, string s)
        {
            if(Search(trie,s)) {
                TrieNode trieNode = Prefix(trie, s).FindChildNode('$'); ;
                while(trieNode.IsLeaf()) 
                {
                    TrieNode parent = trieNode.Parent;
                    parent.DeleteChildNode(trieNode.Value);
                    trieNode = parent;
                }
            }
        }

        public static bool Search(Trie trie, string s)
        {
            TrieNode prefixNode = Prefix(trie, s);
            if(prefixNode.Depth == s.Length && prefixNode.FindChildNode('$') != null)
            {
                return true;
            }

            return false;
        }
    }
}
