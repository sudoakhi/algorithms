using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Common
{
    internal static class BinaryTreeHelper
    {
        public static void Insert(BinaryTree binaryTree, int value)
        {
            var newBinaryTreeNode = new BinaryTreeNode(value);

            if (binaryTree._root == null)
            {
                binaryTree._root = newBinaryTreeNode;
                return;
            }

            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(binaryTree._root);
            while (nodeQueue.Count > 0)
            {
                var currentNode = nodeQueue.Dequeue();
                if (currentNode._left == null)
                {
                    newBinaryTreeNode._parent = currentNode;
                    currentNode._left = newBinaryTreeNode;
                    return;
                }
                else if (currentNode._right == null)
                {
                    newBinaryTreeNode._parent = currentNode;
                    currentNode._right = newBinaryTreeNode;
                    return;
                }
                else
                {
                    nodeQueue.Enqueue(currentNode._left);
                    nodeQueue.Enqueue(currentNode._right);
                }
            }
        }

        internal static void RecursiveInorderTraversal(BinaryTreeNode binaryTreeNode)
        {
            if (binaryTreeNode == null)
            {
                return;
            }

            RecursiveInorderTraversal(binaryTreeNode._left);
            Console.Write(binaryTreeNode._value + " ");
            RecursiveInorderTraversal(binaryTreeNode._right);
        }
    }
}
