using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BT
{
    public static class BinaryTreeHelper
    {
        public static void Insert(BinaryTree binaryTree, int value)
        {
            if(binaryTree == null)
            {
                return;
            }

            var newBinaryTreeNode = new BinaryTreeNode(value);

            if(binaryTree.Root == null)
            {
                binaryTree.Root = newBinaryTreeNode;
                return;
            }

            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(binaryTree.Root);
            while(nodeQueue.Count > 0)
            {
                var currentNode = nodeQueue.Dequeue();
                if(currentNode.Left == null)
                {
                    newBinaryTreeNode.Parent = currentNode;
                    currentNode.Left = newBinaryTreeNode;
                    return;
                }
                else if(currentNode.Right == null)
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

        public static void RecursiveInorderTraversal(BinaryTreeNode binaryTreeNode)
        {
            if(binaryTreeNode == null)
            {
                return;
            }

            RecursiveInorderTraversal(binaryTreeNode.Left);
            Console.Write(binaryTreeNode.Value + " ");
            RecursiveInorderTraversal(binaryTreeNode.Right);
        }
    }
}
