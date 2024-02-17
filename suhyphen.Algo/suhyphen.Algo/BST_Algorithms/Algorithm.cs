using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace suhyphen.Algo.BST_Algorithms
{
    internal class Algorithm
    {
        public static void Insert(BinarySearchTree binarySearchTree, int data)
        {
            BinarySearchTreeNode rootNode = binarySearchTree.Root;
            BinarySearchTreeNode newNode = new BinarySearchTreeNode(data);

            if (rootNode == null)
            {
                binarySearchTree.Root = newNode;
            }
            else
            {
                BinarySearchTreeNode currentNode = rootNode;
                while (true)
                {
                    BinarySearchTreeNode parentNode = currentNode;
                    if (newNode.Data < currentNode.Data)
                    {
                        currentNode = currentNode.Left;
                        if (currentNode == null)
                        {
                            parentNode.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                        if (currentNode == null)
                        {
                            parentNode.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public static void InOrderTraversal(BinarySearchTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraversal(root.Left);
            Console.Write(root.Data + " ");
            InOrderTraversal(root.Right);
        }

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
