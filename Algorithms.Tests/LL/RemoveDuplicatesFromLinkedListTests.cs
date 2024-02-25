// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.LL;
using Algorithms.LL.RemoveDuplicatesFromLinkedList;

namespace Algorithms.Tests.LL
{
    [TestClass]
    public class RemoveDuplicatesFromLinkedListTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var singleLinkedList = new SingleLinkedList();
            SingleLinkedListHelper.InsertLast(singleLinkedList, 50);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 50);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 50);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 60);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 70);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 70);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 80);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 90);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 90);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 90);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 90);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 100);

            List<int> expected = [50, 60, 70, 80, 90, 100];
            singleLinkedList = Algorithm.Run(singleLinkedList);
            var actual = SingleLinkedListHelper.Traverse(singleLinkedList);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
