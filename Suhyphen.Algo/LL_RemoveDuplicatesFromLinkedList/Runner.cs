using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.LL_RemoveDuplicatesFromLinkedList
{
    internal class Runner
    {
        public static void Run()
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            SingleLinkedListHelper singleLinkedListHelper = new SingleLinkedListHelper();
            singleLinkedListHelper.InsertLast(singleLinkedList, 50);
            singleLinkedListHelper.InsertLast(singleLinkedList, 50);
            singleLinkedListHelper.InsertLast(singleLinkedList, 50);
            singleLinkedListHelper.InsertLast(singleLinkedList, 60);
            singleLinkedListHelper.InsertLast(singleLinkedList, 70);
            singleLinkedListHelper.InsertLast(singleLinkedList, 70);
            singleLinkedListHelper.InsertLast(singleLinkedList, 80);
            singleLinkedListHelper.InsertLast(singleLinkedList, 90);
            singleLinkedListHelper.InsertLast(singleLinkedList, 90);
            singleLinkedListHelper.InsertLast(singleLinkedList, 90);
            singleLinkedListHelper.InsertLast(singleLinkedList, 90);
            singleLinkedListHelper.InsertLast(singleLinkedList, 100);

            // This should output: 50 50 50 60 70 70 80 90 90 90 90 100
            singleLinkedListHelper.Traverse(singleLinkedList);

            // This should output: 50 60 70 80 90 100
            singleLinkedList = Algorithm.RemoveDuplicatesFromLinkedList(singleLinkedList);
            singleLinkedListHelper.Traverse(singleLinkedList);

        }
    }
}
