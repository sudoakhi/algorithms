using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BT.FindNodeDepths
{
    internal static class Runner
    {
        internal static void Run()
        {
            // Generate a Binary Tree
            var binaryTree = new BinaryTree();
            BinaryTreeHelper.Insert(binaryTree, 1);
            BinaryTreeHelper.Insert(binaryTree, 2);
            BinaryTreeHelper.Insert(binaryTree, 3);
            BinaryTreeHelper.Insert(binaryTree, 4);
            BinaryTreeHelper.Insert(binaryTree, 5);
            BinaryTreeHelper.Insert(binaryTree, 6);
            BinaryTreeHelper.Insert(binaryTree, 7);
            BinaryTreeHelper.Insert(binaryTree, 8);
            BinaryTreeHelper.Insert(binaryTree, 9);

            //This should output : 8 4 9 2 5 1 6 3             
            BinaryTreeHelper.RecursiveInorderTraversal(binaryTree._root);
            Console.WriteLine();

            //This should output 16
            var result = Algorithm.GetNodeDepths(binaryTree._root);
            Console.WriteLine(result);
        }
    }
}
