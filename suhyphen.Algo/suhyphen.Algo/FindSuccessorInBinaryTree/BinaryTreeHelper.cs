﻿using System;
using System.Collections.Generic;

namespace suhyphen.Algo.FindSuccessorInBinaryTree
{
    internal class BinaryTreeHelper
    {
        public void Insert(BinaryTree binaryTree, int value)
        {
            BinaryTreeNode newBinaryTreeNode = new BinaryTreeNode(value);

            if(binaryTree.Root == null)
            {
                binaryTree.Root = newBinaryTreeNode;
                return;
            }

            Queue<BinaryTreeNode> nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(binaryTree.Root);
            while(nodeQueue.Count > 0)
            {
                BinaryTreeNode currentNode = nodeQueue.Dequeue();
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

        internal void RecursiveInorderTraversal(BinaryTreeNode binaryTreeNode)
        {
            if (binaryTreeNode == null)
            {
                return;
            }

            RecursiveInorderTraversal(binaryTreeNode.Left);
            Console.Write(binaryTreeNode.Value + " ");
            RecursiveInorderTraversal(binaryTreeNode.Right);
        }

        internal BinaryTreeNode FindSuccessorOptimalByNode(BinaryTreeNode inputBinaryTreeNode)
        {
            if(inputBinaryTreeNode.Right != null)
            {
                return GetLeftMostChild(inputBinaryTreeNode.Right);
            }

            return GetRightMostParent(inputBinaryTreeNode);
        }

        private BinaryTreeNode GetRightMostParent(BinaryTreeNode node)
        {
            BinaryTreeNode currentNode = node;
            while(currentNode.Parent != null && currentNode.Parent.Right == currentNode)
            {
                currentNode = currentNode.Parent;
            }

            return currentNode.Parent;
        }

        private BinaryTreeNode GetLeftMostChild(BinaryTreeNode node)
        {
            BinaryTreeNode currentNode = node;
            while(node.Left != null)
            {
                currentNode = currentNode.Left;
            }

            return currentNode;
        }

        internal int? FindSuccessorSubOptimalByValue(BinaryTree binaryTree, int inputValue)
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

        internal void GetInOrderTraversalOrderByValue(BinaryTreeNode binaryTreeNode, List<int> inOrderTraversalOrderValues)
        {
            if (binaryTreeNode == null)
            {
                return;
            }

            GetInOrderTraversalOrderByValue(binaryTreeNode.Left, inOrderTraversalOrderValues);
            inOrderTraversalOrderValues.Add(binaryTreeNode.Value);
            GetInOrderTraversalOrderByValue(binaryTreeNode.Right, inOrderTraversalOrderValues);
        }

        public BinaryTreeNode FindSuccessorSubOptimalByNode(BinaryTree binaryTree, BinaryTreeNode inputBinaryTreeNode)
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

        void GetInOrderTraversalOrderByNodes(BinaryTreeNode node, List<BinaryTreeNode> inOrderTraversalNodes)
        {
            if (node == null)
            {
                return;
            }

            GetInOrderTraversalOrderByNodes(node.Left, inOrderTraversalNodes);
            inOrderTraversalNodes.Add(node);
            GetInOrderTraversalOrderByNodes(node.Right, inOrderTraversalNodes);
        }
    }
}
