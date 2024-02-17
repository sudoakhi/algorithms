using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    internal class BinarySearchTreeHelper
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
    }
}
