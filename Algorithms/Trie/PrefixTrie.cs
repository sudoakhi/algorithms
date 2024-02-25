using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Algorithms.Trie
{
    public class PrefixTrie
    {
        public PrefixTrieNode Root { get; set; }

        public PrefixTrie()
        {
            Root = new PrefixTrieNode('^', 0, null);
        }
    }
}
