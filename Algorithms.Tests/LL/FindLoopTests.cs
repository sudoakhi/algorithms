// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Algorithms.LL;
using Algorithms.LL.FindLoop;

namespace Algorithms.Tests.LL
{
    [TestClass]
    public class FindLoopTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var node0 = new SingleLinkedListNode(0);
            var node1 = new SingleLinkedListNode(1);
            var node2 = new SingleLinkedListNode(2);
            var node3 = new SingleLinkedListNode(3);
            var node4 = new SingleLinkedListNode(4);
            var node5 = new SingleLinkedListNode(5);
            var node6 = new SingleLinkedListNode(6);
            var node7 = new SingleLinkedListNode(7);
            var node8 = new SingleLinkedListNode(8);
            var node9 = new SingleLinkedListNode(9);

            var singleLinkedList = new SingleLinkedList
            {
                Head = node0
            };

            singleLinkedList.Head = node0;
            node0.Next = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node8;
            node8.Next = node9;
            node9.Next = node4;

            var expected = node4;
            var actual = Algorithm.Run(singleLinkedList.Head);
            Assert.AreEqual(expected, actual);
        }
    }
}
