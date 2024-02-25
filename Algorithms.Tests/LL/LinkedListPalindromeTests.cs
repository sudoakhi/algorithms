// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.LL;
using Algorithms.LL.LinkedListPalindrome;

namespace Algorithms.Tests.LL
{
    [TestClass]
    public class LinkedListPalindromeTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var singleLinkedList = new SingleLinkedList();
            SingleLinkedListHelper.InsertLast(singleLinkedList, 0);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 1);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 2);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 2);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 1);
            SingleLinkedListHelper.InsertLast(singleLinkedList, 0);

            var expected = true;
            var actual = Algorithm.Run(singleLinkedList);
            Assert.AreEqual(expected, actual);
        }
    }
}
