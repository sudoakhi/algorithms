using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;

namespace Algorithms.LL.LinkedListPalindrome
{
    public static class Algorithm
    {
        public static bool Run(SingleLinkedList singleLinkedList)
        {
            if(singleLinkedList == null)
            {
                return false;
            }

            var slowNode = singleLinkedList.Head;
            var fastNode = singleLinkedList.Head;

            while(fastNode != null && fastNode.Next != null)
            {
                slowNode = slowNode.Next;
                fastNode = fastNode.Next.Next;
            }

            var secondHalfLinkedList = new SingleLinkedList
            {
                Head = slowNode
            };

            var reversedSecondHalfLinkedList = ReverseLinkedList(secondHalfLinkedList);
            var firstHalfLinkedListHead = singleLinkedList.Head;
            var secondHalfLinkedListHead = reversedSecondHalfLinkedList.Head;

            while(secondHalfLinkedListHead != null)
            {
                if(secondHalfLinkedListHead.Value != firstHalfLinkedListHead.Value)
                {
                    return false;
                }

                firstHalfLinkedListHead = firstHalfLinkedListHead.Next;
                secondHalfLinkedListHead = secondHalfLinkedListHead.Next;
            }

            return true;
        }

        public static SingleLinkedList ReverseLinkedList(SingleLinkedList singleLinkedList)
        {
            if(singleLinkedList == null)
            {
                return null;
            }

            var currentNode = singleLinkedList.Head;
            SingleLinkedListNode previousNode = null;
            while(currentNode != null)
            {
                var nextNode = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            singleLinkedList.Head = previousNode;
            return singleLinkedList;
        }
    }
}
