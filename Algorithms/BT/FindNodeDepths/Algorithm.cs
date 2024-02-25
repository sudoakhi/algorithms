using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Algorithms.BT.FindNodeDepths
{
    public static class Algorithm
    {
        public static int Run(BinaryTreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            if(root.Left == null && root.Right == null)
            {
                return 1;
            }

            var sumOfDepths = 0;
            var nodeDepth = 0;
            var currentNode = root;
            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(currentNode);
            while(nodeQueue.Count > 0)
            {
                var numOfNodes = nodeQueue.Count;
                sumOfDepths += numOfNodes * nodeDepth;

                while(numOfNodes > 0)
                {
                    var node = nodeQueue.Dequeue();
                    if(node.Left != null)
                    {
                        nodeQueue.Enqueue(node.Left);
                    }
                    if(node.Right != null)
                    {
                        nodeQueue.Enqueue(node.Right);
                    }

                    numOfNodes--;
                }

                nodeDepth++;
            }

            return sumOfDepths;
        }
    }
}
