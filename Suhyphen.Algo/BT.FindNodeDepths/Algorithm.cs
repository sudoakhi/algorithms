using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Suhyphen.Algo.BT.FindNodeDepths
{
    public sealed class Algorithm
    {
        public static int GetNodeDepths(BinaryTreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            if (root._left == null && root._right == null)
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
                    if (node._left != null)
                    {
                        nodeQueue.Enqueue(node._left);
                    }
                    if (node._right != null)
                    {
                        nodeQueue.Enqueue(node._right);
                    }

                    numOfNodes--;
                }

                nodeDepth++;
            }

            
            return sumOfDepths;
        }
    }
}
