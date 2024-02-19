using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Suhyphen.Algo.Common
{
    public class PrefixTrie
    {
        internal PrefixTrieNode Root;

        public PrefixTrie()
        {
            Root = new PrefixTrieNode('^', 0, null);
        }
    }
}
