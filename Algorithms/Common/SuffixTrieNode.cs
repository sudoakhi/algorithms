using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Common
{
    internal sealed class SuffixTrieNode
    {
        internal Dictionary<char, SuffixTrieNode> _children;

        public SuffixTrieNode()
        {
            _children = [ ];
        }
    }
}
