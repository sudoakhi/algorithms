using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;

namespace suhyphen.Algo.LL_LinkedListPalindrome
{
    internal class Algorithm
    {
        public static bool LinkedListPalindrome(SingleLinkedList singleLinkedList)
        {
            SingleLinkedListNode slowNode = singleLinkedList.Head;
            SingleLinkedListNode fastNode = singleLinkedList.Head;

            while(fastNode != null && fastNode.Next != null) 
            {
                slowNode = slowNode.Next;
                fastNode = fastNode.Next.Next;
            }

            SingleLinkedList secondHalfLinkedList = new SingleLinkedList();
            secondHalfLinkedList.Head = slowNode;

            SingleLinkedList reversedSecondHalfLinkedList = ReverseLinkedList(secondHalfLinkedList);
            SingleLinkedListNode firstHalfLinkedListHead = singleLinkedList.Head;
            SingleLinkedListNode secondHalfLinkedListHead = reversedSecondHalfLinkedList.Head;

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
            SingleLinkedListNode currentNode = singleLinkedList.Head;
            SingleLinkedListNode previousNode = null;
            while(currentNode != null)
            {
                SingleLinkedListNode nextNode = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            singleLinkedList.Head = previousNode;
            return singleLinkedList;
        }
    }
}
