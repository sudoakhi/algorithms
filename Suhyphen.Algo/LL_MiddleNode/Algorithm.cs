using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.LL_MiddleNode
{
    internal class Algorithm
    {
        public static SingleLinkedList MiddleNode(SingleLinkedList singleLinkedList)
        {
            SingleLinkedListNode head = singleLinkedList.Head;
            if (head == null || head.Next == null)
            {
                return singleLinkedList;
            }

            SingleLinkedListNode slowNode = singleLinkedList.Head;
            SingleLinkedListNode fastNode = singleLinkedList.Head;
            while (fastNode != null && fastNode.Next != null)
            {
                slowNode = slowNode.Next;
                fastNode = fastNode.Next.Next;
            }

            SingleLinkedList middle = new SingleLinkedList();
            middle.Head = slowNode;
            return middle;
        }
    }
}
