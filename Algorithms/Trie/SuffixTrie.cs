using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trie
{
    internal sealed class SuffixTrie
    {
        internal SuffixTrieNode _root;
        internal char _endSymbol = '*';

        public SuffixTrie()
        {
            _root = new SuffixTrieNode( );
        }
    }
}
