using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BST
{
    public static class BinarySearchTreeHelper
    {
        public static void Insert(BinarySearchTree binarySearchTree, int data)
        {
            if(binarySearchTree == null)
            {
                return;
            }

            var rootNode = binarySearchTree.Root;
            var newNode = new BinarySearchTreeNode(data);

            if(rootNode == null)
            {
                binarySearchTree.Root = newNode;
            }
            else
            {
                var currentNode = rootNode;
                while(true)
                {
                    var parentNode = currentNode;
                    if(newNode.Value < currentNode.Value)
                    {
                        currentNode = currentNode.Left;
                        if(currentNode != null)
                        {
                            continue;
                        }
                        parentNode.Left = newNode;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                        if(currentNode == null)
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
            if(root == null)
            {
                return;
            }

            InOrderTraversal(root.Left);
            Console.Write(root.Value + " ");
            InOrderTraversal(root.Right);
        }
    }
}
