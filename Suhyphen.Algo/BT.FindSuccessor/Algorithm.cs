using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;

namespace Suhyphen.Algo.BT.FindSuccessor
{
    public sealed class Algorithm
    {
        internal static BinaryTreeNode FindSuccessorOptimalByNode(BinaryTreeNode inputBinaryTreeNode)
        {
			return inputBinaryTreeNode._right != null ? GetLeftMostChild(inputBinaryTreeNode._right) : GetRightMostParent(inputBinaryTreeNode);
			}
		internal static int? FindSuccessorSubOptimalByValue(BinaryTree binaryTree, int inputValue)
        {
            var inOrderTraversalOrderValues = new List<int>();
            GetInOrderTraversalOrderByValue(binaryTree._root, inOrderTraversalOrderValues);

            for (var i = 0; i < inOrderTraversalOrderValues.Count; i++)
            {
                var value = inOrderTraversalOrderValues[i];
                if (value != inputValue)
                {
                    continue;
                }

				return i == inOrderTraversalOrderValues.Count - 1 ? null : inOrderTraversalOrderValues [i + 1];
				}

			return null;
        }
        internal static BinaryTreeNode FindSuccessorSubOptimalByNode(BinaryTree binaryTree, BinaryTreeNode inputBinaryTreeNode)
        {
            var inOrderTraversalNodes = new List<BinaryTreeNode>();
            GetInOrderTraversalOrderByNodes(binaryTree._root, inOrderTraversalNodes);
            for (var i = 0; i < inOrderTraversalNodes.Count; i++)
            {
                var currentNode = inOrderTraversalNodes[i];
                if (currentNode != inputBinaryTreeNode)
                {
                    continue;
                }

				return i == inOrderTraversalNodes.Count - 1 ? null : inOrderTraversalNodes [i + 1];
				}

			return null;
        }
        private static BinaryTreeNode GetRightMostParent(BinaryTreeNode node)
        {
            var currentNode = node;
            while (currentNode._parent != null && currentNode._parent._right == currentNode)
            {
                currentNode = currentNode._parent;
            }

            return currentNode._parent;
        }
        private static BinaryTreeNode GetLeftMostChild(BinaryTreeNode node)
        {
            var currentNode = node;
            while (node._left != null)
            {
                currentNode = currentNode._left;
            }

            return currentNode;
        }
        private static void GetInOrderTraversalOrderByNodes(BinaryTreeNode node, List<BinaryTreeNode> inOrderTraversalNodes)
        {
            if (node == null)
            {
                return;
            }

            GetInOrderTraversalOrderByNodes(node._left, inOrderTraversalNodes);
            inOrderTraversalNodes.Add(node);
            GetInOrderTraversalOrderByNodes(node._right, inOrderTraversalNodes);
        }
        private static void GetInOrderTraversalOrderByValue(BinaryTreeNode binaryTreeNode, List<int> inOrderTraversalOrderValues)
        {
            if (binaryTreeNode == null)
            {
                return;
            }

            GetInOrderTraversalOrderByValue(binaryTreeNode._left, inOrderTraversalOrderValues);
            inOrderTraversalOrderValues.Add(binaryTreeNode._value);
            GetInOrderTraversalOrderByValue(binaryTreeNode._right, inOrderTraversalOrderValues);
        }
    }
}
