using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Algorithms.LL.RemoveDuplicatesFromLinkedList
{
    public static class Algorithm
    {
        public static SingleLinkedList Run(SingleLinkedList singleLinkedList)
        {
            if(singleLinkedList == null)
            {
                return null;
            }
            var currentNode = singleLinkedList.Head;
            while(currentNode != null)
            {
                var nextNode = currentNode.Next;
                while(nextNode != null && nextNode.Value == currentNode.Value)
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
