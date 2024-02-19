using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Common
{
    public class BinarySearchTreeNode
    {
        internal int _data;
        internal BinarySearchTreeNode _left;
        internal BinarySearchTreeNode _right;

        public BinarySearchTreeNode(int data)
        {
            _data = data;
            _left = null;
            _right = null;
        }
    }
}
