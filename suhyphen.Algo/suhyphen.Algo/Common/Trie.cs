using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace suhyphen.Algo.Common
{
    public class Trie
    {
        internal TrieNode Root;

        public Trie()
        {
            Root = new TrieNode('^', 0, null);
        }
    }
}
