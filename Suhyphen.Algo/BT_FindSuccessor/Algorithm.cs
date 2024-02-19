using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;

namespace suhyphen.Algo.BT_FindSuccessor
{
    internal class Algorithm
    {
        internal static BinaryTreeNode FindSuccessorOptimalByNode(BinaryTreeNode inputBinaryTreeNode)
        {
            if (inputBinaryTreeNode.Right != null)
            {
                return GetLeftMostChild(inputBinaryTreeNode.Right);
            }

            return GetRightMostParent(inputBinaryTreeNode);
        }
        internal static int? FindSuccessorSubOptimalByValue(BinaryTree binaryTree, int inputValue)
        {
            List<int> inOrderTraversalOrderValues = new List<int>();
            GetInOrderTraversalOrderByValue(binaryTree.Root, inOrderTraversalOrderValues);

            for (int i = 0; i < inOrderTraversalOrderValues.Count; i++)
            {
                int value = inOrderTraversalOrderValues[i];
                if (value != inputValue)
                {
                    continue;
                }

                if (i == inOrderTraversalOrderValues.Count - 1)
                {
                    return null;
                }

                return inOrderTraversalOrderValues[i + 1];
            }

            return null;
        }
        internal static BinaryTreeNode FindSuccessorSubOptimalByNode(BinaryTree binaryTree, BinaryTreeNode inputBinaryTreeNode)
        {
            List<BinaryTreeNode> inOrderTraversalNodes = new List<BinaryTreeNode>();
            GetInOrderTraversalOrderByNodes(binaryTree.Root, inOrderTraversalNodes);
            for (int i = 0; i < inOrderTraversalNodes.Count; i++)
            {
                BinaryTreeNode currentNode = inOrderTraversalNodes[i];
                if (currentNode != inputBinaryTreeNode)
                {
                    continue;
                }

                if (i == inOrderTraversalNodes.Count - 1)
                {
                    return null;
                }

                return inOrderTraversalNodes[i + 1];
            }

            return null;
        }
        private static BinaryTreeNode GetRightMostParent(BinaryTreeNode node)
        {
            BinaryTreeNode currentNode = node;
            while (currentNode.Parent != null && currentNode.Parent.Right == currentNode)
            {
                currentNode = currentNode.Parent;
            }

            return currentNode.Parent;
        }
        private static BinaryTreeNode GetLeftMostChild(BinaryTreeNode node)
        {
            BinaryTreeNode currentNode = node;
            while (node.Left != null)
            {
                currentNode = currentNode.Left;
            }

            return currentNode;
        }
        private static void GetInOrderTraversalOrderByNodes(BinaryTreeNode node, List<BinaryTreeNode> inOrderTraversalNodes)
        {
            if (node == null)
            {
                return;
            }

            GetInOrderTraversalOrderByNodes(node.Left, inOrderTraversalNodes);
            inOrderTraversalNodes.Add(node);
            GetInOrderTraversalOrderByNodes(node.Right, inOrderTraversalNodes);
        }
        private static void GetInOrderTraversalOrderByValue(BinaryTreeNode binaryTreeNode, List<int> inOrderTraversalOrderValues)
        {
            if (binaryTreeNode == null)
            {
                return;
            }

            GetInOrderTraversalOrderByValue(binaryTreeNode.Left, inOrderTraversalOrderValues);
            inOrderTraversalOrderValues.Add(binaryTreeNode.Value);
            GetInOrderTraversalOrderByValue(binaryTreeNode.Right, inOrderTraversalOrderValues);
        }
    }
}
