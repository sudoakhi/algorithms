using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BST.FindClosestValue
{
    internal static class Runner
    {
        internal static void Run()
        {
            var binarySearchTree = new BinarySearchTree();
            BinarySearchTreeHelper.Insert(binarySearchTree, 10);
            BinarySearchTreeHelper.Insert(binarySearchTree, 5);
            BinarySearchTreeHelper.Insert(binarySearchTree, 15);
            BinarySearchTreeHelper.Insert(binarySearchTree, 2);
            BinarySearchTreeHelper.Insert(binarySearchTree, 5);
            BinarySearchTreeHelper.Insert(binarySearchTree, 13);
            BinarySearchTreeHelper.Insert(binarySearchTree, 22);
            BinarySearchTreeHelper.Insert(binarySearchTree, 1);
            BinarySearchTreeHelper.Insert(binarySearchTree, 14);

            // This should output: 1 2 5 5 10 13 14 15 22
            BinarySearchTreeHelper.InOrderTraversal(binarySearchTree._root);
            Console.WriteLine();

            //This should output 13
            var closestValueInBST = Algorithm.FindClosestValueInBst(binarySearchTree._root, 12);
            Console.WriteLine(closestValueInBST);
        }
    }
}
