using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.BST_Algorithms
{
    internal class Runner
    {
        public static void Run()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            Algorithm.Insert(binarySearchTree, 10);
            Algorithm.Insert(binarySearchTree, 5);
            Algorithm.Insert(binarySearchTree, 15);
            Algorithm.Insert(binarySearchTree, 2);
            Algorithm.Insert(binarySearchTree, 5);
            Algorithm.Insert(binarySearchTree, 13);
            Algorithm.Insert(binarySearchTree, 22);
            Algorithm.Insert(binarySearchTree, 1);
            Algorithm.Insert(binarySearchTree, 14);

            // This should output: 1 2 5 5 10 13 14 15 22
            Algorithm.InOrderTraversal(binarySearchTree.Root);
            Console.WriteLine();

            //This should output 13
            int closestValueInBST = Algorithm.FindClosestValueInBst(binarySearchTree.Root, 12);
            Console.WriteLine(closestValueInBST);
        }
    }
}
