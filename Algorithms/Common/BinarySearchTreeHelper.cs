using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Common
{
    internal static class BinarySearchTreeHelper
    {
        internal static void Insert(BinarySearchTree binarySearchTree, int data)
        {
            var rootNode = binarySearchTree._root;
            var newNode = new BinarySearchTreeNode(data);

            if (rootNode == null)
            {
                binarySearchTree._root = newNode;
            }
            else
            {
                var currentNode = rootNode;
                while (true)
                {
                    var parentNode = currentNode;
                    if (newNode._data < currentNode._data)
                    {
                        currentNode = currentNode._left;
                        if ( currentNode != null )
                        {
                            continue;
                        }
                        parentNode._left = newNode;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode._right;
                        if (currentNode == null)
                        {
                            parentNode._right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        internal static void InOrderTraversal(BinarySearchTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraversal(root._left);
            Console.Write(root._data + " ");
            InOrderTraversal(root._right);
        }
    }
}
