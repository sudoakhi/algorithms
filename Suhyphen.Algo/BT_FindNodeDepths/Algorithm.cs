using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace suhyphen.Algo.BT_FindNodeDepths
{
    internal class Algorithm
    {
        public static int GetNodeDepths(BinaryTreeNode root)
        {
            if(root == null)
                return 0;

            if(root.Left == null && root.Right == null) 
                return 1;

            int sumOfDepths = 0;
            int nodeDepth = 0;
            BinaryTreeNode currentNode = root;
            Queue<BinaryTreeNode> nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(currentNode);
            while(nodeQueue.Count > 0)
            {
                int numOfNodes = nodeQueue.Count;
                sumOfDepths += numOfNodes * nodeDepth;

                while(numOfNodes > 0)
                {
                    BinaryTreeNode node = nodeQueue.Dequeue();
                    if (node.Left != null)
                    {
                        nodeQueue.Enqueue(node.Left);
                    }
                    if (node.Right != null)
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
