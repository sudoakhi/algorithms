using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    internal class BinaryTreeHelper
    {
        public static void Insert(BinaryTree binaryTree, int value)
        {
            BinaryTreeNode newBinaryTreeNode = new BinaryTreeNode(value);

            if (binaryTree.Root == null)
            {
                binaryTree.Root = newBinaryTreeNode;
                return;
            }

            Queue<BinaryTreeNode> nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(binaryTree.Root);
            while (nodeQueue.Count > 0)
            {
                BinaryTreeNode currentNode = nodeQueue.Dequeue();
                if (currentNode.Left == null)
                {
                    newBinaryTreeNode.Parent = currentNode;
                    currentNode.Left = newBinaryTreeNode;
                    return;
                }
                else if (currentNode.Right == null)
                {
                    newBinaryTreeNode.Parent = currentNode;
                    currentNode.Right = newBinaryTreeNode;
                    return;
                }
                else
                {
                    nodeQueue.Enqueue(currentNode.Left);
                    nodeQueue.Enqueue(currentNode.Right);
                }
            }
        }

        internal static void RecursiveInorderTraversal(BinaryTreeNode binaryTreeNode)
        {
            if (binaryTreeNode == null)
            {
                return;
            }

            RecursiveInorderTraversal(binaryTreeNode.Left);
            Console.Write(binaryTreeNode.Value + " ");
            RecursiveInorderTraversal(binaryTreeNode.Right);
        }
    }
}
