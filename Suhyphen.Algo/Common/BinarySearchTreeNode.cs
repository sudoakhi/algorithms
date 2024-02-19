using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    internal class BinarySearchTreeNode
    {
        internal int Data;
        internal BinarySearchTreeNode Left;
        internal BinarySearchTreeNode Right;

        public BinarySearchTreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
