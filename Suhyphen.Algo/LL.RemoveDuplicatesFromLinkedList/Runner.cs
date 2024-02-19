using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.LL.RemoveDuplicatesFromLinkedList
{
    internal static class Runner
    {
        public static void Run()
        {
            var singleLinkedList = new SingleLinkedList();
            _ = new SingleLinkedListHelper();
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

			// This should output: 50 50 50 60 70 70 80 90 90 90 90 100
			SingleLinkedListHelper.Traverse(singleLinkedList);

            // This should output: 50 60 70 80 90 100
            singleLinkedList = Algorithm.RemoveDuplicatesFromLinkedList(singleLinkedList);
			SingleLinkedListHelper.Traverse(singleLinkedList);

        }
    }
}
