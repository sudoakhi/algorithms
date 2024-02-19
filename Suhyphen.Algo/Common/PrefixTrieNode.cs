﻿using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    public class PrefixTrieNode
    {
        internal char Value;
        internal List<PrefixTrieNode> Children;
        internal int Depth;
        internal PrefixTrieNode Parent;

        public PrefixTrieNode(char value, int depth, PrefixTrieNode parent)
        {
            Value = value;
            Children = new List<PrefixTrieNode>();
            Depth = depth;
            Parent = parent;
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public PrefixTrieNode FindChildNode(char c)
        {
            foreach (PrefixTrieNode trieNode in Children)
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