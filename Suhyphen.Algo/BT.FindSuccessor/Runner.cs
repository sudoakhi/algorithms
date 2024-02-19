using Suhyphen.Algo.Common;
using System;

namespace Suhyphen.Algo.BT.FindSuccessor
{
    internal static class Runner
    {
        public static void Run()
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

            //This should output : 8 4 2 5 1 6 3 7
            BinaryTreeHelper.RecursiveInorderTraversal(binaryTree._root);
            Console.WriteLine();

            //This should output : 4
            var successorValue = Algorithm.FindSuccessorSubOptimalByValue(binaryTree, 8);
            if(successorValue != null)
            {
                Console.WriteLine("Successor Value found: " + successorValue);
            }

            //This should output : 5
            successorValue = Algorithm.FindSuccessorSubOptimalByValue(binaryTree, 2);
            if (successorValue != null)
            {
                Console.WriteLine("Successor Value found: " + successorValue);
            }

            //This should output : No successor found!
            successorValue = Algorithm.FindSuccessorSubOptimalByValue(binaryTree, 7);
            if (successorValue != null)
            {
                Console.WriteLine("Successor Value found: " + successorValue);
            }

            // Construct a Custom Binary Tree
            var binaryTreeNode1 = new BinaryTreeNode(1);
            var binaryTreeNode2 = new BinaryTreeNode(2);
            var binaryTreeNode3 = new BinaryTreeNode(3);
            var binaryTreeNode4 = new BinaryTreeNode(4);
            var binaryTreeNode5 = new BinaryTreeNode(5);
            var binaryTreeNode6 = new BinaryTreeNode(6);

            var newBinaryTree = new BinaryTree
            {
                _root = binaryTreeNode1
            };

            newBinaryTree._root._left = binaryTreeNode2;
            newBinaryTree._root._right = binaryTreeNode3;
            binaryTreeNode2._left = binaryTreeNode4;
            binaryTreeNode2._right = binaryTreeNode5;
            binaryTreeNode2._parent = binaryTreeNode1;
            binaryTreeNode3._parent = binaryTreeNode1;
            binaryTreeNode4._left = binaryTreeNode6;
            binaryTreeNode4._parent = binaryTreeNode2;
            binaryTreeNode5._parent = binaryTreeNode2;
            binaryTreeNode6._parent = binaryTreeNode4;

            //This should output : 6 4 2 5 1 3
            BinaryTreeHelper.RecursiveInorderTraversal(newBinaryTree._root);
            Console.WriteLine();

            // This should output: Node with value as 1
            var successorNode = Algorithm.FindSuccessorSubOptimalByNode(newBinaryTree, binaryTreeNode5);
            if(successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode._value);
            }

            // This should output: Node with value as 3
            successorNode = Algorithm.FindSuccessorSubOptimalByNode(newBinaryTree, binaryTreeNode1);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode._value);
            }

            // This should output: No Successor found!
            successorNode = Algorithm.FindSuccessorSubOptimalByNode(newBinaryTree, binaryTreeNode3);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode._value);
            }

            // This should output: Node with value as 3
            successorNode = Algorithm.FindSuccessorOptimalByNode(binaryTreeNode1);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode._value);
            }

            // This should output: Node with value as 1
            successorNode = Algorithm.FindSuccessorOptimalByNode(binaryTreeNode5);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode._value);
            }

            // This should output: No Successor found!
            successorNode = Algorithm.FindSuccessorOptimalByNode(binaryTreeNode3);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode._value);
            }
        }
    }
}
