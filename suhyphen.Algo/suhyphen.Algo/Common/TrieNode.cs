using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    public class TrieNode
    {
        internal char Value;
        internal List<TrieNode> Children;
        internal int Depth;
        internal TrieNode Parent;

        public TrieNode(char value, int depth, TrieNode parent)
        {
            Value = value;
            Children = new List<TrieNode>();
            Depth = depth;
            Parent = parent;
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public TrieNode FindChildNode(char c)
        {
            foreach (TrieNode trieNode in Children)
            {
                if (trieNode.Value == c)
                {
                    return trieNode;
                }
            }

            return null;
        }

        public void DeleteChildNode(char c)
        {
            for(int i=0; i< Children.Count; i++)
            {
                if (Children[i].Value == c)
                {
                    Children.RemoveAt(i);
                }
            }
        }
    }
}
