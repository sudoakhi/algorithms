using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.BT_EvaluateExpressionTree
{
    internal class Runner
    {
        public static void Run()
        {
            // Generate a Binary Tree
            BinaryTree binaryTree = new BinaryTree();
            BinaryTreeHelper.Insert(binaryTree, -1);
            BinaryTreeHelper.Insert(binaryTree, -2);
            BinaryTreeHelper.Insert(binaryTree, -3);
            BinaryTreeHelper.Insert(binaryTree, -4);
            BinaryTreeHelper.Insert(binaryTree, 2);
            BinaryTreeHelper.Insert(binaryTree, 8);
            BinaryTreeHelper.Insert(binaryTree, 3);
            BinaryTreeHelper.Insert(binaryTree, 2);
            BinaryTreeHelper.Insert(binaryTree, 3);

            // This should result 6
            int result = Algorithm.EvaluateExpressionTree(binaryTree.Root);
            Console.WriteLine(result);
        }
    }
}
