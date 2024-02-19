using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Common
{
    public class SuffixTrie
    {
        internal SuffixTrieNode Root;
        internal char EndSymbol = '*';

        public SuffixTrie()
        {
            Root = new SuffixTrieNode();
        }
    }
}
