using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.LinkedListPalindrome
{
    internal class Runner
    {
        public static void Run()
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            SingleLinkedListHelper singleLinkedListHelper = new SingleLinkedListHelper();
            singleLinkedListHelper.InsertLast(singleLinkedList, 0);
            singleLinkedListHelper.InsertLast(singleLinkedList, 1);
            singleLinkedListHelper.InsertLast(singleLinkedList, 2);
            singleLinkedListHelper.InsertLast(singleLinkedList, 2);
            singleLinkedListHelper.InsertLast(singleLinkedList, 1);
            singleLinkedListHelper.InsertLast(singleLinkedList, 0);

            // This should output: 0 1 2 3 4 5
            singleLinkedListHelper.Traverse(singleLinkedList);

            // This should output: 5 4 3 2 1 0
            singleLinkedList = Algorithm.ReverseLinkedList(singleLinkedList);
            singleLinkedListHelper.Traverse(singleLinkedList);

            bool isPalindrom = Algorithm.LinkedListPalindrome(singleLinkedList);
            Console.WriteLine("isPalindrome: " + isPalindrom);

        }
    }
}
