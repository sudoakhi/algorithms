using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.BT.EvaluateExpressionTree
{
    internal static class Runner
    {
        public static void Run()
        {
            // Generate a Binary Tree
            var binaryTree = new BinaryTree();
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
            var result = Algorithm.EvaluateExpressionTree(binaryTree._root);
            Console.WriteLine(result);
        }
    }
}
