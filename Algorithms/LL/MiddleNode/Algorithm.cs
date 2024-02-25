using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LL.MiddleNode
{
    public static class Algorithm
    {
        public static SingleLinkedList Run(SingleLinkedList singleLinkedList)
        {
            if(singleLinkedList == null)
            {
                return null;
            }

            var head = singleLinkedList.Head;
            if(head == null || head.Next == null)
            {
                return singleLinkedList;
            }

            var slowNode = singleLinkedList.Head;
            var fastNode = singleLinkedList.Head;
            while(fastNode != null)
            {
                slowNode = slowNode.Next;
                fastNode = fastNode.Next.Next;
            }

            var middle = new SingleLinkedList
            {
                Head = slowNode
            };
            return middle;
        }
    }
}
