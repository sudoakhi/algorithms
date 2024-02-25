using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trie
{
    public class SuffixTrieNode
    {
        public Dictionary<char, SuffixTrieNode> Children {  get; }

        public SuffixTrieNode()
        {
            Children = [];
        }
    }
}
