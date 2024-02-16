using suhyphen.Algo.Common;
using System;

namespace suhyphen.Algo.FindSuccessorInBinaryTree
{
    internal class Runner
    {
        public static void Run()
        {
            BinaryTreeHelper binaryTreeHelper = new BinaryTreeHelper();

            // Generate a Binary Tree
            BinaryTree binaryTree = new BinaryTree();
            binaryTreeHelper.Insert(binaryTree, 1);
            binaryTreeHelper.Insert(binaryTree, 2);
            binaryTreeHelper.Insert(binaryTree, 3);
            binaryTreeHelper.Insert(binaryTree, 4);
            binaryTreeHelper.Insert(binaryTree, 5);
            binaryTreeHelper.Insert(binaryTree, 6);
            binaryTreeHelper.Insert(binaryTree, 7);
            binaryTreeHelper.Insert(binaryTree, 8);
            
            //This should output : 8 4 2 5 1 6 3 7
            binaryTreeHelper.RecursiveInorderTraversal(binaryTree.Root);
            Console.WriteLine();

            //This should output : 4
            int? successorValue = Algorithm.FindSuccessorSubOptimalByValue(binaryTree, 8);
            if(successorValue != null)
            {
                Console.WriteLine("Successor Value found: " + successorValue);
            }
            else
            {
                Console.WriteLine("No successor found!");
            }

            //This should output : 5
            successorValue = Algorithm.FindSuccessorSubOptimalByValue(binaryTree, 2);
            if (successorValue != null)
            {
                Console.WriteLine("Successor Value found: " + successorValue);
            }
            else
            {
                Console.WriteLine("No successor found!");
            }

            //This should output : No successor found!
            successorValue = Algorithm.FindSuccessorSubOptimalByValue(binaryTree, 7);
            if (successorValue != null)
            {
                Console.WriteLine("Successor Value found: " + successorValue);
            }
            else
            {
                Console.WriteLine("No successor found!");
            }

            // Construct a Custom Binary Tree
            BinaryTreeNode binaryTreeNode1 = new BinaryTreeNode(1);
            BinaryTreeNode binaryTreeNode2 = new BinaryTreeNode(2);
            BinaryTreeNode binaryTreeNode3 = new BinaryTreeNode(3);
            BinaryTreeNode binaryTreeNode4 = new BinaryTreeNode(4);
            BinaryTreeNode binaryTreeNode5 = new BinaryTreeNode(5);
            BinaryTreeNode binaryTreeNode6 = new BinaryTreeNode(6);

            BinaryTree newBinaryTree = new BinaryTree
            {
                Root = binaryTreeNode1
            };

            newBinaryTree.Root.Left = binaryTreeNode2;
            newBinaryTree.Root.Right = binaryTreeNode3;
            binaryTreeNode2.Left = binaryTreeNode4;
            binaryTreeNode2.Right = binaryTreeNode5;
            binaryTreeNode2.Parent = binaryTreeNode1;
            binaryTreeNode3.Parent = binaryTreeNode1;
            binaryTreeNode4.Left = binaryTreeNode6;
            binaryTreeNode4.Parent = binaryTreeNode2;
            binaryTreeNode5.Parent = binaryTreeNode2;
            binaryTreeNode6.Parent = binaryTreeNode4;

            //This should output : 6 4 2 5 1 3
            binaryTreeHelper.RecursiveInorderTraversal(newBinaryTree.Root);
            Console.WriteLine();

            // This should output: Node with value as 1
            BinaryTreeNode successorNode = Algorithm.FindSuccessorSubOptimalByNode(newBinaryTree, binaryTreeNode5);
            if(successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode.Value);
            }
            else
            {
                Console.WriteLine("No Successor found!");
            }

            // This should output: Node with value as 3
            successorNode = Algorithm.FindSuccessorSubOptimalByNode(newBinaryTree, binaryTreeNode1);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode.Value);
            }
            else
            {
                Console.WriteLine("No Successor found!");
            }

            // This should output: No Successor found!
            successorNode = Algorithm.FindSuccessorSubOptimalByNode(newBinaryTree, binaryTreeNode3);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode.Value);
            }
            else
            {
                Console.WriteLine("No Successor found!");
            }

            // This should output: Node with value as 3
            successorNode = Algorithm.FindSuccessorOptimalByNode(binaryTreeNode1);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode.Value);
            }
            else
            {
                Console.WriteLine("No Successor found!");
            }

            // This should output: Node with value as 1
            successorNode = Algorithm.FindSuccessorOptimalByNode(binaryTreeNode5);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode.Value);
            }
            else
            {
                Console.WriteLine("No Successor found!");
            }

            // This should output: No Successor found!
            successorNode = Algorithm.FindSuccessorOptimalByNode(binaryTreeNode3);
            if (successorNode != null)
            {
                Console.WriteLine("Successor Node found with Value: " + successorNode.Value);
            }
            else
            {
                Console.WriteLine("No Successor found!");
            }
        }
    }
}
