using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.LL_MiddleNode
{
    internal class Runner
    {
        public static void Run()
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            SingleLinkedListHelper singleLinkedListHelper = new SingleLinkedListHelper();
            singleLinkedListHelper.InsertLast(singleLinkedList, 2);
            singleLinkedListHelper.InsertLast(singleLinkedList, 7);
            singleLinkedListHelper.InsertLast(singleLinkedList, 3);
            singleLinkedListHelper.InsertLast(singleLinkedList, 5);

            // This should output: 2 7 3 5
            singleLinkedListHelper.Traverse(singleLinkedList);

            SingleLinkedList middle = Algorithm.MiddleNode(singleLinkedList);
            // This should output: 3 5
            singleLinkedListHelper.Traverse(middle);
        }
    }
}
