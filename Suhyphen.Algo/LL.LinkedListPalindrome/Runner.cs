using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.LL.LinkedListPalindrome
{
    internal static class Runner
    {
        public static void Run()
        {
            var singleLinkedList = new SingleLinkedList();
            _ = new SingleLinkedListHelper();
            SingleLinkedListHelper.InsertLast(singleLinkedList, 0);
			SingleLinkedListHelper.InsertLast(singleLinkedList, 1);
			SingleLinkedListHelper.InsertLast(singleLinkedList, 2);
			SingleLinkedListHelper.InsertLast(singleLinkedList, 2);
			SingleLinkedListHelper.InsertLast(singleLinkedList, 1);
			SingleLinkedListHelper.InsertLast(singleLinkedList, 0);

			// This should output: 0 1 2 3 4 5
			SingleLinkedListHelper.Traverse(singleLinkedList);

            // This should output: 5 4 3 2 1 0
            singleLinkedList = Algorithm.ReverseLinkedList(singleLinkedList);
			SingleLinkedListHelper.Traverse(singleLinkedList);

            var isPalindrom = Algorithm.LinkedListPalindrome(singleLinkedList);
            Console.WriteLine("isPalindrome: " + isPalindrom);

        }
    }
}
