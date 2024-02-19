using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.LL.MiddleNode
{
    internal static class Runner
    {
        public static void Run()
        {
            var singleLinkedList = new SingleLinkedList();
            _ = new SingleLinkedListHelper();
            SingleLinkedListHelper.InsertLast(singleLinkedList, 2);
			SingleLinkedListHelper.InsertLast(singleLinkedList, 7);
			SingleLinkedListHelper.InsertLast(singleLinkedList, 3);
			SingleLinkedListHelper.InsertLast(singleLinkedList, 5);

			// This should output: 2 7 3 5
			SingleLinkedListHelper.Traverse(singleLinkedList);

            var middle = Algorithm.MiddleNode(singleLinkedList);
			// This should output: 3 5
			SingleLinkedListHelper.Traverse(middle);
        }
    }
}
