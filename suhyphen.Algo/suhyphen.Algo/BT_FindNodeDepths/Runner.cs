using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.BT_FindNodeDepths
{
    internal class Runner
    {
        public static void Run()
        {
            // Generate a Binary Tree
            BinaryTree binaryTree = new BinaryTree();
            BinaryTreeHelper.Insert(binaryTree, 1);
            BinaryTreeHelper.Insert(binaryTree, 2);
            BinaryTreeHelper.Insert(binaryTree, 3);
            BinaryTreeHelper.Insert(binaryTree, 4);
            BinaryTreeHelper.Insert(binaryTree, 5);
            BinaryTreeHelper.Insert(binaryTree, 6);
            BinaryTreeHelper.Insert(binaryTree, 7);
            BinaryTreeHelper.Insert(binaryTree, 8);
            BinaryTreeHelper.Insert(binaryTree, 9);

            //This should output : 8 4 9 2 5 1 6 3 7
            Console.WriteLine("InOrder Traversal");
            BinaryTreeHelper.RecursiveInorderTraversal(binaryTree.Root);
            Console.WriteLine();
        }
    }
}
