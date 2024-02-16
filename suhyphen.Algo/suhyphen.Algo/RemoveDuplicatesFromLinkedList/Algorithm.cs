using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace suhyphen.Algo.RemoveDuplicatesFromLinkedList
{
    internal class Algorithm
    {
        public static SingleLinkedList RemoveDuplicatesFromLinkedList(SingleLinkedList singleLinkedList)
        {
            SingleLinkedListNode currentNode = singleLinkedList.Head;
            while (currentNode != null)
            {
                SingleLinkedListNode nextNode = currentNode.Next;
                while (nextNode != null && nextNode.Value == currentNode.Value)
                {
                    nextNode = nextNode.Next;
                }
                currentNode.Next = nextNode;
                currentNode = nextNode;
            }

            return singleLinkedList;
        }
    }
}
