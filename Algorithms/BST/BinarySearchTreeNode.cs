using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BST
{
    public class BinarySearchTreeNode
    {
        public int Value { get; set; }
        internal BinarySearchTreeNode Left { get; set; }
        internal BinarySearchTreeNode Right { get; set; }

        public BinarySearchTreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
