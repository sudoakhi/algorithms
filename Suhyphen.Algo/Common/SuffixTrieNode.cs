using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Common
{
    public class SuffixTrieNode
    {
        internal Dictionary<char, SuffixTrieNode> _children = [];
    }
}
