using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.BST_FindClosestValue
{
    internal class Runner
    {
        public static void Run()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
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
            BinarySearchTreeHelper.InOrderTraversal(binarySearchTree.Root);
            Console.WriteLine();

            //This should output 13
            int closestValueInBST = Algorithm.FindClosestValueInBst(binarySearchTree.Root, 12);
            Console.WriteLine(closestValueInBST);
        }
    }
}
