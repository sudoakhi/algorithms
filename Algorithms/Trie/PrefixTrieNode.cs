using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trie
{
    public class PrefixTrieNode
    {
        public char Value { get; set; }
        public List<PrefixTrieNode> Children { get; }
        public int Depth { get; set; }
        public PrefixTrieNode Parent { get; set; }

        public PrefixTrieNode(char value, int depth, PrefixTrieNode parent)
        {
            Value = value;
            Children = [];
            Depth = depth;
            Parent = parent;
        }
    }
}
