using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Algorithms.BST.FindClosestValue
{
    internal static class Algorithm
    {
        internal static int FindClosestValueInBst(BinarySearchTreeNode root, int target)
        {
            if(root == null)
            {
                return -1;
            }

            if(root._right == null && root._left == null) 
            {
                return root._data;
            }

            var minTargetDifference = int.MaxValue;
            var targetNode = root;
            var currentNode = root;
            while (currentNode != null)
            {
                var targetDifference = Math.Abs(target - currentNode._data);
                if(targetDifference < minTargetDifference)
                {
                    minTargetDifference = targetDifference;
                    targetNode = currentNode;
                }

                currentNode = target < currentNode._data ? currentNode._left : currentNode._right;
                }

            return targetNode._data;
        }
    }
}
