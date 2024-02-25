// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.BST.FindClosestValue;
using Algorithms.BST;

namespace Algorithms.Tests.BST
{
    [TestClass]
    public class FindClosestValueTests
    {
        [TestMethod]
        public void TestCase1()
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

            var expected = 13;
            var actual = Algorithm.Run(binarySearchTree.Root, 12);
            Assert.AreEqual(expected, actual);
        }
    }
}
