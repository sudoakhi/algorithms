using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace suhyphen.Algo.BST_FindClosestValue
{
    internal class Algorithm
    {
        public static int FindClosestValueInBst(BinarySearchTreeNode root, int target)
        {
            if(root == null)
            {
                return -1;
            }

            if(root.Right == null && root.Left == null) 
            {
                return root.Data;
            }

            int minTargetDifference = int.MaxValue;
            BinarySearchTreeNode targetNode = root;
            BinarySearchTreeNode currentNode = root;
            while (currentNode != null)
            {
                int targetDifference = Math.Abs(target - currentNode.Data);
                if(targetDifference < minTargetDifference)
                {
                    minTargetDifference = targetDifference;
                    targetNode = currentNode;
                }

                if(target < currentNode.Data)
                {
                    currentNode = currentNode.Left;
                } else
                {
                    currentNode = currentNode.Right;
                }
            }

            return targetNode.Data;
        }
    }
}
