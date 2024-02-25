// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.BT.FindNodeDepths;
using Algorithms.BT;

namespace Algorithms.Tests.BT
{
    [TestClass]
    public class FindNodeDepthsTests
    {
        [TestMethod]
        public void TestCase1()
        {
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

            var expected = 16;
            var actual = Algorithm.Run(binaryTree.Root);
            Assert.AreEqual(expected, actual);
        }
    }
}
