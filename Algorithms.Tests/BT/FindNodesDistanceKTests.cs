// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Common;
using Algorithms.BT.FindNodesDistanceK;

namespace Algorithms.Tests.BT
{
    [TestClass]
    public class FindNodesDistanceKTests
    {
        [TestMethod]
        public void TestCase1()
        {
            // Construct a Custom Binary Tree
            var binaryTreeNode1 = new BinaryTreeNode(1);
            var binaryTreeNode2 = new BinaryTreeNode(2);
            var binaryTreeNode3 = new BinaryTreeNode(3);
            var binaryTreeNode4 = new BinaryTreeNode(4);
            var binaryTreeNode5 = new BinaryTreeNode(5);
            var binaryTreeNode6 = new BinaryTreeNode(6);
            var binaryTreeNode7 = new BinaryTreeNode(7);
            var binaryTreeNode8 = new BinaryTreeNode(8);

            var binaryTree = new BinaryTree
            {
                Root = binaryTreeNode1
            };

            binaryTree.Root.Left = binaryTreeNode2;
            binaryTree.Root.Right = binaryTreeNode3;
            binaryTreeNode2.Left = binaryTreeNode4;
            binaryTreeNode2.Right = binaryTreeNode5;
            binaryTreeNode3.Right = binaryTreeNode6;
            binaryTreeNode6.Left = binaryTreeNode7;
            binaryTreeNode6.Right = binaryTreeNode8;

            List<int> expected = [2,7,8];
            var actual = Algorithm.Run(binaryTree.Root, 3, 2);
            CollectionAssert.IsSubsetOf(actual, expected);           
        }
    }
}
