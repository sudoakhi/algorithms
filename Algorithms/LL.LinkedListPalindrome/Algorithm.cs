using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;

namespace Algorithms.LL.LinkedListPalindrome
{
    internal static class Algorithm
    {
        internal static bool LinkedListPalindrome(SingleLinkedList singleLinkedList)
        {
            if(singleLinkedList == null)
            {
                return false;
            }

            var slowNode = singleLinkedList._head;
            var fastNode = singleLinkedList._head;

            while(fastNode != null && fastNode._next != null) 
            {
                slowNode = slowNode._next;
                fastNode = fastNode._next._next;
            }

            var secondHalfLinkedList = new SingleLinkedList
            {
                _head = slowNode
            };

            var reversedSecondHalfLinkedList = ReverseLinkedList(secondHalfLinkedList);
            var firstHalfLinkedListHead = singleLinkedList._head;
            var secondHalfLinkedListHead = reversedSecondHalfLinkedList._head;

            while(secondHalfLinkedListHead != null)
            {
                if(secondHalfLinkedListHead._value != firstHalfLinkedListHead._value)
                {
                    return false;
                }

                firstHalfLinkedListHead = firstHalfLinkedListHead._next;
                secondHalfLinkedListHead = secondHalfLinkedListHead._next;
            }

            return true;
        }

        internal static SingleLinkedList ReverseLinkedList(SingleLinkedList singleLinkedList)
        {
            if (singleLinkedList == null)
            {
                return null;
            }

            var currentNode = singleLinkedList._head;
            SingleLinkedListNode previousNode = null;
            while(currentNode != null)
            {
                var nextNode = currentNode._next;
                currentNode._next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            singleLinkedList._head = previousNode;
            return singleLinkedList;
        }
    }
}
