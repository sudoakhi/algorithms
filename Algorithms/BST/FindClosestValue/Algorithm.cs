using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Algorithms.BST.FindClosestValue
{
    public static class Algorithm
    {
        public static int Run(BinarySearchTreeNode root, int target)
        {
            if(root == null)
            {
                return -1;
            }

            if(root.Right == null && root.Left == null)
            {
                return root.Value;
            }

            var minTargetDifference = int.MaxValue;
            var targetNode = root;
            var currentNode = root;
            while(currentNode != null)
            {
                var targetDifference = Math.Abs(target - currentNode.Value);
                if(targetDifference < minTargetDifference)
                {
                    minTargetDifference = targetDifference;
                    targetNode = currentNode;
                }

                currentNode = target < currentNode.Value ? currentNode.Left : currentNode.Right;
            }

            return targetNode.Value;
        }
    }
}
