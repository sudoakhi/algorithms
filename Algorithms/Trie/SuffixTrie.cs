using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trie
{
    public class SuffixTrie
    {
        public SuffixTrieNode Root { get; set; }
        public char EndSymbol { get; set; }

        public SuffixTrie()
        {
            Root = new SuffixTrieNode( );
            EndSymbol = '*';
        }
    }
}
