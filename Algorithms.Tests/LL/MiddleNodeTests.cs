// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.LL;
using Algorithms.LL.MiddleNode;

namespace Algorithms.Tests.LL
{
    [TestClass]
    public class MiddleNodeTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var singleLinkedList = new SingleLinkedList();
            SingleLinkedListHelper.InsertLast(singleLinkedList, 2);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 7);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 3);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 5);

            List<int> expected = [3, 5];
            singleLinkedList = Algorithm.Run(singleLinkedList);
            var actual = SingleLinkedListHelper.Traverse(singleLinkedList);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
